using MCPlayerApiClient.ApiClient;
using MCPlayerApplication.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCPlayerApplication
{
    public partial class MCPlayerFormApplication : Form
    {
        private bool _inCooldown;

        public IPlayerApiClient DataAcccess { get; set; }

        public MCPlayerFormApplication()
        {
            _inCooldown = false;
            DataAcccess = new PlayerApiClient("https://api.mojang.com/");
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadInitialImageAsync();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
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
                Task.Run(() => LoadPlayerNameChangesAsync(uuid))
            };

            await Task.WhenAll(tasks);
            _inCooldown = false;
        }

        private async Task LoadPlayerImageAsync(string uuid)
        {
            picturePlayerBodyImage.Image = await DataAcccess.GetBodyImageFromUUIDAsync(uuid);
        }

        private async Task LoadPlayerNameChangesAsync(string uuid)
        {
            listBoxNames.ClearThreadSafe();
            (await DataAcccess.GetAllNameChangesAsync(uuid)).Reverse().ToList().ForEach(name => listBoxNames.AddItemThreadSafe(name));
        }

        private async Task<string> LoadUUIDAsync()
        {
            return await DataAcccess.GetUUIDFromNameAsync(txtName.Text);
        }

        private async Task LoadInitialImageAsync()
        {
            await LoadPlayerImageAsync("00000000-0000-0000-0000-000000000000");
        }
    }
}
