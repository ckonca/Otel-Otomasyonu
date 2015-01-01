namespace OtelOtomasyon
{
    partial class MusteriAra
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
            this.label_mustri_ara = new System.Windows.Forms.Label();
            this.btn_bul = new System.Windows.Forms.Button();
            this.cbox_ara = new System.Windows.Forms.ComboBox();
            this.tbox_ara = new System.Windows.Forms.TextBox();
            this.btn_guncel = new System.Windows.Forms.Button();
            this.btn_tumu_listele = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label_mustri_ara
            // 
            this.label_mustri_ara.AutoSize = true;
            this.label_mustri_ara.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_mustri_ara.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_mustri_ara.Location = new System.Drawing.Point(31, 37);
            this.label_mustri_ara.Name = "label_mustri_ara";
            this.label_mustri_ara.Size = new System.Drawing.Size(95, 14);
            this.label_mustri_ara.TabIndex = 23;
            this.label_mustri_ara.Text = "Müşteri Ara     :";
            // 
            // btn_bul
            // 
            this.btn_bul.BackColor = System.Drawing.Color.LightBlue;
            this.btn_bul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bul.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_bul.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_bul.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_bul.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_bul.Location = new System.Drawing.Point(415, 28);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(149, 30);
            this.btn_bul.TabIndex = 3;
            this.btn_bul.Text = "Bul";
            this.btn_bul.UseVisualStyleBackColor = false;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // cbox_ara
            // 
            this.cbox_ara.FormattingEnabled = true;
            this.cbox_ara.Items.AddRange(new object[] {
            "Müşteri No",
            "TC Kimlik No",
            "Ad Soyad"});
            this.cbox_ara.Location = new System.Drawing.Point(137, 34);
            this.cbox_ara.Name = "cbox_ara";
            this.cbox_ara.Size = new System.Drawing.Size(121, 21);
            this.cbox_ara.TabIndex = 1;
            // 
            // tbox_ara
            // 
            this.tbox_ara.Location = new System.Drawing.Point(281, 34);
            this.tbox_ara.Name = "tbox_ara";
            this.tbox_ara.Size = new System.Drawing.Size(100, 20);
            this.tbox_ara.TabIndex = 2;
            // 
            // btn_guncel
            // 
            this.btn_guncel.Location = new System.Drawing.Point(30, 279);
            this.btn_guncel.Name = "btn_guncel";
            this.btn_guncel.Size = new System.Drawing.Size(96, 42);
            this.btn_guncel.TabIndex = 4;
            this.btn_guncel.Text = "Kayıt Güncelle";
            this.btn_guncel.UseVisualStyleBackColor = true;
            this.btn_guncel.Click += new System.EventHandler(this.btn_guncel_Click);
            // 
            // btn_tumu_listele
            // 
            this.btn_tumu_listele.Location = new System.Drawing.Point(171, 279);
            this.btn_tumu_listele.Name = "btn_tumu_listele";
            this.btn_tumu_listele.Size = new System.Drawing.Size(96, 42);
            this.btn_tumu_listele.TabIndex = 5;
            this.btn_tumu_listele.Text = "Tümünü Listele";
            this.btn_tumu_listele.UseVisualStyleBackColor = true;
            this.btn_tumu_listele.Click += new System.EventHandler(this.btn_tumu_listele_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(318, 279);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(96, 42);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Location = new System.Drawing.Point(0, 84);
            this.liste.Name = "liste";
            this.liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liste.Size = new System.Drawing.Size(626, 172);
            this.liste.TabIndex = 26;
            // 
            // MusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 333);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_tumu_listele);
            this.Controls.Add(this.btn_guncel);
            this.Controls.Add(this.tbox_ara);
            this.Controls.Add(this.cbox_ara);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.btn_bul);
            this.Controls.Add(this.label_mustri_ara);
            this.Name = "MusteriAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MusteriAra";
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_mustri_ara;
        private System.Windows.Forms.Button btn_bul;
        private System.Windows.Forms.ComboBox cbox_ara;
        private System.Windows.Forms.TextBox tbox_ara;
        private System.Windows.Forms.Button btn_guncel;
        private System.Windows.Forms.Button btn_tumu_listele;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.DataGridView liste;
    }
}