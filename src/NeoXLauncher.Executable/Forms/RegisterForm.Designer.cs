
namespace NeoXLauncher.Executable.Forms
{
    partial class RegisterForm
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
            this.ProgressBar = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Animated = false;
            this.ProgressBar.AnimationInterval = 1;
            this.ProgressBar.AnimationSpeed = 1;
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.CircleMargin = 10;
            this.ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressBar.IsPercentage = false;
            this.ProgressBar.LineProgressThickness = 4;
            this.ProgressBar.LineThickness = 5;
            this.ProgressBar.Location = new System.Drawing.Point(41, 179);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressAnimationSpeed = 200;
            this.ProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ProgressBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.ProgressBar.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.ProgressBar.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.ProgressBar.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ProgressBar.Size = new System.Drawing.Size(152, 152);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.ProgressBar.SubScriptText = "3 mb/s";
            this.ProgressBar.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.ProgressBar.SuperScriptText = "%";
            this.ProgressBar.TabIndex = 16;
            this.ProgressBar.Text = "50";
            this.ProgressBar.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ProgressBar.Value = 50;
            this.ProgressBar.ValueByTransition = 50;
            this.ProgressBar.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(228, 343);
            this.Controls.Add(this.ProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuCircleProgress ProgressBar;
    }
}