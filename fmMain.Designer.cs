namespace Chatling
{
    partial class fmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.sfdLogs = new System.Windows.Forms.SaveFileDialog();
            this.lblLeftChars = new System.Windows.Forms.Label();
            this.timCheck = new System.Windows.Forms.Timer(this.components);
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.timPing = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.welcomeCard = new System.Windows.Forms.PictureBox();
            this.timFade = new System.Windows.Forms.Timer(this.components);
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.tbxInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlblConnected = new MaterialSkin.Controls.MaterialLabel();
            this.lbtnSettings = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeCard)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Connecté";
            this.notifyIcon.BalloonTipTitle = "Chatling  αlpha";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Chatling  αlpha";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // sfdLogs
            // 
            this.sfdLogs.DefaultExt = "log";
            this.sfdLogs.FileName = "Chatling";
            this.sfdLogs.Filter = "Fichiers de log|*.log";
            this.sfdLogs.Title = "Sauvegarder les logs";
            this.sfdLogs.ValidateNames = false;
            // 
            // lblLeftChars
            // 
            this.lblLeftChars.AutoSize = true;
            this.lblLeftChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftChars.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLeftChars.Location = new System.Drawing.Point(520, 394);
            this.lblLeftChars.Name = "lblLeftChars";
            this.lblLeftChars.Size = new System.Drawing.Size(25, 13);
            this.lblLeftChars.TabIndex = 6;
            this.lblLeftChars.Text = "140";
            this.lblLeftChars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timCheck
            // 
            this.timCheck.Enabled = true;
            this.timCheck.Tick += new System.EventHandler(this.timCheck_Tick);
            // 
            // lbUsers
            // 
            this.lbUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUsers.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 17;
            this.lbUsers.Location = new System.Drawing.Point(552, 104);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbUsers.Size = new System.Drawing.Size(98, 272);
            this.lbUsers.Sorted = true;
            this.lbUsers.TabIndex = 7;
            // 
            // timPing
            // 
            this.timPing.Enabled = true;
            this.timPing.Interval = 40000;
            this.timPing.Tick += new System.EventHandler(this.timPing_Tick);
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(593, 34);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(57, 23);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // welcomeCard
            // 
            this.welcomeCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.welcomeCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.welcomeCard.Image = ((System.Drawing.Image)(resources.GetObject("welcomeCard.Image")));
            this.welcomeCard.InitialImage = null;
            this.welcomeCard.Location = new System.Drawing.Point(0, 420);
            this.welcomeCard.MaximumSize = new System.Drawing.Size(666, 360);
            this.welcomeCard.Name = "welcomeCard";
            this.welcomeCard.Size = new System.Drawing.Size(666, 360);
            this.welcomeCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.welcomeCard.TabIndex = 9;
            this.welcomeCard.TabStop = false;
            this.welcomeCard.Click += new System.EventHandler(this.welcomeCard_Click);
            // 
            // timFade
            // 
            this.timFade.Enabled = true;
            this.timFade.Interval = 10;
            this.timFade.Tick += new System.EventHandler(this.timFade_Tick);
            // 
            // rtbLogs
            // 
            this.rtbLogs.BackColor = System.Drawing.Color.White;
            this.rtbLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogs.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLogs.Location = new System.Drawing.Point(12, 78);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.ReadOnly = true;
            this.rtbLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbLogs.Size = new System.Drawing.Size(533, 298);
            this.rtbLogs.TabIndex = 10;
            this.rtbLogs.Text = "";
            this.rtbLogs.TextChanged += new System.EventHandler(this.rtbLogs_TextChanged);
            // 
            // tbxInput
            // 
            this.tbxInput.Depth = 0;
            this.tbxInput.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Hint = "Chat ici !";
            this.tbxInput.Location = new System.Drawing.Point(12, 389);
            this.tbxInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.PasswordChar = '\0';
            this.tbxInput.SelectedText = "";
            this.tbxInput.SelectionLength = 0;
            this.tbxInput.SelectionStart = 0;
            this.tbxInput.Size = new System.Drawing.Size(502, 23);
            this.tbxInput.TabIndex = 11;
            this.tbxInput.UseSystemPasswordChar = false;
            this.tbxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            this.tbxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyUp);
            // 
            // mlblConnected
            // 
            this.mlblConnected.AutoSize = true;
            this.mlblConnected.Depth = 0;
            this.mlblConnected.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblConnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblConnected.Location = new System.Drawing.Point(548, 78);
            this.mlblConnected.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblConnected.Name = "mlblConnected";
            this.mlblConnected.Size = new System.Drawing.Size(81, 19);
            this.mlblConnected.TabIndex = 13;
            this.mlblConnected.Text = "Connectés";
            // 
            // lbtnSettings
            // 
            this.lbtnSettings.Depth = 0;
            this.lbtnSettings.Location = new System.Drawing.Point(552, 390);
            this.lbtnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbtnSettings.Name = "lbtnSettings";
            this.lbtnSettings.Primary = true;
            this.lbtnSettings.Size = new System.Drawing.Size(98, 23);
            this.lbtnSettings.TabIndex = 14;
            this.lbtnSettings.Text = "Config";
            this.lbtnSettings.UseVisualStyleBackColor = true;
            this.lbtnSettings.Click += new System.EventHandler(this.lbtnSettings_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 424);
            this.Controls.Add(this.welcomeCard);
            this.Controls.Add(this.rtbLogs);
            this.Controls.Add(this.lbtnSettings);
            this.Controls.Add(this.mlblConnected);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.lblLeftChars);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(666, 424);
            this.MinimumSize = new System.Drawing.Size(666, 424);
            this.Name = "fmMain";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Chatling βήτα";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmGroupChat_Load);
            this.Resize += new System.EventHandler(this.fmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.welcomeCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.SaveFileDialog sfdLogs;
        private System.Windows.Forms.Label lblLeftChars;
        private System.Windows.Forms.Timer timCheck;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Timer timPing;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.Timer timFade;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbxInput;
        private System.Windows.Forms.PictureBox welcomeCard;
        private MaterialSkin.Controls.MaterialLabel mlblConnected;
        private MaterialSkin.Controls.MaterialRaisedButton lbtnSettings;
    }
}

