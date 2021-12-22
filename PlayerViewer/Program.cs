using MCPlayerApiClient.ApiClient;
using System;
using System.Windows.Forms;

namespace PlayerViewer
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            IPlayerApiClient playerApiClient = new PlayerApiClient("https://api.mojang.com/");
            Application.Run(new PlayerViewerForm(playerApiClient));
        }
    }
}
