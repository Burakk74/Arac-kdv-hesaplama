namespace _23MY03001_ODEV_NO_03001
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kdv_tutar_lbl = new System.Windows.Forms.Label();
            this.otv_tutar_lbl = new System.Windows.Forms.Label();
            this.toplam_fiyat_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.otv_oran_lbl = new System.Windows.Forms.Label();
            this.kdv_oran_lbl = new System.Windows.Forms.Label();
            this.eklenen_vergi_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Otomobil",
            "Motosiklet",
            "Otobüs",
            "Midibüs",
            "Minibüs",
            "Hybrid",
            "Elektirkli"});
            this.comboBox1.Location = new System.Drawing.Point(441, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(415, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aracın Ham Fiyatını Giriniz :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(244, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 24);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(263, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "KDV Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(263, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "ÖTV Fiyatı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(246, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam Fiyat :";
            // 
            // kdv_tutar_lbl
            // 
            this.kdv_tutar_lbl.AutoSize = true;
            this.kdv_tutar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdv_tutar_lbl.Location = new System.Drawing.Point(353, 189);
            this.kdv_tutar_lbl.Name = "kdv_tutar_lbl";
            this.kdv_tutar_lbl.Size = new System.Drawing.Size(48, 18);
            this.kdv_tutar_lbl.TabIndex = 8;
            this.kdv_tutar_lbl.Text = "_____";
            // 
            // otv_tutar_lbl
            // 
            this.otv_tutar_lbl.AutoSize = true;
            this.otv_tutar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otv_tutar_lbl.Location = new System.Drawing.Point(353, 226);
            this.otv_tutar_lbl.Name = "otv_tutar_lbl";
            this.otv_tutar_lbl.Size = new System.Drawing.Size(48, 18);
            this.otv_tutar_lbl.TabIndex = 9;
            this.otv_tutar_lbl.Text = "_____";
            // 
            // toplam_fiyat_lbl
            // 
            this.toplam_fiyat_lbl.AutoSize = true;
            this.toplam_fiyat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplam_fiyat_lbl.Location = new System.Drawing.Point(353, 298);
            this.toplam_fiyat_lbl.Name = "toplam_fiyat_lbl";
            this.toplam_fiyat_lbl.Size = new System.Drawing.Size(48, 18);
            this.toplam_fiyat_lbl.TabIndex = 10;
            this.toplam_fiyat_lbl.Text = "_____";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "ÖTV Oranı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(34, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "KDV Oranı :";
            // 
            // otv_oran_lbl
            // 
            this.otv_oran_lbl.AutoSize = true;
            this.otv_oran_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otv_oran_lbl.Location = new System.Drawing.Point(126, 236);
            this.otv_oran_lbl.Name = "otv_oran_lbl";
            this.otv_oran_lbl.Size = new System.Drawing.Size(48, 18);
            this.otv_oran_lbl.TabIndex = 15;
            this.otv_oran_lbl.Text = "_____";
            // 
            // kdv_oran_lbl
            // 
            this.kdv_oran_lbl.AutoSize = true;
            this.kdv_oran_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdv_oran_lbl.Location = new System.Drawing.Point(126, 189);
            this.kdv_oran_lbl.Name = "kdv_oran_lbl";
            this.kdv_oran_lbl.Size = new System.Drawing.Size(48, 18);
            this.kdv_oran_lbl.TabIndex = 14;
            this.kdv_oran_lbl.Text = "_____";
            // 
            // eklenen_vergi_lbl
            // 
            this.eklenen_vergi_lbl.AutoSize = true;
            this.eklenen_vergi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklenen_vergi_lbl.Location = new System.Drawing.Point(353, 262);
            this.eklenen_vergi_lbl.Name = "eklenen_vergi_lbl";
            this.eklenen_vergi_lbl.Size = new System.Drawing.Size(48, 18);
            this.eklenen_vergi_lbl.TabIndex = 17;
            this.eklenen_vergi_lbl.Text = "_____";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(184, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Eklenecek Vergi Tutarı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(396, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Araç kategorisi Seçiniz :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(593, 397);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eklenen_vergi_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.otv_oran_lbl);
            this.Controls.Add(this.kdv_oran_lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toplam_fiyat_lbl);
            this.Controls.Add(this.otv_tutar_lbl);
            this.Controls.Add(this.kdv_tutar_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kdv_tutar_lbl;
        private System.Windows.Forms.Label otv_tutar_lbl;
        private System.Windows.Forms.Label toplam_fiyat_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label otv_oran_lbl;
        private System.Windows.Forms.Label kdv_oran_lbl;
        private System.Windows.Forms.Label eklenen_vergi_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

