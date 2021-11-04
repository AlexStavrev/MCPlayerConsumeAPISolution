using MCPlayerApiClient.ApiClient;
using MCPlayerApplication.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCPlayerApplication
{
    public partial class MCPlayerFormApplication : Form
    {
        private readonly int _buttonCooldown;
        private bool _inCooldown;

        public IPlayerApiClient DataAcccess { get; set; }

        public MCPlayerFormApplication()
        {
            _buttonCooldown = 250;
            _inCooldown = false;
            DataAcccess = new PlayerApiClient("https://api.mojang.com/");
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(_inCooldown)
            {
                return;
            }
            _inCooldown = true;

            string uuid = await LoadUUIDAsync();
            lblUUID.Text = uuid;

            List<Task> tasks = new()
            {
                Task.Run(() => LoadPlayerImageAsync(uuid)),
                Task.Run(() => LoadPlayerNamesAsync(uuid))
            };

            await Task.WhenAll(tasks);
            _inCooldown = false;
        }

        private async Task LoadPlayerImageAsync(string uuid)
        {
            //await Task.Delay(5000);
            picturePlayerBodyImage.Image = await DataAcccess.GetBodyImageFromUUIDAsync(uuid);
        }

        private async Task LoadPlayerNamesAsync(string uuid)
        {
            //await Task.Delay(10000);
            listBoxNames.Items.Clear();
            (await DataAcccess.GetAllNamesAsync(uuid)).Reverse().ToList().ForEach(name => listBoxNames.AddItemThreadSafe(name));
        }

        private async Task<string> LoadUUIDAsync()
        {
            //await Task.Delay(5000);
            return await DataAcccess.GetUUIDFromNameAsync(txtName.Text);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await loadInitialImageAsync();
        }

        private async Task loadInitialImageAsync()
        {
            await LoadPlayerImageAsync("00000000-0000-0000-0000-000000000000");
        }
    }
}
