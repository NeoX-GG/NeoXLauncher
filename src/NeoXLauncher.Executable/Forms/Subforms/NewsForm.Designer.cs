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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsForm));
            this.BackNewsBtn = new System.Windows.Forms.PictureBox();
            this.NextNewBtn = new System.Windows.Forms.PictureBox();
            this.NewsBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.BackNewsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextNewBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // BackNewsBtn
            // 
            this.BackNewsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackNewsBtn.BackgroundImage")));
            this.BackNewsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackNewsBtn.Location = new System.Drawing.Point(39, 719);
            this.BackNewsBtn.Name = "BackNewsBtn";
            this.BackNewsBtn.Size = new System.Drawing.Size(55, 50);
            this.BackNewsBtn.TabIndex = 0;
            this.BackNewsBtn.TabStop = false;
            this.BackNewsBtn.Click += new System.EventHandler(this.BackNewsBtn_Click);
            // 
            // NextNewBtn
            // 
            this.NextNewBtn.BackgroundImage = global::NeoXLauncher.Executable.Properties.Resources.Flecha_invertida;
            this.NextNewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextNewBtn.Location = new System.Drawing.Point(1343, 719);
            this.NextNewBtn.Name = "NextNewBtn";
            this.NextNewBtn.Size = new System.Drawing.Size(55, 50);
            this.NextNewBtn.TabIndex = 1;
            this.NextNewBtn.TabStop = false;
            this.NextNewBtn.Click += new System.EventHandler(this.NextNewBtn_Click);
            // 
            // NewsBrowser
            // 
            this.NewsBrowser.Location = new System.Drawing.Point(17, 8);
            this.NewsBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.NewsBrowser.Name = "NewsBrowser";
            this.NewsBrowser.Size = new System.Drawing.Size(1407, 770);
            this.NewsBrowser.TabIndex = 2;
            this.NewsBrowser.Url = new System.Uri("https://www.google.com/search?q=fecha+de+estreno+de+god+of+war+ragnarok&oq=fecha+" +
        "estreno+gow+&aqs=edge.1.69i57j0i22i30.9682j1j9&sourceid=chrome&ie=UTF-8", System.UriKind.Absolute);
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1440, 794);
            this.Controls.Add(this.BackNewsBtn);
            this.Controls.Add(this.NextNewBtn);
            this.Controls.Add(this.NewsBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewsForm";
            this.Text = "NewsForm";
            ((System.ComponentModel.ISupportInitialize)(this.BackNewsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextNewBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackNewsBtn;
        private System.Windows.Forms.PictureBox NextNewBtn;
        private System.Windows.Forms.WebBrowser NewsBrowser;
    }
}