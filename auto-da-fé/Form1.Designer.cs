namespace auto_da_fé
{
    partial class Form1
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
            this.LockWallpaper = new System.Windows.Forms.CheckBox();
            this.EasyButton = new System.Windows.Forms.Button();
            this.MediumButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.NsflButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LockWallpaper
            // 
            this.LockWallpaper.AutoSize = true;
            this.LockWallpaper.Location = new System.Drawing.Point(12, 12);
            this.LockWallpaper.Name = "LockWallpaper";
            this.LockWallpaper.Size = new System.Drawing.Size(142, 17);
            this.LockWallpaper.TabIndex = 0;
            this.LockWallpaper.Text = "Lock wallpaper changes";
            this.LockWallpaper.UseVisualStyleBackColor = true;
            this.LockWallpaper.CheckedChanged += new System.EventHandler(this.LockWallpaper_CheckedChanged);
            // 
            // EasyButton
            // 
            this.EasyButton.Location = new System.Drawing.Point(12, 35);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(75, 23);
            this.EasyButton.TabIndex = 1;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = true;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // MediumButton
            // 
            this.MediumButton.Location = new System.Drawing.Point(93, 35);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(75, 23);
            this.MediumButton.TabIndex = 2;
            this.MediumButton.Text = "Medium";
            this.MediumButton.UseVisualStyleBackColor = true;
            this.MediumButton.Click += new System.EventHandler(this.MediumButton_Click);
            // 
            // HardButton
            // 
            this.HardButton.Location = new System.Drawing.Point(174, 35);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(75, 23);
            this.HardButton.TabIndex = 3;
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = true;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // NsflButton
            // 
            this.NsflButton.Location = new System.Drawing.Point(255, 35);
            this.NsflButton.Name = "NsflButton";
            this.NsflButton.Size = new System.Drawing.Size(75, 23);
            this.NsflButton.TabIndex = 4;
            this.NsflButton.Text = "NSFL";
            this.NsflButton.UseVisualStyleBackColor = true;
            this.NsflButton.Click += new System.EventHandler(this.NsflButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 71);
            this.Controls.Add(this.NsflButton);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.MediumButton);
            this.Controls.Add(this.EasyButton);
            this.Controls.Add(this.LockWallpaper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox LockWallpaper;
        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Button MediumButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Button NsflButton;
    }
}

