namespace NeoXLauncher.Executable.Forms.Subforms
{
    partial class NewsForm
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
            this.NewsSelectorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NewsSelectorPanel
            // 
            this.NewsSelectorPanel.Location = new System.Drawing.Point(0, 0);
            this.NewsSelectorPanel.Name = "NewsSelectorPanel";
            this.NewsSelectorPanel.Size = new System.Drawing.Size(243, 794);
            this.NewsSelectorPanel.TabIndex = 0;
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1440, 794);
            this.Controls.Add(this.NewsSelectorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewsForm";
            this.Text = "NewsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NewsSelectorPanel;
    }
}