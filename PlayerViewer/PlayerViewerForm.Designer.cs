
namespace PlayerViewer
{
    partial class PlayerViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerViewerForm));
            this.imagePlayerSkin = new System.Windows.Forms.PictureBox();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelPlayerInfo = new System.Windows.Forms.Panel();
            this.panelNames = new System.Windows.Forms.Panel();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.lblNames = new System.Windows.Forms.Label();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.lblUUIDValue = new System.Windows.Forms.Label();
            this.lblUUIDTitle = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imageAppIcon = new System.Windows.Forms.PictureBox();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.btnMaximise = new System.Windows.Forms.Button();
            this.btnDispose = new System.Windows.Forms.Button();
            this.tooltipDownload = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileSkinDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlayerSkin)).BeginInit();
            this.panelPicture.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelPlayerInfo.SuspendLayout();
            this.panelNames.SuspendLayout();
            this.panelInformation.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePlayerSkin
            // 
            this.imagePlayerSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePlayerSkin.Location = new System.Drawing.Point(10, 20);
            this.imagePlayerSkin.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.imagePlayerSkin.Name = "imagePlayerSkin";
            this.imagePlayerSkin.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.imagePlayerSkin.Size = new System.Drawing.Size(269, 397);
            this.imagePlayerSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePlayerSkin.TabIndex = 0;
            this.imagePlayerSkin.TabStop = false;
            // 
            // panelPicture
            // 
            this.panelPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panelPicture.Controls.Add(this.btnDownload);
            this.panelPicture.Controls.Add(this.imagePlayerSkin);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPicture.Location = new System.Drawing.Point(20, 20);
            this.panelPicture.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.panelPicture.Size = new System.Drawing.Size(289, 437);
            this.panelPicture.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnDownload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDownload.Location = new System.Drawing.Point(10, 377);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(0);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnDownload.Size = new System.Drawing.Size(269, 40);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.TabStop = false;
            this.btnDownload.Text = "⇩";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Controls.Add(this.panelPicture);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(884, 477);
            this.panelMain.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelPlayerInfo);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(309, 20);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelRight.Size = new System.Drawing.Size(555, 437);
            this.panelRight.TabIndex = 3;
            // 
            // panelPlayerInfo
            // 
            this.panelPlayerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panelPlayerInfo.Controls.Add(this.panelNames);
            this.panelPlayerInfo.Controls.Add(this.panelInformation);
            this.panelPlayerInfo.Controls.Add(this.panelSearch);
            this.panelPlayerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlayerInfo.Location = new System.Drawing.Point(20, 0);
            this.panelPlayerInfo.Name = "panelPlayerInfo";
            this.panelPlayerInfo.Padding = new System.Windows.Forms.Padding(20);
            this.panelPlayerInfo.Size = new System.Drawing.Size(535, 437);
            this.panelPlayerInfo.TabIndex = 3;
            // 
            // panelNames
            // 
            this.panelNames.Controls.Add(this.listBoxNames);
            this.panelNames.Controls.Add(this.lblNames);
            this.panelNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNames.Location = new System.Drawing.Point(20, 219);
            this.panelNames.Name = "panelNames";
            this.panelNames.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelNames.Size = new System.Drawing.Size(495, 198);
            this.panelNames.TabIndex = 9;
            // 
            // listBoxNames
            // 
            this.listBoxNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.listBoxNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNames.ColumnWidth = 100;
            this.listBoxNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 31;
            this.listBoxNames.Location = new System.Drawing.Point(0, 42);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(495, 156);
            this.listBoxNames.TabIndex = 1;
            this.listBoxNames.TabStop = false;
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNames.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNames.Location = new System.Drawing.Point(0, 10);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(92, 32);
            this.lblNames.TabIndex = 6;
            this.lblNames.Text = "Names";
            // 
            // panelInformation
            // 
            this.panelInformation.Controls.Add(this.lblUUIDValue);
            this.panelInformation.Controls.Add(this.lblUUIDTitle);
            this.panelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInformation.Location = new System.Drawing.Point(20, 113);
            this.panelInformation.Margin = new System.Windows.Forms.Padding(0);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelInformation.Size = new System.Drawing.Size(495, 106);
            this.panelInformation.TabIndex = 8;
            // 
            // lblUUIDValue
            // 
            this.lblUUIDValue.AutoSize = true;
            this.lblUUIDValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUUIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblUUIDValue.Location = new System.Drawing.Point(0, 42);
            this.lblUUIDValue.Name = "lblUUIDValue";
            this.lblUUIDValue.Size = new System.Drawing.Size(470, 32);
            this.lblUUIDValue.TabIndex = 4;
            this.lblUUIDValue.Text = "00000000-0000-0000-0000-000000000000";
            // 
            // lblUUIDTitle
            // 
            this.lblUUIDTitle.AutoSize = true;
            this.lblUUIDTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUUIDTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUUIDTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblUUIDTitle.Location = new System.Drawing.Point(0, 10);
            this.lblUUIDTitle.Name = "lblUUIDTitle";
            this.lblUUIDTitle.Size = new System.Drawing.Size(74, 32);
            this.lblUUIDTitle.TabIndex = 5;
            this.lblUUIDTitle.Text = "UUID";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtName);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(20, 20);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelSearch.Size = new System.Drawing.Size(495, 93);
            this.panelSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSearch.Location = new System.Drawing.Point(0, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.Location = new System.Drawing.Point(0, 0);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = " Name...";
            this.txtName.Size = new System.Drawing.Size(495, 39);
            this.txtName.TabIndex = 0;
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panelNavBar.Controls.Add(this.lblTitle);
            this.panelNavBar.Controls.Add(this.imageAppIcon);
            this.panelNavBar.Controls.Add(this.btnMinimise);
            this.panelNavBar.Controls.Add(this.btnMaximise);
            this.panelNavBar.Controls.Add(this.btnDispose);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelNavBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(884, 40);
            this.panelNavBar.TabIndex = 3;
            this.panelNavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(39, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // imageAppIcon
            // 
            this.imageAppIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageAppIcon.Image = global::PlayerViewer.Properties.Resources.icon;
            this.imageAppIcon.Location = new System.Drawing.Point(0, 0);
            this.imageAppIcon.Margin = new System.Windows.Forms.Padding(5);
            this.imageAppIcon.Name = "imageAppIcon";
            this.imageAppIcon.Padding = new System.Windows.Forms.Padding(5);
            this.imageAppIcon.Size = new System.Drawing.Size(41, 40);
            this.imageAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAppIcon.TabIndex = 4;
            this.imageAppIcon.TabStop = false;
            this.imageAppIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // btnMinimise
            // 
            this.btnMinimise.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimise.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMinimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Location = new System.Drawing.Point(734, 0);
            this.btnMinimise.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.btnMinimise.Size = new System.Drawing.Size(50, 40);
            this.btnMinimise.TabIndex = 1;
            this.btnMinimise.TabStop = false;
            this.btnMinimise.Text = "🗕";
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // btnMaximise
            // 
            this.btnMaximise.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximise.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMaximise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximise.Location = new System.Drawing.Point(784, 0);
            this.btnMaximise.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnMaximise.Size = new System.Drawing.Size(50, 40);
            this.btnMaximise.TabIndex = 1;
            this.btnMaximise.TabStop = false;
            this.btnMaximise.Text = "🗗";
            this.btnMaximise.UseVisualStyleBackColor = false;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            // 
            // btnDispose
            // 
            this.btnDispose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDispose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnDispose.FlatAppearance.BorderSize = 0;
            this.btnDispose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnDispose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btnDispose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispose.Location = new System.Drawing.Point(834, 0);
            this.btnDispose.Margin = new System.Windows.Forms.Padding(0);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnDispose.Size = new System.Drawing.Size(50, 40);
            this.btnDispose.TabIndex = 1;
            this.btnDispose.TabStop = false;
            this.btnDispose.Text = "✕";
            this.btnDispose.UseVisualStyleBackColor = false;
            this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click);
            // 
            // tooltipDownload
            // 
            this.tooltipDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.tooltipDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tooltipDownload.OwnerDraw = true;
            this.tooltipDownload.ToolTipTitle = "Download";
            this.tooltipDownload.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.tooltipDownload_Draw);
            // 
            // saveFileSkinDialog
            // 
            this.saveFileSkinDialog.DefaultExt = "png";
            this.saveFileSkinDialog.Filter = "\"Player Skins|*.png\"";
            this.saveFileSkinDialog.RestoreDirectory = true;
            this.saveFileSkinDialog.SupportMultiDottedExtensions = true;
            this.saveFileSkinDialog.Title = "Save Skin";
            // 
            // PlayerViewerForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(884, 517);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNavBar);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(860, 420);
            this.Name = "PlayerViewerForm";
            this.Text = "Player Viewer";
            this.Load += new System.EventHandler(this.PlayerViewerForm_Load);
            this.Resize += new System.EventHandler(this.PlayerViewerForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imagePlayerSkin)).EndInit();
            this.panelPicture.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelPlayerInfo.ResumeLayout(false);
            this.panelNames.ResumeLayout(false);
            this.panelNames.PerformLayout();
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAppIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePlayerSkin;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button btnDispose;
        private System.Windows.Forms.Button btnMaximise;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imageAppIcon;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panelPlayerInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblUUIDValue;
        private System.Windows.Forms.Label lblUUIDTitle;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Panel panelNames;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ToolTip tooltipDownload;
        private System.Windows.Forms.SaveFileDialog saveFileSkinDialog;
        private System.Windows.Forms.Label lblNames;
    }
}

