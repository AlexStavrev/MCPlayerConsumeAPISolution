using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerViewer.CustomControls
{
    public partial class NotificationLabelBar : UserControl
    {
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text { get => lblMessage.Text; set => lblMessage.Text = value; }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("The ForeColor of the close button")]
        public Color ButtonColor {
            get => btnHideNotification.ForeColor;
            set 
            {
                btnHideNotification.ForeColor = value;
                Invalidate();
            }
        }

        public NotificationLabelBar()
        {
            InitializeComponent();
            Visible = false;
        }

        public async Task ShowNotificationAsync(int milis = 1000)
        {
            Visible = true;
            await Task.Delay(milis);
            HideNotification();
        }
        

        public void HideNotification()
        {
            Visible = false;
        }

        private void btnHideNotification_Click(object sender, System.EventArgs e) => HideNotification();
    }
}
