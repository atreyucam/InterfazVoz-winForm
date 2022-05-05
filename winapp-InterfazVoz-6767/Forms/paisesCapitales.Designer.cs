namespace winapp_InterfazVoz_6767
{
    partial class paisesCapitales
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
            this.container = new System.Windows.Forms.Panel();
            this.IniciarRecoPais = new System.Windows.Forms.Button();
            this.outputCapital = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countryImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconMicrophone = new System.Windows.Forms.PictureBox();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMicrophone)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.White;
            this.container.Controls.Add(this.iconMicrophone);
            this.container.Controls.Add(this.IniciarRecoPais);
            this.container.Controls.Add(this.countryImg);
            this.container.Controls.Add(this.outputCapital);
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.inputPais);
            this.container.Controls.Add(this.label1);
            this.container.Dock = System.Windows.Forms.DockStyle.Left;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(891, 1022);
            this.container.TabIndex = 1;
            // 
            // IniciarRecoPais
            // 
            this.IniciarRecoPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(165)))), ((int)(((byte)(61)))));
            this.IniciarRecoPais.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IniciarRecoPais.FlatAppearance.BorderSize = 2;
            this.IniciarRecoPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarRecoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarRecoPais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IniciarRecoPais.Location = new System.Drawing.Point(382, 883);
            this.IniciarRecoPais.Name = "IniciarRecoPais";
            this.IniciarRecoPais.Size = new System.Drawing.Size(153, 50);
            this.IniciarRecoPais.TabIndex = 5;
            this.IniciarRecoPais.Text = "Iniciar";
            this.IniciarRecoPais.UseVisualStyleBackColor = false;
            this.IniciarRecoPais.Click += new System.EventHandler(this.IniciarRecoPais_Click);
            // 
            // outputCapital
            // 
            this.outputCapital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputCapital.Location = new System.Drawing.Point(339, 443);
            this.outputCapital.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputCapital.Name = "outputCapital";
            this.outputCapital.Size = new System.Drawing.Size(244, 32);
            this.outputCapital.TabIndex = 3;
            this.outputCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Capital";
            // 
            // inputPais
            // 
            this.inputPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPais.Location = new System.Drawing.Point(339, 228);
            this.inputPais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputPais.Name = "inputPais";
            this.inputPais.Size = new System.Drawing.Size(244, 32);
            this.inputPais.TabIndex = 1;
            this.inputPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Di el nombre del pais";
            // 
            // countryImg
            // 
            this.countryImg.Location = new System.Drawing.Point(324, 583);
            this.countryImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countryImg.Name = "countryImg";
            this.countryImg.Size = new System.Drawing.Size(261, 200);
            this.countryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.countryImg.TabIndex = 4;
            this.countryImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winapp_InterfazVoz_6767.Properties.Resources.dbid0rg_a4930125_633e_49ea_bfb2_54972835e324;
            this.pictureBox1.Location = new System.Drawing.Point(916, 165);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 692);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconMicrophone
            // 
            this.iconMicrophone.Image = global::winapp_InterfazVoz_6767.Properties.Resources.microphone;
            this.iconMicrophone.Location = new System.Drawing.Point(593, 859);
            this.iconMicrophone.Name = "iconMicrophone";
            this.iconMicrophone.Size = new System.Drawing.Size(89, 86);
            this.iconMicrophone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMicrophone.TabIndex = 6;
            this.iconMicrophone.TabStop = false;
            // 
            // paisesCapitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1462, 1022);
            this.Controls.Add(this.container);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "paisesCapitales";
            this.Text = "paisesCapitales";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMicrophone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.TextBox inputPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputCapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox countryImg;
        private System.Windows.Forms.Button IniciarRecoPais;
        private System.Windows.Forms.PictureBox iconMicrophone;
    }
}