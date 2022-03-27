namespace NeoXLauncher.Executable.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.BigPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.MenuBtn = new System.Windows.Forms.PictureBox();
            this.SignUpBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // BigPanel
            // 
            this.BigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BigPanel.Location = new System.Drawing.Point(276, 106);
            this.BigPanel.Name = "BigPanel";
            this.BigPanel.Size = new System.Drawing.Size(1164, 794);
            this.BigPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftPanel.Controls.Add(this.SignUpBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 106);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(276, 794);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.Visible = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.CloseBtn);
            this.TopPanel.Controls.Add(this.MenuBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1440, 106);
            this.TopPanel.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImage = global::NeoXLauncher.Executable.Properties.Resources.Close;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBtn.Location = new System.Drawing.Point(1406, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(22, 25);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackgroundImage = global::NeoXLauncher.Executable.Properties.Resources.SlideMenu;
            this.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuBtn.InitialImage = null;
            this.MenuBtn.Location = new System.Drawing.Point(13, 25);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(55, 50);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.TabStop = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AllowAnimations = true;
            this.SignUpBtn.AllowMouseEffects = true;
            this.SignUpBtn.AllowToggling = false;
            this.SignUpBtn.AnimationSpeed = 200;
            this.SignUpBtn.AutoGenerateColors = false;
            this.SignUpBtn.AutoRoundBorders = false;
            this.SignUpBtn.AutoSizeLeftIcon = true;
            this.SignUpBtn.AutoSizeRightIcon = true;
            this.SignUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.BackColor1 = System.Drawing.Color.Transparent;
            this.SignUpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpBtn.BackgroundImage")));
            this.SignUpBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.SignUpBtn.ButtonText = "Profile";
            this.SignUpBtn.ButtonTextMarginLeft = 0;
            this.SignUpBtn.ColorContrastOnClick = 45;
            this.SignUpBtn.ColorContrastOnHover = 45;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.SignUpBtn.CustomizableEdges = borderEdges1;
            this.SignUpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignUpBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.SignUpBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUpBtn.ForeColor = System.Drawing.Color.Silver;
            this.SignUpBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUpBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SignUpBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SignUpBtn.IconMarginLeft = 11;
            this.SignUpBtn.IconPadding = 10;
            this.SignUpBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignUpBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SignUpBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SignUpBtn.IconSize = 25;
            this.SignUpBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SignUpBtn.IdleBorderRadius = 5;
            this.SignUpBtn.IdleBorderThickness = 1;
            this.SignUpBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.IdleIconLeftImage = global::NeoXLauncher.Executable.Properties.Resources.Close;
            this.SignUpBtn.IdleIconRightImage = null;
            this.SignUpBtn.IndicateFocus = false;
            this.SignUpBtn.Location = new System.Drawing.Point(0, 0);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpBtn.OnDisabledState.BorderRadius = 5;
            this.SignUpBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpBtn.OnDisabledState.BorderThickness = 0;
            this.SignUpBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpBtn.OnDisabledState.IconLeftImage = null;
            this.SignUpBtn.OnDisabledState.IconRightImage = null;
            this.SignUpBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.SignUpBtn.onHoverState.BorderRadius = 5;
            this.SignUpBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpBtn.onHoverState.BorderThickness = 0;
            this.SignUpBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.SignUpBtn.onHoverState.ForeColor = System.Drawing.Color.Silver;
            this.SignUpBtn.onHoverState.IconLeftImage = null;
            this.SignUpBtn.onHoverState.IconRightImage = null;
            this.SignUpBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SignUpBtn.OnIdleState.BorderRadius = 5;
            this.SignUpBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.SignUpBtn.OnIdleState.BorderThickness = 0;
            this.SignUpBtn.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.OnIdleState.ForeColor = System.Drawing.Color.Silver;
            this.SignUpBtn.OnIdleState.IconLeftImage = global::NeoXLauncher.Executable.Properties.Resources.Close;
            this.SignUpBtn.OnIdleState.IconRightImage = null;
            this.SignUpBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.SignUpBtn.OnPressedState.BorderRadius = 5;
            this.SignUpBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpBtn.OnPressedState.BorderThickness = 0;
            this.SignUpBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.SignUpBtn.OnPressedState.ForeColor = System.Drawing.Color.Silver;
            this.SignUpBtn.OnPressedState.IconLeftImage = null;
            this.SignUpBtn.OnPressedState.IconRightImage = null;
            this.SignUpBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SignUpBtn.Size = new System.Drawing.Size(276, 65);
            this.SignUpBtn.TabIndex = 2;
            this.SignUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUpBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUpBtn.TextMarginLeft = 0;
            this.SignUpBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.SignUpBtn.UseDefaultRadiusAndThickness = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.BigPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeoX";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BigPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.PictureBox MenuBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox CloseBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SignUpBtn;
    }
}