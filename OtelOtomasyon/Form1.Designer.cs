namespace OtelOtomasyon
{
    partial class Giris
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
            this.button1 = new System.Windows.Forms.Button();
            this.label_sifre = new System.Windows.Forms.Label();
            this.text_kullanici = new System.Windows.Forms.TextBox();
            this.label_kullanici = new System.Windows.Forms.Label();
            this.text_sifre = new System.Windows.Forms.TextBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(183, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_sifre
            // 
            this.label_sifre.AutoSize = true;
            this.label_sifre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sifre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_sifre.Location = new System.Drawing.Point(73, 97);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(59, 14);
            this.label_sifre.TabIndex = 7;
            this.label_sifre.Text = "Şifre      ";
            // 
            // text_kullanici
            // 
            this.text_kullanici.Location = new System.Drawing.Point(183, 56);
            this.text_kullanici.Name = "text_kullanici";
            this.text_kullanici.Size = new System.Drawing.Size(167, 22);
            this.text_kullanici.TabIndex = 8;
            // 
            // label_kullanici
            // 
            this.label_kullanici.AutoSize = true;
            this.label_kullanici.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullanici.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_kullanici.Location = new System.Drawing.Point(73, 58);
            this.label_kullanici.Name = "label_kullanici";
            this.label_kullanici.Size = new System.Drawing.Size(84, 14);
            this.label_kullanici.TabIndex = 6;
            this.label_kullanici.Text = "Kullanıcı Adı ";
            // 
            // text_sifre
            // 
            this.text_sifre.Location = new System.Drawing.Point(183, 95);
            this.text_sifre.Name = "text_sifre";
            this.text_sifre.Size = new System.Drawing.Size(167, 22);
            this.text_sifre.TabIndex = 9;
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_iptal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iptal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_iptal.Location = new System.Drawing.Point(272, 138);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(78, 43);
            this.btn_iptal.TabIndex = 11;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 222);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_sifre);
            this.Controls.Add(this.text_kullanici);
            this.Controls.Add(this.label_kullanici);
            this.Controls.Add(this.text_sifre);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hoşgeldiniz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_sifre;
        private System.Windows.Forms.TextBox text_kullanici;
        private System.Windows.Forms.Label label_kullanici;
        private System.Windows.Forms.TextBox text_sifre;
        private System.Windows.Forms.Button btn_iptal;
    }
}

