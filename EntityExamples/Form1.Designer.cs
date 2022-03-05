
namespace EntityExamples
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnOgrenciListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtOgrenciFotograf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOgrenciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrenciId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDersKaydet = new System.Windows.Forms.Button();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDersId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnNotGuncelle = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtOrtalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDersListesi = new System.Windows.Forms.Button();
            this.BtnNotListesi = new System.Windows.Forms.Button();
            this.BtnProsedur = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.TextIdBul = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.Deneme = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Deneme.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(892, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnOgrenciListele
            // 
            this.BtnOgrenciListele.Location = new System.Drawing.Point(13, 298);
            this.BtnOgrenciListele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOgrenciListele.Name = "BtnOgrenciListele";
            this.BtnOgrenciListele.Size = new System.Drawing.Size(136, 41);
            this.BtnOgrenciListele.TabIndex = 1;
            this.BtnOgrenciListele.Text = "Öğrenci Listele";
            this.BtnOgrenciListele.UseVisualStyleBackColor = true;
            this.BtnOgrenciListele.Click += new System.EventHandler(this.BtnOgrenciListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(13, 347);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(136, 37);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(13, 392);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(136, 27);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(13, 427);
            this.BtnGüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(136, 33);
            this.BtnGüncelle.TabIndex = 4;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(15, 467);
            this.BtnBul.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(134, 28);
            this.BtnBul.TabIndex = 5;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtOgrenciFotograf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtOgrenciSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtOgrenciAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtOgrenciId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(239, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtOgrenciFotograf
            // 
            this.TxtOgrenciFotograf.Location = new System.Drawing.Point(125, 151);
            this.TxtOgrenciFotograf.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOgrenciFotograf.Name = "TxtOgrenciFotograf";
            this.TxtOgrenciFotograf.Size = new System.Drawing.Size(127, 27);
            this.TxtOgrenciFotograf.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fotoğraf";
            // 
            // TxtOgrenciSoyad
            // 
            this.TxtOgrenciSoyad.Location = new System.Drawing.Point(125, 116);
            this.TxtOgrenciSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOgrenciSoyad.Name = "TxtOgrenciSoyad";
            this.TxtOgrenciSoyad.Size = new System.Drawing.Size(127, 27);
            this.TxtOgrenciSoyad.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Soyad:";
            // 
            // TxtOgrenciAd
            // 
            this.TxtOgrenciAd.Location = new System.Drawing.Point(125, 81);
            this.TxtOgrenciAd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOgrenciAd.Name = "TxtOgrenciAd";
            this.TxtOgrenciAd.Size = new System.Drawing.Size(127, 27);
            this.TxtOgrenciAd.TabIndex = 17;
            this.TxtOgrenciAd.TextChanged += new System.EventHandler(this.TxtOgrenciAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ad:";
            // 
            // TxtOgrenciId
            // 
            this.TxtOgrenciId.Location = new System.Drawing.Point(125, 46);
            this.TxtOgrenciId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOgrenciId.Name = "TxtOgrenciId";
            this.TxtOgrenciId.Size = new System.Drawing.Size(127, 27);
            this.TxtOgrenciId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDersKaydet);
            this.groupBox2.Controls.Add(this.TxtDersAd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtDersId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(239, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders";
            // 
            // BtnDersKaydet
            // 
            this.BtnDersKaydet.Location = new System.Drawing.Point(112, 109);
            this.BtnDersKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDersKaydet.Name = "BtnDersKaydet";
            this.BtnDersKaydet.Size = new System.Drawing.Size(136, 35);
            this.BtnDersKaydet.TabIndex = 25;
            this.BtnDersKaydet.Text = "Kaydet";
            this.BtnDersKaydet.UseVisualStyleBackColor = true;
            this.BtnDersKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Location = new System.Drawing.Point(112, 64);
            this.TxtDersAd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(127, 27);
            this.TxtDersAd.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ders Adı:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtDersId
            // 
            this.TxtDersId.Location = new System.Drawing.Point(112, 29);
            this.TxtDersId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDersId.Name = "TxtDersId";
            this.TxtDersId.Size = new System.Drawing.Size(127, 27);
            this.TxtDersId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ders Id:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnNotGuncelle);
            this.groupBox3.Controls.Add(this.BtnHesapla);
            this.groupBox3.Controls.Add(this.TxtDurum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TxtOrtalama);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtSinav3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtSinav2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtSinav1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(584, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 330);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınavlar";
            // 
            // BtnNotGuncelle
            // 
            this.BtnNotGuncelle.Location = new System.Drawing.Point(51, 265);
            this.BtnNotGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNotGuncelle.Name = "BtnNotGuncelle";
            this.BtnNotGuncelle.Size = new System.Drawing.Size(201, 45);
            this.BtnNotGuncelle.TabIndex = 26;
            this.BtnNotGuncelle.Text = "Sınav Notu Güncelle";
            this.BtnNotGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(136, 229);
            this.BtnHesapla.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(116, 28);
            this.BtnHesapla.TabIndex = 25;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(125, 184);
            this.TxtDurum.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(127, 27);
            this.TxtDurum.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Durum:";
            // 
            // TxtOrtalama
            // 
            this.TxtOrtalama.Location = new System.Drawing.Point(125, 151);
            this.TxtOrtalama.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOrtalama.Name = "TxtOrtalama";
            this.TxtOrtalama.Size = new System.Drawing.Size(127, 27);
            this.TxtOrtalama.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ortalama:";
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(125, 116);
            this.TxtSinav3.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(127, 27);
            this.TxtSinav3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sınav 3:";
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(125, 81);
            this.TxtSinav2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(127, 27);
            this.TxtSinav2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sınav 2:";
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(125, 46);
            this.TxtSinav1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(127, 27);
            this.TxtSinav1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sınav 1:";
            // 
            // BtnDersListesi
            // 
            this.BtnDersListesi.Location = new System.Drawing.Point(13, 503);
            this.BtnDersListesi.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDersListesi.Name = "BtnDersListesi";
            this.BtnDersListesi.Size = new System.Drawing.Size(136, 36);
            this.BtnDersListesi.TabIndex = 23;
            this.BtnDersListesi.Text = "Ders Listesi";
            this.BtnDersListesi.UseVisualStyleBackColor = true;
            this.BtnDersListesi.Click += new System.EventHandler(this.BtnDersListesi_Click);
            // 
            // BtnNotListesi
            // 
            this.BtnNotListesi.Location = new System.Drawing.Point(13, 547);
            this.BtnNotListesi.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNotListesi.Name = "BtnNotListesi";
            this.BtnNotListesi.Size = new System.Drawing.Size(136, 35);
            this.BtnNotListesi.TabIndex = 24;
            this.BtnNotListesi.Text = "Not Listesi";
            this.BtnNotListesi.UseVisualStyleBackColor = true;
            this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
            // 
            // BtnProsedur
            // 
            this.BtnProsedur.Location = new System.Drawing.Point(15, 590);
            this.BtnProsedur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProsedur.Name = "BtnProsedur";
            this.BtnProsedur.Size = new System.Drawing.Size(136, 35);
            this.BtnProsedur.TabIndex = 25;
            this.BtnProsedur.Text = "Prosedür";
            this.BtnProsedur.UseVisualStyleBackColor = true;
            this.BtnProsedur.Click += new System.EventHandler(this.BtnProsedur_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(912, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(196, 24);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala A-->Z";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnLinqEntity
            // 
            this.BtnLinqEntity.Location = new System.Drawing.Point(912, 544);
            this.BtnLinqEntity.Name = "BtnLinqEntity";
            this.BtnLinqEntity.Size = new System.Drawing.Size(196, 77);
            this.BtnLinqEntity.TabIndex = 27;
            this.BtnLinqEntity.Text = "Linq Entity";
            this.BtnLinqEntity.UseVisualStyleBackColor = true;
            this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(912, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(196, 24);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala Z-->A";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(912, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(115, 24);
            this.radioButton3.TabIndex = 29;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Son 5 Kayıt";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 65);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(136, 24);
            this.radioButton4.TabIndex = 30;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Id\'ye Göre Bul";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // TextIdBul
            // 
            this.TextIdBul.Location = new System.Drawing.Point(42, 28);
            this.TextIdBul.Margin = new System.Windows.Forms.Padding(4);
            this.TextIdBul.Name = "TextIdBul";
            this.TextIdBul.Size = new System.Drawing.Size(127, 27);
            this.TextIdBul.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Id:";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(912, 105);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(193, 24);
            this.radioButton5.TabIndex = 31;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Adı \'A\' ile Başlayanlar";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Deneme
            // 
            this.Deneme.Controls.Add(this.radioButton4);
            this.Deneme.Controls.Add(this.TextIdBul);
            this.Deneme.Controls.Add(this.label12);
            this.Deneme.Location = new System.Drawing.Point(912, 427);
            this.Deneme.Name = "Deneme";
            this.Deneme.Size = new System.Drawing.Size(200, 100);
            this.Deneme.TabIndex = 32;
            this.Deneme.TabStop = false;
            this.Deneme.Text = "Deneme";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(912, 135);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(163, 24);
            this.radioButton6.TabIndex = 33;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Adı \'A\' ile Bitenler";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(912, 165);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(139, 24);
            this.radioButton7.TabIndex = 34;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Değer Var mı?";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(912, 195);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(195, 24);
            this.radioButton8.TabIndex = 35;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Toplam Öğrenci Saysı";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 656);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.Deneme);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.BtnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnProsedur);
            this.Controls.Add(this.BtnNotListesi);
            this.Controls.Add(this.BtnDersListesi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnOgrenciListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Deneme.ResumeLayout(false);
            this.Deneme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOgrenciListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtOgrenciFotograf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOgrenciSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOgrenciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrenciId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDersId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtOrtalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDersListesi;
        private System.Windows.Forms.Button BtnNotListesi;
        private System.Windows.Forms.Button BtnNotGuncelle;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnDersKaydet;
        private System.Windows.Forms.Button BtnProsedur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox TextIdBul;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox Deneme;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
    }
}

