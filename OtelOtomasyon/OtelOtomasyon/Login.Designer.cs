namespace OtelOtomasyon
{
    partial class Login
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
            this.picture_login = new System.Windows.Forms.PictureBox();
            this.label_kullanici = new System.Windows.Forms.Label();
            this.label_sifre = new System.Windows.Forms.Label();
            this.text_kullanici = new System.Windows.Forms.TextBox();
            this.text_sifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_login)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_login
            // 
            this.picture_login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picture_login.Location = new System.Drawing.Point(9, 14);
            this.picture_login.Name = "picture_login";
            this.picture_login.Size = new System.Drawing.Size(487, 160);
            this.picture_login.TabIndex = 0;
            this.picture_login.TabStop = false;
            // 
            // label_kullanici
            // 
            this.label_kullanici.AutoSize = true;
            this.label_kullanici.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullanici.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_kullanici.Location = new System.Drawing.Point(107, 197);
            this.label_kullanici.Name = "label_kullanici";
            this.label_kullanici.Size = new System.Drawing.Size(84, 14);
            this.label_kullanici.TabIndex = 1;
            this.label_kullanici.Text = "Kullanıcı Adı ";
            // 
            // label_sifre
            // 
            this.label_sifre.AutoSize = true;
            this.label_sifre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sifre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_sifre.Location = new System.Drawing.Point(107, 233);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(59, 14);
            this.label_sifre.TabIndex = 2;
            this.label_sifre.Text = "Şifre      ";
            // 
            // text_kullanici
            // 
            this.text_kullanici.Location = new System.Drawing.Point(201, 195);
            this.text_kullanici.Name = "text_kullanici";
            this.text_kullanici.Size = new System.Drawing.Size(144, 20);
            this.text_kullanici.TabIndex = 3;
            // 
            // text_sifre
            // 
            this.text_sifre.Location = new System.Drawing.Point(201, 231);
            this.text_sifre.Name = "text_sifre";
            this.text_sifre.Size = new System.Drawing.Size(144, 20);
            this.text_sifre.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_sifre);
            this.groupBox1.Controls.Add(this.text_kullanici);
            this.groupBox1.Controls.Add(this.label_kullanici);
            this.groupBox1.Controls.Add(this.text_sifre);
            this.groupBox1.Controls.Add(this.picture_login);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 317);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(233, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 329);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoşgeldiniz";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_login)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_login;
        private System.Windows.Forms.Label label_kullanici;
        private System.Windows.Forms.Label label_sifre;
        private System.Windows.Forms.TextBox text_kullanici;
        private System.Windows.Forms.TextBox text_sifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}