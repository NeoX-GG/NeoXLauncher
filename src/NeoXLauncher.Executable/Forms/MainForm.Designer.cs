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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.BigPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.NewsBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ProfileBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.MenuBtn = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).BeginInit();
            this.LogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BigPanel
            // 
            this.BigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BigPanel.Location = new System.Drawing.Point(276, 0);
            this.BigPanel.Name = "BigPanel";
            this.BigPanel.Size = new System.Drawing.Size(1164, 900);
            this.BigPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Controls.Add(this.NewsBtn);
            this.LeftPanel.Controls.Add(this.ProfileBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(276, 900);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.Visible = false;
            // 
            // NewsBtn
            // 
            this.NewsBtn.AllowAnimations = true;
            this.NewsBtn.AllowMouseEffects = true;
            this.NewsBtn.AllowToggling = false;
            this.NewsBtn.AnimationSpeed = 200;
            this.NewsBtn.AutoGenerateColors = false;
            this.NewsBtn.AutoRoundBorders = false;
            this.NewsBtn.AutoSizeLeftIcon = true;
            this.NewsBtn.AutoSizeRightIcon = true;
            this.NewsBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewsBtn.BackColor1 = System.Drawing.Color.Transparent;
            this.NewsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewsBtn.BackgroundImage")));
            this.NewsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.NewsBtn.ButtonText = "News";
            this.NewsBtn.ButtonTextMarginLeft = 0;
            this.NewsBtn.ColorContrastOnClick = 45;
            this.NewsBtn.ColorContrastOnHover = 45;
            this.NewsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.NewsBtn.CustomizableEdges = borderEdges1;
            this.NewsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NewsBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.NewsBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NewsBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.NewsBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.NewsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewsBtn.ForeColor = System.Drawing.Color.Silver;
            this.NewsBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewsBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.NewsBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.NewsBtn.IconMarginLeft = 11;
            this.NewsBtn.IconPadding = 10;
            this.NewsBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewsBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.NewsBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.NewsBtn.IconSize = 25;
            this.NewsBtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.NewsBtn.IdleBorderRadius = 5;
            this.NewsBtn.IdleBorderThickness = 1;
            this.NewsBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.NewsBtn.IdleIconLeftImage = global::NeoXLauncher.Executable.Properties.Resources.Close;
            this.NewsBtn.IdleIconRightImage = null;
            this.NewsBtn.IndicateFocus = false;
            this.NewsBtn.Location = new System.Drawing.Point(-2, 169);
            this.NewsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewsBtn.Name = "NewsBtn";
            this.NewsBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.NewsBtn.OnDisabledState.BorderRadius = 5;
            this.NewsBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NewsBtn.OnDisabledState.BorderThickness = 0;
            this.NewsBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NewsBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.NewsBtn.OnDisabledState.IconLeftImage = null;
            this.NewsBtn.OnDisabledState.IconRightImage = null;
            this.NewsBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.NewsBtn.onHoverState.BorderRadius = 5;
            this.NewsBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NewsBtn.onHoverState.BorderThickness = 0;
            this.NewsBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.NewsBtn.onHoverState.ForeColor = System.Drawing.Color.Silver;
            this.NewsBtn.onHoverState.IconLeftImage = null;
            this.NewsBtn.onHoverState.IconRightImage = null;
            this.NewsBtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.NewsBtn.OnIdleState.BorderRadius = 5;
            this.NewsBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.NewsBtn.OnIdleState.BorderThickness = 0;
            this.NewsBtn.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.NewsBtn.OnIdleState.ForeColor = System.Drawing.Color.Silver;
            this.NewsBtn.OnIdleState.IconLeftImage = global::NeoXLauncher.Executable.Properties.Resources.Close;
            this.NewsBtn.OnIdleState.IconRightImage = null;
            this.NewsBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.NewsBtn.OnPressedState.BorderRadius = 5;
            this.NewsBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.NewsBtn.OnPressedState.BorderThickness = 0;
            this.NewsBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.NewsBtn.OnPressedState.ForeColor = System.Drawing.Color.Silver;
            this.NewsBtn.OnPressedState.IconLeftImage = null;
            this.NewsBtn.OnPressedState.IconRightImage = null;
            this.NewsBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewsBtn.Size = new System.Drawing.Size(276, 65);
            this.NewsBtn.TabIndex = 3;
            this.NewsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewsBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewsBtn.TextMarginLeft = 0;
            this.NewsBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.NewsBtn.UseDefaultRadiusAndThickness = true;
            this.NewsBtn.Click += new System.EventHandler(this.NewsBtn_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.AllowAnimations = true;
            this.ProfileBtn.AllowMouseEffects = true;
            this.ProfileBtn.AllowToggling = false;
            this.ProfileBtn.AnimationSpeed = 200;
            this.ProfileBtn.AutoGenerateColors = false;
            this.ProfileBtn.AutoRoundBorders = false;
            this.ProfileBtn.AutoSizeLeftIcon = true;
            this.ProfileBtn.AutoSizeRightIcon = true;
            this.ProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.BackColor1 = System.Drawing.Color.Transparent;
            this.ProfileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileBtn.BackgroundImage")));
            this.ProfileBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.ProfileBtn.ButtonText = "Profile";
            this.ProfileBtn.ButtonTextMarginLeft = 0;
            this.ProfileBtn.ColorContrastOnClick = 45;
            this.ProfileBtn.ColorContrastOnHover = 45;
            this.ProfileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.ProfileBtn.CustomizableEdges = borderEdges2;
            this.ProfileBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProfileBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ProfileBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ProfileBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ProfileBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.ProfileBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProfileBtn.ForeColor = System.Drawing.Color.Silver;
            this.ProfileBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ProfileBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ProfileBtn.IconMarginLeft = 11;
            this.ProfileBtn.IconPadding = 10;
            this.ProfileBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProfileBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ProfileBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ProfileBtn.IconSize = 25;
            this.ProfileBtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.IdleBorderRadius = 5;
            this.ProfileBtn.IdleBorderThickness = 1;
            this.ProfileBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.IdleIconLeftImage = global::NeoXLauncher.Executable.Properties.Resources.Close;
            this.ProfileBtn.IdleIconRightImage = null;
            this.ProfileBtn.IndicateFocus = false;
            this.ProfileBtn.Location = new System.Drawing.Point(-1, 104);
            this.ProfileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ProfileBtn.OnDisabledState.BorderRadius = 5;
            this.ProfileBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ProfileBtn.OnDisabledState.BorderThickness = 0;
            this.ProfileBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ProfileBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ProfileBtn.OnDisabledState.IconLeftImage = null;
            this.ProfileBtn.OnDisabledState.IconRightImage = null;
            this.ProfileBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.ProfileBtn.onHoverState.BorderRadius = 5;
            this.ProfileBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ProfileBtn.onHoverState.BorderThickness = 0;
            this.ProfileBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.ProfileBtn.onHoverState.ForeColor = System.Drawing.Color.Silver;
            this.ProfileBtn.onHoverState.IconLeftImage = null;
            this.ProfileBtn.onHoverState.IconRightImage = null;
            this.ProfileBtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.OnIdleState.BorderRadius = 5;
            this.ProfileBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.ProfileBtn.OnIdleState.BorderThickness = 0;
            this.ProfileBtn.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.OnIdleState.ForeColor = System.Drawing.Color.Silver;
            this.ProfileBtn.OnIdleState.IconLeftImage = global::NeoXLauncher.Executable.Properties.Resources.Close;
            this.ProfileBtn.OnIdleState.IconRightImage = null;
            this.ProfileBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.ProfileBtn.OnPressedState.BorderRadius = 5;
            this.ProfileBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ProfileBtn.OnPressedState.BorderThickness = 0;
            this.ProfileBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.ProfileBtn.OnPressedState.ForeColor = System.Drawing.Color.Silver;
            this.ProfileBtn.OnPressedState.IconLeftImage = null;
            this.ProfileBtn.OnPressedState.IconRightImage = null;
            this.ProfileBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProfileBtn.Size = new System.Drawing.Size(276, 65);
            this.ProfileBtn.TabIndex = 2;
            this.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProfileBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProfileBtn.TextMarginLeft = 0;
            this.ProfileBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.ProfileBtn.UseDefaultRadiusAndThickness = true;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.CloseBtn);
            this.TopPanel.Controls.Add(this.MenuBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(276, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1164, 106);
            this.TopPanel.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImage = global::NeoXLauncher.Executable.Properties.Resources.Close;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBtn.Location = new System.Drawing.Point(1129, 11);
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
            this.MenuBtn.Location = new System.Drawing.Point(16, 11);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(55, 50);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.TabStop = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 91);
            this.label1.TabIndex = 4;
            this.label1.Text = "NeoX";
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(275, 105);
            this.LogoPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BigPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeoX";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).EndInit();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BigPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.PictureBox MenuBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox CloseBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ProfileBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton NewsBtn;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label label1;
    }
}