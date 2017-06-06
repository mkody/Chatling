namespace Chatling {
    partial class fmSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSettings));
            this.mtbxConfUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlblConfUserName = new MaterialSkin.Controls.MaterialLabel();
            this.mckbConfLogsSave = new MaterialSkin.Controls.MaterialCheckBox();
            this.mlblConfUserColor = new MaterialSkin.Controls.MaterialLabel();
            this.mradConfUserColor0 = new MaterialSkin.Controls.MaterialRadioButton();
            this.mradConfUserColor2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.mradConfUserColor3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.mradConfUserColor1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.mradConfUserColor7 = new MaterialSkin.Controls.MaterialRadioButton();
            this.mradConfUserColor5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.mradConfUserColor6 = new MaterialSkin.Controls.MaterialRadioButton();
            this.mradConfUserColor4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblConfUserColorExample = new System.Windows.Forms.Label();
            this.lbConfUser = new System.Windows.Forms.Label();
            this.lblConfLogs = new System.Windows.Forms.Label();
            this.mbtnConfUserNameApply = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // mtbxConfUserName
            // 
            this.mtbxConfUserName.Depth = 0;
            this.mtbxConfUserName.Hint = "Votre pseudo";
            this.mtbxConfUserName.Location = new System.Drawing.Point(87, 98);
            this.mtbxConfUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbxConfUserName.Name = "mtbxConfUserName";
            this.mtbxConfUserName.PasswordChar = '\0';
            this.mtbxConfUserName.SelectedText = "";
            this.mtbxConfUserName.SelectionLength = 0;
            this.mtbxConfUserName.SelectionStart = 0;
            this.mtbxConfUserName.Size = new System.Drawing.Size(263, 23);
            this.mtbxConfUserName.TabIndex = 3;
            this.mtbxConfUserName.UseSystemPasswordChar = false;
            // 
            // mlblConfUserName
            // 
            this.mlblConfUserName.AutoSize = true;
            this.mlblConfUserName.Depth = 0;
            this.mlblConfUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblConfUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblConfUserName.Location = new System.Drawing.Point(14, 98);
            this.mlblConfUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblConfUserName.Name = "mlblConfUserName";
            this.mlblConfUserName.Size = new System.Drawing.Size(67, 19);
            this.mlblConfUserName.TabIndex = 4;
            this.mlblConfUserName.Text = "Pseudo :";
            // 
            // mckbConfLogsSave
            // 
            this.mckbConfLogsSave.AutoSize = true;
            this.mckbConfLogsSave.Depth = 0;
            this.mckbConfLogsSave.Font = new System.Drawing.Font("Roboto", 10F);
            this.mckbConfLogsSave.Location = new System.Drawing.Point(16, 237);
            this.mckbConfLogsSave.Margin = new System.Windows.Forms.Padding(0);
            this.mckbConfLogsSave.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mckbConfLogsSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.mckbConfLogsSave.Name = "mckbConfLogsSave";
            this.mckbConfLogsSave.Ripple = true;
            this.mckbConfLogsSave.Size = new System.Drawing.Size(177, 30);
            this.mckbConfLogsSave.TabIndex = 5;
            this.mckbConfLogsSave.Text = "Sauvegarder en quittant";
            this.mckbConfLogsSave.UseVisualStyleBackColor = true;
            this.mckbConfLogsSave.CheckedChanged += new System.EventHandler(this.mckbConfLogsSave_CheckedChanged);
            // 
            // mlblConfUserColor
            // 
            this.mlblConfUserColor.AutoSize = true;
            this.mlblConfUserColor.Depth = 0;
            this.mlblConfUserColor.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblConfUserColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblConfUserColor.Location = new System.Drawing.Point(12, 128);
            this.mlblConfUserColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblConfUserColor.Name = "mlblConfUserColor";
            this.mlblConfUserColor.Size = new System.Drawing.Size(69, 19);
            this.mlblConfUserColor.TabIndex = 7;
            this.mlblConfUserColor.Text = "Couleur :";
            // 
            // mradConfUserColor0
            // 
            this.mradConfUserColor0.AutoSize = true;
            this.mradConfUserColor0.BackColor = System.Drawing.SystemColors.Control;
            this.mradConfUserColor0.Depth = 0;
            this.mradConfUserColor0.Font = new System.Drawing.Font("Roboto", 10F);
            this.mradConfUserColor0.ForeColor = System.Drawing.Color.Black;
            this.mradConfUserColor0.Location = new System.Drawing.Point(85, 124);
            this.mradConfUserColor0.Margin = new System.Windows.Forms.Padding(0);
            this.mradConfUserColor0.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradConfUserColor0.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradConfUserColor0.Name = "mradConfUserColor0";
            this.mradConfUserColor0.Ripple = true;
            this.mradConfUserColor0.Size = new System.Drawing.Size(55, 30);
            this.mradConfUserColor0.TabIndex = 8;
            this.mradConfUserColor0.Text = "Noir";
            this.mradConfUserColor0.UseVisualStyleBackColor = false;
            this.mradConfUserColor0.Click += new System.EventHandler(this.mradConfUserColorRadio_Click);
            // 
            // mradConfUserColor2
            // 
            this.mradConfUserColor2.AutoSize = true;
            this.mradConfUserColor2.Depth = 0;
            this.mradConfUserColor2.Font = new System.Drawing.Font("Roboto", 10F);
            this.mradConfUserColor2.ForeColor = System.Drawing.Color.Red;
            this.mradConfUserColor2.Location = new System.Drawing.Point(185, 124);
            this.mradConfUserColor2.Margin = new System.Windows.Forms.Padding(0);
            this.mradConfUserColor2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradConfUserColor2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradConfUserColor2.Name = "mradConfUserColor2";
            this.mradConfUserColor2.Ripple = true;
            this.mradConfUserColor2.Size = new System.Drawing.Size(68, 30);
            this.mradConfUserColor2.TabIndex = 9;
            this.mradConfUserColor2.Text = "Rouge";
            this.mradConfUserColor2.UseVisualStyleBackColor = true;
            this.mradConfUserColor2.Click += new System.EventHandler(this.mradConfUserColorRadio_Click);
            // 
            // mradConfUserColor3
            // 
            this.mradConfUserColor3.AutoSize = true;
            this.mradConfUserColor3.Depth = 0;
            this.mradConfUserColor3.Font = new System.Drawing.Font("Roboto", 10F);
            this.mradConfUserColor3.ForeColor = System.Drawing.Color.Purple;
            this.mradConfUserColor3.Location = new System.Drawing.Point(185, 154);
            this.mradConfUserColor3.Margin = new System.Windows.Forms.Padding(0);
            this.mradConfUserColor3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradConfUserColor3.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradConfUserColor3.Name = "mradConfUserColor3";
            this.mradConfUserColor3.Ripple = true;
            this.mradConfUserColor3.Size = new System.Drawing.Size(65, 30);
            this.mradConfUserColor3.TabIndex = 10;
            this.mradConfUserColor3.Text = "Violet";
            this.mradConfUserColor3.UseVisualStyleBackColor = true;
            this.mradConfUserColor3.Click += new System.EventHandler(this.mradConfUserColorRadio_Click);
            // 
            // mradConfUserColor1
            // 
            this.mradConfUserColor1.AutoSize = true;
            this.mradConfUserColor1.Depth = 0;
            this.mradConfUserColor1.Font = new System.Drawing.Font("Roboto", 10F);
            this.mradConfUserColor1.ForeColor = System.Drawing.Color.Green;
            this.mradConfUserColor1.Location = new System.Drawing.Point(85, 154);
            this.mradConfUserColor1.Margin = new System.Windows.Forms.Padding(0);
            this.mradConfUserColor1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradConfUserColor1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradConfUserColor1.Name = "mradConfUserColor1";
            this.mradConfUserColor1.Ripple = true;
            this.mradConfUserColor1.Size = new System.Drawing.Size(55, 30);
            this.mradConfUserColor1.TabIndex = 10;
            this.mradConfUserColor1.Text = "Vert";
            this.mradConfUserColor1.UseVisualStyleBackColor = true;
            this.mradConfUserColor1.Click += new System.EventHandler(this.mradConfUserColorRadio_Click);
            // 
            // mradConfUserColor7
            // 
            this.mradConfUserColor7.AutoSize = true;
            this.mradConfUserColor7.Depth = 0;
            this.mradConfUserColor7.Font = new System.Drawing.Font("Roboto", 10F);
            this.mradConfUserColor7.ForeColor = System.Drawing.Color.Blue;
            this.mradConfUserColor7.Location = new System.Drawing.Point(385, 154);
            this.mradConfUserColor7.Margin = new System.Windows.Forms.Padding(0);
            this.mradConfUserColor7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradConfUserColor7.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradConfUserColor7.Name = "mradConfUserColor7";
            this.mradConfUserColor7.Ripple = true;
            this.mradConfUserColor7.Size = new System.Drawing.Size(56, 30);
            this.mradConfUserColor7.TabIndex = 11;
            this.mradConfUserColor7.Text = "Bleu";
            this.mradConfUserColor7.UseVisualStyleBackColor = true;
            this.mradConfUserColor7.Click += new System.EventHandler(this.mradConfUserColorRadio_Click);
            // 
            // mradConfUserColor5
            // 
            this.mradConfUserColor5.AutoSize = true;
            this.mradConfUserColor5.Depth = 0;
            this.mradConfUserColor5.Font = new System.Drawing.Font("Roboto", 10F);
            this.mradConfUserColor5.ForeColor = System.Drawing.Color.HotPink;
            this.mradConfUserColor5.Location = new System.Drawing.Point(285, 154);
            this.mradConfUserColor5.Margin = new System.Windows.Forms.Padding(0);
            this.mradConfUserColor5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradConfUserColor5.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradConfUserColor5.Name = "mradConfUserColor5";
            this.mradConfUserColor5.Ripple = true;
            this.mradConfUserColor5.Size = new System.Drawing.Size(60, 30);
            this.mradConfUserColor5.TabIndex = 12;
            this.mradConfUserColor5.Text = "Rose";
            this.mradConfUserColor5.UseVisualStyleBackColor = true;
            this.mradConfUserColor5.Click += new System.EventHandler(this.mradConfUserColorRadio_Click);
            // 
            // mradConfUserColor6
            // 
            this.mradConfUserColor6.AutoSize = true;
            this.mradConfUserColor6.Depth = 0;
            this.mradConfUserColor6.Font = new System.Drawing.Font("Roboto", 10F);
            this.mradConfUserColor6.ForeColor = System.Drawing.Color.Navy;
            this.mradConfUserColor6.Location = new System.Drawing.Point(385, 124);
            this.mradConfUserColor6.Margin = new System.Windows.Forms.Padding(0);
            this.mradConfUserColor6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradConfUserColor6.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradConfUserColor6.Name = "mradConfUserColor6";
            this.mradConfUserColor6.Ripple = true;
            this.mradConfUserColor6.Size = new System.Drawing.Size(60, 30);
            this.mradConfUserColor6.TabIndex = 14;
            this.mradConfUserColor6.Text = "Navy";
            this.mradConfUserColor6.UseVisualStyleBackColor = true;
            this.mradConfUserColor6.Click += new System.EventHandler(this.mradConfUserColorRadio_Click);
            // 
            // mradConfUserColor4
            // 
            this.mradConfUserColor4.AutoSize = true;
            this.mradConfUserColor4.Depth = 0;
            this.mradConfUserColor4.Font = new System.Drawing.Font("Roboto", 10F);
            this.mradConfUserColor4.ForeColor = System.Drawing.Color.DarkOrange;
            this.mradConfUserColor4.Location = new System.Drawing.Point(285, 124);
            this.mradConfUserColor4.Margin = new System.Windows.Forms.Padding(0);
            this.mradConfUserColor4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mradConfUserColor4.MouseState = MaterialSkin.MouseState.HOVER;
            this.mradConfUserColor4.Name = "mradConfUserColor4";
            this.mradConfUserColor4.Ripple = true;
            this.mradConfUserColor4.Size = new System.Drawing.Size(73, 30);
            this.mradConfUserColor4.TabIndex = 15;
            this.mradConfUserColor4.Text = "Orange";
            this.mradConfUserColor4.UseVisualStyleBackColor = true;
            this.mradConfUserColor4.Click += new System.EventHandler(this.mradConfUserColorRadio_Click);
            // 
            // lblConfUserColorExample
            // 
            this.lblConfUserColorExample.AutoSize = true;
            this.lblConfUserColorExample.BackColor = System.Drawing.Color.White;
            this.lblConfUserColorExample.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfUserColorExample.Location = new System.Drawing.Point(12, 162);
            this.lblConfUserColorExample.Name = "lblConfUserColorExample";
            this.lblConfUserColorExample.Size = new System.Drawing.Size(68, 15);
            this.lblConfUserColorExample.TabIndex = 17;
            this.lblConfUserColorExample.Text = "(exemple)";
            // 
            // lbConfUser
            // 
            this.lbConfUser.AutoSize = true;
            this.lbConfUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfUser.Location = new System.Drawing.Point(14, 71);
            this.lbConfUser.Name = "lbConfUser";
            this.lbConfUser.Size = new System.Drawing.Size(101, 24);
            this.lbConfUser.TabIndex = 18;
            this.lbConfUser.Text = "Utilisateur";
            // 
            // lblConfLogs
            // 
            this.lblConfLogs.AutoSize = true;
            this.lblConfLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfLogs.Location = new System.Drawing.Point(14, 213);
            this.lblConfLogs.Name = "lblConfLogs";
            this.lblConfLogs.Size = new System.Drawing.Size(55, 24);
            this.lblConfLogs.TabIndex = 19;
            this.lblConfLogs.Text = "Logs";
            // 
            // mbtnConfUserNameApply
            // 
            this.mbtnConfUserNameApply.Depth = 0;
            this.mbtnConfUserNameApply.Location = new System.Drawing.Point(356, 98);
            this.mbtnConfUserNameApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnConfUserNameApply.Name = "mbtnConfUserNameApply";
            this.mbtnConfUserNameApply.Primary = true;
            this.mbtnConfUserNameApply.Size = new System.Drawing.Size(89, 23);
            this.mbtnConfUserNameApply.TabIndex = 20;
            this.mbtnConfUserNameApply.Text = "Appliquer";
            this.mbtnConfUserNameApply.UseVisualStyleBackColor = true;
            this.mbtnConfUserNameApply.Click += new System.EventHandler(this.mbtnConfUserNameApply_Click);
            // 
            // fmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 279);
            this.Controls.Add(this.mbtnConfUserNameApply);
            this.Controls.Add(this.lblConfLogs);
            this.Controls.Add(this.lbConfUser);
            this.Controls.Add(this.lblConfUserColorExample);
            this.Controls.Add(this.mradConfUserColor4);
            this.Controls.Add(this.mradConfUserColor6);
            this.Controls.Add(this.mradConfUserColor5);
            this.Controls.Add(this.mradConfUserColor7);
            this.Controls.Add(this.mradConfUserColor1);
            this.Controls.Add(this.mradConfUserColor3);
            this.Controls.Add(this.mradConfUserColor2);
            this.Controls.Add(this.mradConfUserColor0);
            this.Controls.Add(this.mlblConfUserColor);
            this.Controls.Add(this.mckbConfLogsSave);
            this.Controls.Add(this.mlblConfUserName);
            this.Controls.Add(this.mtbxConfUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSettings";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmSettings_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField mtbxConfUserName;
        private MaterialSkin.Controls.MaterialLabel mlblConfUserName;
        private MaterialSkin.Controls.MaterialCheckBox mckbConfLogsSave;
        private MaterialSkin.Controls.MaterialLabel mlblConfUserColor;
        private MaterialSkin.Controls.MaterialRadioButton mradConfUserColor0;
        private MaterialSkin.Controls.MaterialRadioButton mradConfUserColor2;
        private MaterialSkin.Controls.MaterialRadioButton mradConfUserColor3;
        private MaterialSkin.Controls.MaterialRadioButton mradConfUserColor1;
        private MaterialSkin.Controls.MaterialRadioButton mradConfUserColor7;
        private MaterialSkin.Controls.MaterialRadioButton mradConfUserColor5;
        private MaterialSkin.Controls.MaterialRadioButton mradConfUserColor6;
        private MaterialSkin.Controls.MaterialRadioButton mradConfUserColor4;
        private System.Windows.Forms.Label lblConfUserColorExample;
        private System.Windows.Forms.Label lbConfUser;
        private System.Windows.Forms.Label lblConfLogs;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnConfUserNameApply;
    }
}