namespace winapp_InterfazVoz_6767
{
    partial class outputVoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputReconociemiento = new System.Windows.Forms.TextBox();
            this.IniciarReconocimiento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHijoVoice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconMicrophone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMicrophone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hola, papá yo repetiré lo que tu digas ♥:\r\n";
            // 
            // outputReconociemiento
            // 
            this.outputReconociemiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputReconociemiento.Location = new System.Drawing.Point(447, 339);
            this.outputReconociemiento.Name = "outputReconociemiento";
            this.outputReconociemiento.Size = new System.Drawing.Size(523, 39);
            this.outputReconociemiento.TabIndex = 1;
            // 
            // IniciarReconocimiento
            // 
            this.IniciarReconocimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(165)))), ((int)(((byte)(61)))));
            this.IniciarReconocimiento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IniciarReconocimiento.FlatAppearance.BorderSize = 2;
            this.IniciarReconocimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarReconocimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarReconocimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IniciarReconocimiento.Location = new System.Drawing.Point(659, 436);
            this.IniciarReconocimiento.Name = "IniciarReconocimiento";
            this.IniciarReconocimiento.Size = new System.Drawing.Size(153, 50);
            this.IniciarReconocimiento.TabIndex = 2;
            this.IniciarReconocimiento.Text = "Iniciar";
            this.IniciarReconocimiento.UseVisualStyleBackColor = false;
            this.IniciarReconocimiento.Click += new System.EventHandler(this.IniciarReconocimiento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(294, 882);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 921);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(921, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Solo reconoce audio en inglés, debido a que mi ordenador personal solo tiene inst" +
    "alado el idioma inglés de forma predeterminada.\r\n";
            // 
            // buttonHijoVoice
            // 
            this.buttonHijoVoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(165)))), ((int)(((byte)(61)))));
            this.buttonHijoVoice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHijoVoice.FlatAppearance.BorderSize = 2;
            this.buttonHijoVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHijoVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHijoVoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHijoVoice.Location = new System.Drawing.Point(659, 507);
            this.buttonHijoVoice.Name = "buttonHijoVoice";
            this.buttonHijoVoice.Size = new System.Drawing.Size(153, 49);
            this.buttonHijoVoice.TabIndex = 6;
            this.buttonHijoVoice.Text = "Habla Hijo";
            this.buttonHijoVoice.UseVisualStyleBackColor = false;
            this.buttonHijoVoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::winapp_InterfazVoz_6767.Properties.Resources.boy;
            this.pictureBox1.Location = new System.Drawing.Point(601, 596);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // iconMicrophone
            // 
            this.iconMicrophone.Image = global::winapp_InterfazVoz_6767.Properties.Resources.microphone;
            this.iconMicrophone.Location = new System.Drawing.Point(881, 410);
            this.iconMicrophone.Name = "iconMicrophone";
            this.iconMicrophone.Size = new System.Drawing.Size(89, 86);
            this.iconMicrophone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMicrophone.TabIndex = 7;
            this.iconMicrophone.TabStop = false;
            // 
            // outputVoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1462, 1022);
            this.Controls.Add(this.iconMicrophone);
            this.Controls.Add(this.buttonHijoVoice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IniciarReconocimiento);
            this.Controls.Add(this.outputReconociemiento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "outputVoice";
            this.Text = "textoVoz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMicrophone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputReconociemiento;
        private System.Windows.Forms.Button IniciarReconocimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHijoVoice;
        private System.Windows.Forms.PictureBox iconMicrophone;
    }
}