namespace OtelOtomasyon
{
    partial class OdaListele
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
            this.dtGrView = new System.Windows.Forms.DataGridView();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.rbtn_bos = new System.Windows.Forms.RadioButton();
            this.rbtn_dolu = new System.Windows.Forms.RadioButton();
            this.rbtn_tum = new System.Windows.Forms.RadioButton();
            this.gBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrView
            // 
            this.dtGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrView.Location = new System.Drawing.Point(24, 329);
            this.dtGrView.Margin = new System.Windows.Forms.Padding(3, 3, 4, 4);
            this.dtGrView.Name = "dtGrView";
            this.dtGrView.RowHeadersWidth = 45;
            this.dtGrView.Size = new System.Drawing.Size(509, 59);
            this.dtGrView.TabIndex = 2;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(24, 238);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(82, 40);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "Çık";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // rbtn_bos
            // 
            this.rbtn_bos.AutoSize = true;
            this.rbtn_bos.Location = new System.Drawing.Point(24, 55);
            this.rbtn_bos.Name = "rbtn_bos";
            this.rbtn_bos.Size = new System.Drawing.Size(77, 17);
            this.rbtn_bos.TabIndex = 4;
            this.rbtn_bos.TabStop = true;
            this.rbtn_bos.Text = "Boş Odalar";
            this.rbtn_bos.UseVisualStyleBackColor = true;
            this.rbtn_bos.CheckedChanged += new System.EventHandler(this.rbtn_bos_CheckedChanged);
            // 
            // rbtn_dolu
            // 
            this.rbtn_dolu.AutoSize = true;
            this.rbtn_dolu.Location = new System.Drawing.Point(24, 97);
            this.rbtn_dolu.Name = "rbtn_dolu";
            this.rbtn_dolu.Size = new System.Drawing.Size(81, 17);
            this.rbtn_dolu.TabIndex = 5;
            this.rbtn_dolu.TabStop = true;
            this.rbtn_dolu.Text = "Dolu Odalar";
            this.rbtn_dolu.UseVisualStyleBackColor = true;
            this.rbtn_dolu.CheckedChanged += new System.EventHandler(this.rbtn_dolu_CheckedChanged);
            // 
            // rbtn_tum
            // 
            this.rbtn_tum.AutoSize = true;
            this.rbtn_tum.Location = new System.Drawing.Point(24, 136);
            this.rbtn_tum.Name = "rbtn_tum";
            this.rbtn_tum.Size = new System.Drawing.Size(52, 17);
            this.rbtn_tum.TabIndex = 6;
            this.rbtn_tum.TabStop = true;
            this.rbtn_tum.Text = "Tümü";
            this.rbtn_tum.UseVisualStyleBackColor = true;
            this.rbtn_tum.CheckedChanged += new System.EventHandler(this.rbtn_tum_CheckedChanged);
            // 
            // gBox
            // 
            this.gBox.Location = new System.Drawing.Point(127, 12);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(711, 311);
            this.gBox.TabIndex = 23;
            this.gBox.TabStop = false;
            // 
            // OdaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 414);
            this.Controls.Add(this.rbtn_tum);
            this.Controls.Add(this.rbtn_dolu);
            this.Controls.Add(this.rbtn_bos);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.dtGrView);
            this.Controls.Add(this.gBox);
            this.Name = "OdaListele";
            this.Text = "Oda Listele";
            this.Load += new System.EventHandler(this.OdaListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrView;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.RadioButton rbtn_bos;
        private System.Windows.Forms.RadioButton rbtn_dolu;
        private System.Windows.Forms.RadioButton rbtn_tum;
        private System.Windows.Forms.GroupBox gBox;
    }
}