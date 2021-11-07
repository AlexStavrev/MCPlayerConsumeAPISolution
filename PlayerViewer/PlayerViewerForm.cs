using MCPlayerApiClient.ApiClient;
using MCPlayerApiClient.DTOs;
using PlayerViewer.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerViewer
{
    public partial class PlayerViewerForm : Form
    {
        readonly IPlayerApiClient _playerApiClient;
        private bool _inCooldown;
        private Size _formSize;
        private readonly int _borderSize;
        private PlayerDto _currentPlayer;

        public PlayerViewerForm(IPlayerApiClient playerApiClient)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
            _playerApiClient = playerApiClient;
            _borderSize = 2;
        }

        private void Exit()
        {
            Application.Exit();
            Dispose();
        }

        private void Maximise()
        {
            if (WindowState == FormWindowState.Normal)
            {
                _formSize = ClientSize;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                Size = _formSize;
            }
        }

        private void Minimise()
        {
            WindowState = FormWindowState.Minimized;
        }

        private async Task Search()
        {
            if (_inCooldown) { return; }
            _inCooldown = true;

            try
            {
                _currentPlayer = await _playerApiClient.GetPlayerFromName(txtName.Text);
                lblUUIDValue.Text = _currentPlayer.Id.ToString();

                List<Task> tasks = new()
                {
                    Task.Run(() => LoadPlayerImageAsync(_currentPlayer.Id)),
                    Task.Run(() => LoadPlayerNameChangesAsync(_currentPlayer.Id))
                };

                await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Account with name '{txtName.Text}' doesn't exist", "Unknown user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _inCooldown = false;
            }
        }

        private async Task LoadPlayerImageAsync(Guid uuid)
        {
            imagePlayerSkin.Image = await _playerApiClient.GetBodyImageFromUUIDAsync(uuid.ToString());
        }

        private async Task LoadPlayerNameChangesAsync(Guid uuid)
        {
            listBoxNames.ClearThreadSafe();
            (await _playerApiClient.GetAllNameChangesAsync(uuid.ToString())).Reverse().ToList().ForEach(nameChange => listBoxNames.AddItemThreadSafe(nameChange));
        }

        private async Task OnLoad()
        {
            Padding = new(_borderSize);
            lblTitle.Text = Text;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            tooltipDownload.SetToolTip(btnDownload, "Download skin");
            await LoadPlayerImageAsync(Guid.Parse("00000000-0000-0000-0000-000000000000"));
        }

        private void AdjustForm()
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    Padding = new Padding(8);
                    break;
                case FormWindowState.Normal:
                    if (Padding.Top != _borderSize)
                    {
                        Padding = new Padding(_borderSize);
                    }
                    break;
                default:
                    break;
            }
        }

        private void Download()
        {
            using WebClient client = new();
            saveFileSkinDialog.FileName = $"{_currentPlayer.Name}_Skin.png";
            if (saveFileSkinDialog.ShowDialog() == DialogResult.OK)
            {
                client.DownloadFile(new Uri($"https://crafatar.com/skins/{_currentPlayer.Id}"), saveFileSkinDialog.FileName);
            }
        }

        #region Control Events
        private void btnDispose_Click(object sender, EventArgs e) => Exit();
        private void btnMaximise_Click(object sender, EventArgs e) => Maximise();
        private void btnMinimise_Click(object sender, EventArgs e) => Minimise();
        private async void PlayerViewerForm_Load(object sender, EventArgs e) => await OnLoad();
        private async void btnSearch_Click(object sender, EventArgs e) => await Search();
        private void btnDownload_Click(object sender, EventArgs e) => Download();
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }
        private void tooltipDownload_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
        private void PlayerViewerForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        #endregion

        #region Dll Imports
        // Move form by dragging the title bar
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        #endregion

        #region Overrides
        // AeroSnap & Resize
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    _formSize = ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    Size = _formSize;
            }
            base.WndProc(ref m);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                {
                    cp.Style |= 0x20000 | 0x80000 | 0x40000; //WS_MINIMIZEBOX | WS_SYSMENU | WS_SIZEBOX;
                }
                return cp;
            }
        }
        #endregion
    }
}
