namespace UiExplorerRunner.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exeFileName = "C:\\Users\\Maxxx\\Desktop\\55555555555555\\UiExplorer.20.10.10\\runtime\\UiExplorer_x64.exe";
            string selector = "<wnd app='explorer.exe' cls='Shell_TrayWnd' idx='*' />\u000d\u000a<wnd cls='MSTaskSwWClass' title='Работающие приложения' />\u000d\u000a<wnd cls='MSTaskListWClass' title='Работающие приложения' />\u000d\u000a<ctrl name='Работающие приложения' role='tool bar' />\u000d\u000a<ctrl automationid='Chrome' name='Google Chrome —1 запущенное окно' role='push button' idx='2' />\u000d\u000a";
            //string selector = null;
            string result = ExplorerRunner.Run(exeFileName, selector);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
