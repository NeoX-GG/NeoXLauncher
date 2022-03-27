namespace NeoXLauncher.Executable.Forms.Subforms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.SavePicBox = new System.Windows.Forms.PictureBox();
            this.AccountTxtBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.ProfilePicBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SavePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SavePicBox
            // 
            this.SavePicBox.BackgroundImage = global::NeoXLauncher.Executable.Properties.Resources.Save;
            this.SavePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SavePicBox.Location = new System.Drawing.Point(1329, 12);
            this.SavePicBox.Name = "SavePicBox";
            this.SavePicBox.Size = new System.Drawing.Size(99, 104);
            this.SavePicBox.TabIndex = 4;
            this.SavePicBox.TabStop = false;
            // 
            // AccountTxtBox
            // 
            this.AccountTxtBox.AcceptsReturn = false;
            this.AccountTxtBox.AcceptsTab = false;
            this.AccountTxtBox.AnimationSpeed = 200;
            this.AccountTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AccountTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AccountTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.AccountTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AccountTxtBox.BackgroundImage")));
            this.AccountTxtBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.AccountTxtBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AccountTxtBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AccountTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.AccountTxtBox.BorderRadius = 1;
            this.AccountTxtBox.BorderThickness = 1;
            this.AccountTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AccountTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccountTxtBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.AccountTxtBox.DefaultText = "";
            this.AccountTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.AccountTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.AccountTxtBox.HideSelection = true;
            this.AccountTxtBox.IconLeft = null;
            this.AccountTxtBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.AccountTxtBox.IconPadding = 10;
            this.AccountTxtBox.IconRight = null;
            this.AccountTxtBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.AccountTxtBox.Lines = new string[0];
            this.AccountTxtBox.Location = new System.Drawing.Point(314, 222);
            this.AccountTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountTxtBox.MaxLength = 32767;
            this.AccountTxtBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.AccountTxtBox.Modified = false;
            this.AccountTxtBox.Multiline = false;
            this.AccountTxtBox.Name = "AccountTxtBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AccountTxtBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.AccountTxtBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AccountTxtBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AccountTxtBox.OnIdleState = stateProperties4;
            this.AccountTxtBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountTxtBox.PasswordChar = '\0';
            this.AccountTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.AccountTxtBox.PlaceholderText = "Account name\r\n";
            this.AccountTxtBox.ReadOnly = false;
            this.AccountTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AccountTxtBox.SelectedText = "";
            this.AccountTxtBox.SelectionLength = 0;
            this.AccountTxtBox.SelectionStart = 0;
            this.AccountTxtBox.ShortcutsEnabled = true;
            this.AccountTxtBox.Size = new System.Drawing.Size(189, 41);
            this.AccountTxtBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.AccountTxtBox.TabIndex = 3;
            this.AccountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AccountTxtBox.TextMarginBottom = 0;
            this.AccountTxtBox.TextMarginLeft = 3;
            this.AccountTxtBox.TextMarginTop = 0;
            this.AccountTxtBox.TextPlaceholder = "Account name\r\n";
            this.AccountTxtBox.UseSystemPasswordChar = false;
            this.AccountTxtBox.WordWrap = true;
            // 
            // ProfilePicBox
            // 
            this.ProfilePicBox.AllowFocused = false;
            this.ProfilePicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProfilePicBox.AutoSizeHeight = true;
            this.ProfilePicBox.BorderRadius = 121;
            this.ProfilePicBox.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicBox.Image")));
            this.ProfilePicBox.IsCircle = true;
            this.ProfilePicBox.Location = new System.Drawing.Point(25, 21);
            this.ProfilePicBox.Name = "ProfilePicBox";
            this.ProfilePicBox.Size = new System.Drawing.Size(242, 242);
            this.ProfilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicBox.TabIndex = 0;
            this.ProfilePicBox.TabStop = false;
            this.ProfilePicBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1440, 794);
            this.Controls.Add(this.SavePicBox);
            this.Controls.Add(this.AccountTxtBox);
            this.Controls.Add(this.ProfilePicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.SavePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox ProfilePicBox;
        private Bunifu.UI.WinForms.BunifuTextBox AccountTxtBox;
        private System.Windows.Forms.PictureBox SavePicBox;
    }
}