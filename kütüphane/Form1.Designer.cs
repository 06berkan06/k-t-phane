namespace kütüphane
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Veriler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.chknobel = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpyazar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.cmbkitaptürü = new System.Windows.Forms.ComboBox();
            this.cmbyazar = new System.Windows.Forms.ComboBox();
            this.cmbkitap = new System.Windows.Forms.ComboBox();
            this.txtmeslegi = new System.Windows.Forms.TextBox();
            this.txtmusteriadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpyazar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.chknobel);
            this.groupBox1.Controls.Add(this.txtyazar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(30, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazar Seçimi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbyazar);
            this.groupBox2.Controls.Add(this.cmbkitaptürü);
            this.groupBox2.Controls.Add(this.txtsayfa);
            this.groupBox2.Controls.Add(this.txtfiyat);
            this.groupBox2.Controls.Add(this.txtkitapadi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(362, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Seçimi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbkitap);
            this.groupBox3.Controls.Add(this.txtmeslegi);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txtmusteriadi);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(30, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Seçimi";
            // 
            // Veriler
            // 
            this.Veriler.FormattingEnabled = true;
            this.Veriler.Location = new System.Drawing.Point(362, 240);
            this.Veriler.Name = "Veriler";
            this.Veriler.Size = new System.Drawing.Size(285, 160);
            this.Veriler.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "yazar ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "kitap ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "müsteri ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(566, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "verileri getir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(90, 38);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(100, 20);
            this.txtyazar.TabIndex = 1;
            // 
            // chknobel
            // 
            this.chknobel.AutoSize = true;
            this.chknobel.Location = new System.Drawing.Point(90, 104);
            this.chknobel.Name = "chknobel";
            this.chknobel.Size = new System.Drawing.Size(52, 17);
            this.chknobel.TabIndex = 2;
            this.chknobel.Text = "Varmi";
            this.chknobel.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(34, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Yazar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dogumtarihi";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nobel";
            // 
            // dtpyazar
            // 
            this.dtpyazar.Location = new System.Drawing.Point(90, 66);
            this.dtpyazar.Name = "dtpyazar";
            this.dtpyazar.Size = new System.Drawing.Size(200, 20);
            this.dtpyazar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitapadi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitaptürü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kitap sayfasi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yazarı";
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(108, 23);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(100, 20);
            this.txtkitapadi.TabIndex = 7;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(108, 72);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 8;
            // 
            // txtsayfa
            // 
            this.txtsayfa.Location = new System.Drawing.Point(108, 97);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(100, 20);
            this.txtsayfa.TabIndex = 9;
            // 
            // cmbkitaptürü
            // 
            this.cmbkitaptürü.FormattingEnabled = true;
            this.cmbkitaptürü.Items.AddRange(new object[] {
            "ROMAN",
            "HİKAYE"});
            this.cmbkitaptürü.Location = new System.Drawing.Point(108, 45);
            this.cmbkitaptürü.Name = "cmbkitaptürü";
            this.cmbkitaptürü.Size = new System.Drawing.Size(100, 21);
            this.cmbkitaptürü.TabIndex = 10;
            // 
            // cmbyazar
            // 
            this.cmbyazar.FormattingEnabled = true;
            this.cmbyazar.Location = new System.Drawing.Point(108, 123);
            this.cmbyazar.Name = "cmbyazar";
            this.cmbyazar.Size = new System.Drawing.Size(100, 21);
            this.cmbyazar.TabIndex = 11;
            // 
            // cmbkitap
            // 
            this.cmbkitap.FormattingEnabled = true;
            this.cmbkitap.Location = new System.Drawing.Point(90, 94);
            this.cmbkitap.Name = "cmbkitap";
            this.cmbkitap.Size = new System.Drawing.Size(100, 21);
            this.cmbkitap.TabIndex = 17;
            // 
            // txtmeslegi
            // 
            this.txtmeslegi.Location = new System.Drawing.Point(90, 60);
            this.txtmeslegi.Name = "txtmeslegi";
            this.txtmeslegi.Size = new System.Drawing.Size(100, 20);
            this.txtmeslegi.TabIndex = 16;
            // 
            // txtmusteriadi
            // 
            this.txtmusteriadi.Location = new System.Drawing.Point(90, 30);
            this.txtmusteriadi.Name = "txtmusteriadi";
            this.txtmusteriadi.Size = new System.Drawing.Size(100, 20);
            this.txtmusteriadi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kitap";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mesleği";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Müşteriadi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Veriler);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpyazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox chknobel;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox Veriler;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbyazar;
        private System.Windows.Forms.ComboBox cmbkitaptürü;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbkitap;
        private System.Windows.Forms.TextBox txtmeslegi;
        private System.Windows.Forms.TextBox txtmusteriadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

