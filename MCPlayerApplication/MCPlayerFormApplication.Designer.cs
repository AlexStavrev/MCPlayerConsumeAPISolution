
namespace MCPlayerApplication
{
    partial class MCPlayerFormApplication
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
            this.picturePlayerBodyImage = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitleUUID = new System.Windows.Forms.Label();
            this.lblUUID = new System.Windows.Forms.Label();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblTitleNames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerBodyImage)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturePlayerBodyImage
            // 
            this.picturePlayerBodyImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.picturePlayerBodyImage.Location = new System.Drawing.Point(0, 0);
            this.picturePlayerBodyImage.Margin = new System.Windows.Forms.Padding(49, 42, 49, 42);
            this.picturePlayerBodyImage.Name = "picturePlayerBodyImage";
            this.picturePlayerBodyImage.Padding = new System.Windows.Forms.Padding(32, 28, 32, 28);
            this.picturePlayerBodyImage.Size = new System.Drawing.Size(305, 557);
            this.picturePlayerBodyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePlayerBodyImage.TabIndex = 0;
            this.picturePlayerBodyImage.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Location = new System.Drawing.Point(0, 0);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Name...";
            this.txtName.Size = new System.Drawing.Size(802, 35);
            this.txtName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(649, 35);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(153, 44);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Search";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitleUUID
            // 
            this.lblTitleUUID.AutoSize = true;
            this.lblTitleUUID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleUUID.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleUUID.Location = new System.Drawing.Point(305, 79);
            this.lblTitleUUID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitleUUID.Name = "lblTitleUUID";
            this.lblTitleUUID.Size = new System.Drawing.Size(74, 29);
            this.lblTitleUUID.TabIndex = 3;
            this.lblTitleUUID.Text = "UUID";
            // 
            // lblUUID
            // 
            this.lblUUID.AutoSize = true;
            this.lblUUID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUUID.Location = new System.Drawing.Point(305, 108);
            this.lblUUID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUUID.Name = "lblUUID";
            this.lblUUID.Size = new System.Drawing.Size(497, 29);
            this.lblUUID.TabIndex = 4;
            this.lblUUID.Text = "00000000-0000-0000-0000-000000000000";
            // 
            // listBoxNames
            // 
            this.listBoxNames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 28;
            this.listBoxNames.Location = new System.Drawing.Point(305, 273);
            this.listBoxNames.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(802, 284);
            this.listBoxNames.TabIndex = 5;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnSubmit);
            this.panelSearch.Controls.Add(this.txtName);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(305, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(802, 79);
            this.panelSearch.TabIndex = 7;
            // 
            // lblTitleNames
            // 
            this.lblTitleNames.AutoSize = true;
            this.lblTitleNames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitleNames.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleNames.Location = new System.Drawing.Point(305, 244);
            this.lblTitleNames.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitleNames.Name = "lblTitleNames";
            this.lblTitleNames.Size = new System.Drawing.Size(162, 29);
            this.lblTitleNames.TabIndex = 8;
            this.lblTitleNames.Text = "Name History";
            // 
            // MCPlayerFormApplication
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 557);
            this.Controls.Add(this.lblTitleNames);
            this.Controls.Add(this.lblUUID);
            this.Controls.Add(this.lblTitleUUID);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.listBoxNames);
            this.Controls.Add(this.picturePlayerBodyImage);
            this.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MCPlayerFormApplication";
            this.Text = "Player Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerBodyImage)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePlayerBodyImage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitleUUID;
        private System.Windows.Forms.Label lblUUID;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblTitleNames;
    }
}

