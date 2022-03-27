namespace NeoXLauncher.Executable.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.RememberCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.LoginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PswTxtBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.AccountTxtBox = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.label2.Location = new System.Drawing.Point(65, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 96);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(32, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Remember me";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.Silver;
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(147, 242);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 16);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot your password?";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImage = global::NeoXLauncher.Executable.Properties.Resources.Close;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBtn.Location = new System.Drawing.Point(766, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(22, 25);
            this.CloseBtn.TabIndex = 16;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RememberCheckBox
            // 
            this.RememberCheckBox.AllowBindingControlAnimation = true;
            this.RememberCheckBox.AllowBindingControlColorChanges = false;
            this.RememberCheckBox.AllowBindingControlLocation = true;
            this.RememberCheckBox.AllowCheckBoxAnimation = false;
            this.RememberCheckBox.AllowCheckmarkAnimation = true;
            this.RememberCheckBox.AllowOnHoverStates = true;
            this.RememberCheckBox.AutoCheck = true;
            this.RememberCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.RememberCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RememberCheckBox.BackgroundImage")));
            this.RememberCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RememberCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.RememberCheckBox.BorderRadius = 12;
            this.RememberCheckBox.Checked = false;
            this.RememberCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.RememberCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.RememberCheckBox.CustomCheckmarkImage = null;
            this.RememberCheckBox.Location = new System.Drawing.Point(5, 295);
            this.RememberCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RememberCheckBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.RememberCheckBox.Name = "RememberCheckBox";
            this.RememberCheckBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.RememberCheckBox.OnCheck.BorderRadius = 12;
            this.RememberCheckBox.OnCheck.BorderThickness = 2;
            this.RememberCheckBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.RememberCheckBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.RememberCheckBox.OnCheck.CheckmarkThickness = 2;
            this.RememberCheckBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.RememberCheckBox.OnDisable.BorderRadius = 12;
            this.RememberCheckBox.OnDisable.BorderThickness = 2;
            this.RememberCheckBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.RememberCheckBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.RememberCheckBox.OnDisable.CheckmarkThickness = 2;
            this.RememberCheckBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.RememberCheckBox.OnHoverChecked.BorderRadius = 12;
            this.RememberCheckBox.OnHoverChecked.BorderThickness = 2;
            this.RememberCheckBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.RememberCheckBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.RememberCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            this.RememberCheckBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.RememberCheckBox.OnHoverUnchecked.BorderRadius = 12;
            this.RememberCheckBox.OnHoverUnchecked.BorderThickness = 1;
            this.RememberCheckBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.RememberCheckBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.RememberCheckBox.OnUncheck.BorderRadius = 12;
            this.RememberCheckBox.OnUncheck.BorderThickness = 1;
            this.RememberCheckBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.RememberCheckBox.Size = new System.Drawing.Size(21, 21);
            this.RememberCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Round;
            this.RememberCheckBox.TabIndex = 13;
            this.RememberCheckBox.ThreeState = false;
            this.RememberCheckBox.ToolTipText = null;
            // 
            // LoginBtn
            // 
            this.LoginBtn.AllowAnimations = true;
            this.LoginBtn.AllowMouseEffects = true;
            this.LoginBtn.AllowToggling = false;
            this.LoginBtn.AnimationSpeed = 200;
            this.LoginBtn.AutoGenerateColors = false;
            this.LoginBtn.AutoRoundBorders = false;
            this.LoginBtn.AutoSizeLeftIcon = true;
            this.LoginBtn.AutoSizeRightIcon = true;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BackColor1 = System.Drawing.Color.Transparent;
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.LoginBtn.ButtonText = "Login";
            this.LoginBtn.ButtonTextMarginLeft = 0;
            this.LoginBtn.ColorContrastOnClick = 45;
            this.LoginBtn.ColorContrastOnHover = 45;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.LoginBtn.CustomizableEdges = borderEdges2;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoginBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoginBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginBtn.ForeColor = System.Drawing.Color.Silver;
            this.LoginBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoginBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LoginBtn.IconMarginLeft = 11;
            this.LoginBtn.IconPadding = 10;
            this.LoginBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoginBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LoginBtn.IconSize = 25;
            this.LoginBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.IdleBorderRadius = 5;
            this.LoginBtn.IdleBorderThickness = 1;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.LoginBtn.IdleIconLeftImage = null;
            this.LoginBtn.IdleIconRightImage = null;
            this.LoginBtn.IndicateFocus = false;
            this.LoginBtn.Location = new System.Drawing.Point(137, 362);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoginBtn.OnDisabledState.BorderRadius = 5;
            this.LoginBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginBtn.OnDisabledState.BorderThickness = 0;
            this.LoginBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoginBtn.OnDisabledState.IconLeftImage = null;
            this.LoginBtn.OnDisabledState.IconRightImage = null;
            this.LoginBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.LoginBtn.onHoverState.BorderRadius = 5;
            this.LoginBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginBtn.onHoverState.BorderThickness = 0;
            this.LoginBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.LoginBtn.onHoverState.ForeColor = System.Drawing.Color.Silver;
            this.LoginBtn.onHoverState.IconLeftImage = null;
            this.LoginBtn.onHoverState.IconRightImage = null;
            this.LoginBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.OnIdleState.BorderRadius = 5;
            this.LoginBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.LoginBtn.OnIdleState.BorderThickness = 0;
            this.LoginBtn.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.LoginBtn.OnIdleState.ForeColor = System.Drawing.Color.Silver;
            this.LoginBtn.OnIdleState.IconLeftImage = null;
            this.LoginBtn.OnIdleState.IconRightImage = null;
            this.LoginBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.LoginBtn.OnPressedState.BorderRadius = 5;
            this.LoginBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginBtn.OnPressedState.BorderThickness = 0;
            this.LoginBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.LoginBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnPressedState.IconLeftImage = null;
            this.LoginBtn.OnPressedState.IconRightImage = null;
            this.LoginBtn.Size = new System.Drawing.Size(149, 39);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.TextMarginLeft = 0;
            this.LoginBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.LoginBtn.UseDefaultRadiusAndThickness = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NeoXLauncher.Executable.Properties.Resources.b4b6ba0af686e534897f4363b46c1a5d;
            this.pictureBox1.Location = new System.Drawing.Point(436, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PswTxtBox
            // 
            this.PswTxtBox.AcceptsReturn = false;
            this.PswTxtBox.AcceptsTab = false;
            this.PswTxtBox.AnimationSpeed = 200;
            this.PswTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PswTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PswTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.PswTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PswTxtBox.BackgroundImage")));
            this.PswTxtBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.PswTxtBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PswTxtBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PswTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.PswTxtBox.BorderRadius = 1;
            this.PswTxtBox.BorderThickness = 1;
            this.PswTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PswTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PswTxtBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PswTxtBox.DefaultText = "";
            this.PswTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.PswTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.PswTxtBox.HideSelection = true;
            this.PswTxtBox.IconLeft = null;
            this.PswTxtBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PswTxtBox.IconPadding = 10;
            this.PswTxtBox.IconRight = null;
            this.PswTxtBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PswTxtBox.Lines = new string[0];
            this.PswTxtBox.Location = new System.Drawing.Point(228, 191);
            this.PswTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PswTxtBox.MaxLength = 32767;
            this.PswTxtBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PswTxtBox.Modified = false;
            this.PswTxtBox.Multiline = false;
            this.PswTxtBox.Name = "PswTxtBox";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PswTxtBox.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PswTxtBox.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PswTxtBox.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            stateProperties12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PswTxtBox.OnIdleState = stateProperties12;
            this.PswTxtBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PswTxtBox.PasswordChar = '●';
            this.PswTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PswTxtBox.PlaceholderText = "Password";
            this.PswTxtBox.ReadOnly = false;
            this.PswTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PswTxtBox.SelectedText = "";
            this.PswTxtBox.SelectionLength = 0;
            this.PswTxtBox.SelectionStart = 0;
            this.PswTxtBox.ShortcutsEnabled = true;
            this.PswTxtBox.Size = new System.Drawing.Size(203, 41);
            this.PswTxtBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.PswTxtBox.TabIndex = 10;
            this.PswTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PswTxtBox.TextMarginBottom = 0;
            this.PswTxtBox.TextMarginLeft = 3;
            this.PswTxtBox.TextMarginTop = 0;
            this.PswTxtBox.TextPlaceholder = "Password";
            this.PswTxtBox.UseSystemPasswordChar = true;
            this.PswTxtBox.WordWrap = true;
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
            this.AccountTxtBox.Location = new System.Drawing.Point(1, 191);
            this.AccountTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountTxtBox.MaxLength = 32767;
            this.AccountTxtBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.AccountTxtBox.Modified = false;
            this.AccountTxtBox.Multiline = false;
            this.AccountTxtBox.Name = "AccountTxtBox";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AccountTxtBox.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.AccountTxtBox.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AccountTxtBox.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            stateProperties16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AccountTxtBox.OnIdleState = stateProperties16;
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
            this.AccountTxtBox.Size = new System.Drawing.Size(221, 41);
            this.AccountTxtBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.AccountTxtBox.TabIndex = 9;
            this.AccountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AccountTxtBox.TextMarginBottom = 0;
            this.AccountTxtBox.TextMarginLeft = 3;
            this.AccountTxtBox.TextMarginTop = 0;
            this.AccountTxtBox.TextPlaceholder = "Account name\r\n";
            this.AccountTxtBox.UseSystemPasswordChar = false;
            this.AccountTxtBox.WordWrap = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.RememberCheckBox);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PswTxtBox);
            this.Controls.Add(this.AccountTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeoX Login";
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox PswTxtBox;
        private Bunifu.UI.WinForms.BunifuTextBox AccountTxtBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.UI.WinForms.BunifuCheckBox RememberCheckBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CloseBtn;
    }
}