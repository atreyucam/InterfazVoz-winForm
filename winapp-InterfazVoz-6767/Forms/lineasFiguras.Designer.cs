namespace winapp_InterfazVoz_6767
{
    partial class lineasFiguras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lineasFiguras));
            this.IniciarRecoFigura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputVoice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureFigura = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconMicrophone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFigura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMicrophone)).BeginInit();
            this.SuspendLayout();
            // 
            // IniciarRecoFigura
            // 
            this.IniciarRecoFigura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(165)))), ((int)(((byte)(61)))));
            this.IniciarRecoFigura.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IniciarRecoFigura.FlatAppearance.BorderSize = 2;
            this.IniciarRecoFigura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarRecoFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarRecoFigura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IniciarRecoFigura.Location = new System.Drawing.Point(651, 822);
            this.IniciarRecoFigura.Name = "IniciarRecoFigura";
            this.IniciarRecoFigura.Size = new System.Drawing.Size(153, 50);
            this.IniciarRecoFigura.TabIndex = 6;
            this.IniciarRecoFigura.Text = "Iniciar";
            this.IniciarRecoFigura.UseVisualStyleBackColor = false;
            this.IniciarRecoFigura.Click += new System.EventHandler(this.IniciarRecoFigura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pronuncia lo que buscas:";
            // 
            // inputVoice
            // 
            this.inputVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputVoice.Location = new System.Drawing.Point(486, 264);
            this.inputVoice.Name = "inputVoice";
            this.inputVoice.Size = new System.Drawing.Size(499, 39);
            this.inputVoice.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(670, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "figura:";
            // 
            // pictureFigura
            // 
            this.pictureFigura.BackColor = System.Drawing.Color.White;
            this.pictureFigura.Location = new System.Drawing.Point(590, 481);
            this.pictureFigura.Name = "pictureFigura";
            this.pictureFigura.Size = new System.Drawing.Size(269, 213);
            this.pictureFigura.TabIndex = 9;
            this.pictureFigura.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PapayaWhip;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1086, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 275);
            this.label3.TabIndex = 11;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1070, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "figuras disponibles:";
            // 
            // iconMicrophone
            // 
            this.iconMicrophone.Image = global::winapp_InterfazVoz_6767.Properties.Resources.microphone;
            this.iconMicrophone.Location = new System.Drawing.Point(848, 800);
            this.iconMicrophone.Name = "iconMicrophone";
            this.iconMicrophone.Size = new System.Drawing.Size(89, 86);
            this.iconMicrophone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMicrophone.TabIndex = 13;
            this.iconMicrophone.TabStop = false;
            // 
            // lineasFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1465, 1026);
            this.Controls.Add(this.iconMicrophone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureFigura);
            this.Controls.Add(this.inputVoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IniciarRecoFigura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lineasFiguras";
            this.Text = "lineasFiguras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureFigura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMicrophone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IniciarRecoFigura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputVoice;
        private System.Windows.Forms.PictureBox pictureFigura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox iconMicrophone;
    }
}