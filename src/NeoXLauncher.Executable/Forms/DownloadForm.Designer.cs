
namespace NeoXLauncher.Executable.Forms
{
    partial class DownloadForm
    {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private global::System.ComponentModel.IContainer components = null;

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
			this.components = new global::System.ComponentModel.Container();
			this.LoadProgressBar = new global::CircularProgressBar.CircularProgressBar();
			this.label1 = new global::System.Windows.Forms.Label();
			this.Timer = new global::System.Windows.Forms.Timer(this.components);
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.PercentageLabel = new global::System.Windows.Forms.Label();
			this.InfoLabel = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.LoadProgressBar.AnimationFunction = global::WinFormAnimation.KnownAnimationFunctions.Liner;
			this.LoadProgressBar.AnimationSpeed = 500;
			this.LoadProgressBar.BackColor = global::System.Drawing.Color.Transparent;
			this.LoadProgressBar.Cursor = global::System.Windows.Forms.Cursors.WaitCursor;
			this.LoadProgressBar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 72f, global::System.Drawing.FontStyle.Bold);
			this.LoadProgressBar.ForeColor = global::System.Drawing.Color.White;
			this.LoadProgressBar.InnerColor = global::System.Drawing.Color.Transparent;
			this.LoadProgressBar.InnerMargin = 2;
			this.LoadProgressBar.InnerWidth = -1;
			this.LoadProgressBar.Location = new global::System.Drawing.Point(59, 131);
			this.LoadProgressBar.MarqueeAnimationSpeed = 2000;
			this.LoadProgressBar.Name = "LoadProgressBar";
			this.LoadProgressBar.OuterColor = global::System.Drawing.Color.FromArgb(28, 26, 43);
			this.LoadProgressBar.OuterMargin = -26;
			this.LoadProgressBar.OuterWidth = 26;
			this.LoadProgressBar.ProgressColor = global::System.Drawing.Color.FromArgb(85, 213, 219);
			this.LoadProgressBar.ProgressWidth = 6;
			this.LoadProgressBar.SecondaryFont = new global::System.Drawing.Font("Microsoft Sans Serif", 36f);
			this.LoadProgressBar.Size = new global::System.Drawing.Size(118, 118);
			this.LoadProgressBar.StartAngle = 270;
			this.LoadProgressBar.Style = global::System.Windows.Forms.ProgressBarStyle.Continuous;
			this.LoadProgressBar.SubscriptColor = global::System.Drawing.Color.FromArgb(166, 166, 166);
			this.LoadProgressBar.SubscriptMargin = new global::System.Windows.Forms.Padding(10, -35, 0, 0);
			this.LoadProgressBar.SubscriptText = ".23";
			this.LoadProgressBar.SuperscriptColor = global::System.Drawing.Color.FromArgb(166, 166, 166);
			this.LoadProgressBar.SuperscriptMargin = new global::System.Windows.Forms.Padding(10, 35, 0, 0);
			this.LoadProgressBar.SuperscriptText = "°C";
			this.LoadProgressBar.TabIndex = 1;
			this.LoadProgressBar.TextMargin = new global::System.Windows.Forms.Padding(8, 8, 0, 0);
			this.LoadProgressBar.Value = 68;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 24.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(85, 213, 219);
			this.label1.Location = new global::System.Drawing.Point(32, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(176, 38);
			this.label1.TabIndex = 2;
			this.label1.Text = "EarthLand";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Timer.Enabled = true;
			this.Timer.Tick += new global::System.EventHandler(this.Timer_Tick);
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			this.PercentageLabel.AutoSize = true;
			this.PercentageLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 24.75f, global::System.Drawing.FontStyle.Bold);
			this.PercentageLabel.ForeColor = global::System.Drawing.Color.FromArgb(85, 213, 219);
			this.PercentageLabel.Location = new global::System.Drawing.Point(78, 172);
			this.PercentageLabel.Name = "PercentageLabel";
			this.PercentageLabel.Size = new global::System.Drawing.Size(85, 38);
			this.PercentageLabel.TabIndex = 4;
			this.PercentageLabel.Text = "68%";
			this.InfoLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
			this.InfoLabel.ForeColor = global::System.Drawing.Color.FromArgb(85, 213, 219);
			this.InfoLabel.Location = new global::System.Drawing.Point(12, 95);
			this.InfoLabel.Name = "InfoLabel";
			this.InfoLabel.Size = new global::System.Drawing.Size(212, 23);
			this.InfoLabel.TabIndex = 5;
			this.InfoLabel.Text = "Loading...";
			this.InfoLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(42, 40, 60);
			base.ClientSize = new global::System.Drawing.Size(236, 265);
			base.Controls.Add(this.InfoLabel);
			base.Controls.Add(this.PercentageLabel);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.LoadProgressBar);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "SplashScreenForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loading launcher";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002A RID: 42
		private global::CircularProgressBar.CircularProgressBar LoadProgressBar;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Timer Timer;

		// Token: 0x0400002D RID: 45
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label PercentageLabel;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label InfoLabel;
		#endregion
	}
}