namespace winapp_InterfazVoz_6767
{
    partial class moverImagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moverImagen));
            this.pictureRuuner = new System.Windows.Forms.PictureBox();
            this.panelMainImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRuuner)).BeginInit();
            this.panelMainImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureRuuner
            // 
            this.pictureRuuner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureRuuner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.pictureRuuner.Image = ((System.Drawing.Image)(resources.GetObject("pictureRuuner.Image")));
            this.pictureRuuner.Location = new System.Drawing.Point(432, 238);
            this.pictureRuuner.Name = "pictureRuuner";
            this.pictureRuuner.Size = new System.Drawing.Size(163, 154);
            this.pictureRuuner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRuuner.TabIndex = 0;
            this.pictureRuuner.TabStop = false;
            // 
            // panelMainImage
            // 
            this.panelMainImage.Controls.Add(this.pictureBox2);
            this.panelMainImage.Controls.Add(this.pictureRuuner);
            this.panelMainImage.Controls.Add(this.pictureBox1);
            this.panelMainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainImage.Location = new System.Drawing.Point(0, 0);
            this.panelMainImage.Name = "panelMainImage";
            this.panelMainImage.Size = new System.Drawing.Size(975, 632);
            this.panelMainImage.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 632);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(808, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // moverImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 632);
            this.Controls.Add(this.panelMainImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "moverImagen";
            this.Text = "moverImagen";
            this.Load += new System.EventHandler(this.moverImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRuuner)).EndInit();
            this.panelMainImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureRuuner;
        private System.Windows.Forms.Panel panelMainImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}