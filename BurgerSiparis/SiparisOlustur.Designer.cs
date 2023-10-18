namespace BurgerSiparis
{
    partial class SiparisOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cboxMenu = new ComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            rbBuyuk = new RadioButton();
            rbOrta = new RadioButton();
            rbKucuk = new RadioButton();
            label3 = new Label();
            nudAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            lstSiparisler = new ListBox();
            lblToplamTutar = new Label();
            btnSiparisiOnayla = new Button();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 208);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Menü Seçiniz";
            // 
            // cboxMenu
            // 
            cboxMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxMenu.FormattingEnabled = true;
            cboxMenu.Location = new Point(33, 245);
            cboxMenu.Margin = new Padding(3, 4, 3, 4);
            cboxMenu.Name = "cboxMenu";
            cboxMenu.Size = new Size(207, 28);
            cboxMenu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 295);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 1;
            label2.Text = "Ekstra Malzeme Seçiniz";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbBuyuk);
            groupBox1.Controls.Add(rbOrta);
            groupBox1.Controls.Add(rbKucuk);
            groupBox1.Location = new Point(33, 521);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(208, 99);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Boyut Seçiniz";
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(135, 47);
            rbBuyuk.Margin = new Padding(3, 4, 3, 4);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(69, 24);
            rbBuyuk.TabIndex = 0;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(73, 47);
            rbOrta.Margin = new Padding(3, 4, 3, 4);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(59, 24);
            rbOrta.TabIndex = 0;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(0, 47);
            rbKucuk.Margin = new Padding(3, 4, 3, 4);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(69, 24);
            rbKucuk.TabIndex = 0;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 659);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 1;
            label3.Text = "Adet";
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(104, 648);
            nudAdet.Margin = new Padding(3, 4, 3, 4);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(137, 27);
            nudAdet.TabIndex = 5;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(33, 719);
            btnSiparisEkle.Margin = new Padding(3, 4, 3, 4);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(208, 55);
            btnSiparisEkle.TabIndex = 6;
            btnSiparisEkle.Text = "Siparişi Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 20;
            lstSiparisler.Location = new Point(279, 29);
            lstSiparisler.Margin = new Padding(3, 4, 3, 4);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(643, 604);
            lstSiparisler.TabIndex = 7;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(366, 735);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(50, 25);
            lblToplamTutar.TabIndex = 1;
            lblToplamTutar.Text = "0.00";
            // 
            // btnSiparisiOnayla
            // 
            btnSiparisiOnayla.Location = new Point(759, 719);
            btnSiparisiOnayla.Margin = new Padding(3, 4, 3, 4);
            btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            btnSiparisiOnayla.Size = new Size(163, 55);
            btnSiparisiOnayla.TabIndex = 8;
            btnSiparisiOnayla.Text = "Siparişi Onayla";
            btnSiparisiOnayla.UseVisualStyleBackColor = true;
            btnSiparisiOnayla.Click += btnSiparisiOnayla_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(279, 737);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 1;
            label5.Text = "Toplam";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(33, 319);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(201, 195);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 811);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSiparisiOnayla);
            Controls.Add(lstSiparisler);
            Controls.Add(btnSiparisEkle);
            Controls.Add(nudAdet);
            Controls.Add(groupBox1);
            Controls.Add(cboxMenu);
            Controls.Add(lblToplamTutar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SiparisOlustur";
            Text = "Siparis Olustur";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cboxMenu;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rbBuyuk;
        private RadioButton rbOrta;
        private RadioButton rbKucuk;
        private Label label3;
        private NumericUpDown nudAdet;
        private Button btnSiparisEkle;
        private ListBox lstSiparisler;
        private Label lblToplamTutar;
        private Button btnSiparisiOnayla;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}