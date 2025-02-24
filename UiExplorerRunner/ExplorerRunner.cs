using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace UiExplorerRunner
{
    public class ExplorerRunner
    {
        public static string Run(string uiExplorerExePath, string selector = null)
        {
            string selectorBase64 = Base64Encode(selector);

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = uiExplorerExePath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = false,
                StandardErrorEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage),
                Arguments = selectorBase64
            };
            process.StartInfo = startInfo;
            process.Start();

            string output = null;
            while (!process.StandardOutput.EndOfStream)
            {
                output = process.StandardOutput.ReadLine();
            }

            return output;
        }

        public static string Base64Encode(string plainText)
        {
            if (plainText == null)
            {
                return null;
            }

            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
