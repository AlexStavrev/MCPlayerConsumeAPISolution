using MCPlayerApiClient.ApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Application.SetCompatibleTextRenderingDefault(false);
            IPlayerApiClient playerApiClient = new PlayerApiClient("https://api.mojang.com/");
            Application.Run(new PlayerViewerForm(playerApiClient));
        }
    }
}
