namespace BurgerSiparis
{
    partial class SiparisGoruntule
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
            lstSiparisler = new ListBox();
            gbCiro = new GroupBox();
            lblCiro = new Label();
            groupBox2 = new GroupBox();
            lblToplamSiparis = new Label();
            groupBox3 = new GroupBox();
            lblMalzemeGeliri = new Label();
            groupBox4 = new GroupBox();
            lblUrunAdedi = new Label();
            label1 = new Label();
            gbCiro.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 20;
            lstSiparisler.Location = new Point(47, 96);
            lstSiparisler.Margin = new Padding(3, 4, 3, 4);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(319, 484);
            lstSiparisler.TabIndex = 0;
            // 
            // gbCiro
            // 
            gbCiro.Controls.Add(lblCiro);
            gbCiro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbCiro.Location = new Point(394, 96);
            gbCiro.Margin = new Padding(3, 4, 3, 4);
            gbCiro.Name = "gbCiro";
            gbCiro.Padding = new Padding(3, 4, 3, 4);
            gbCiro.Size = new Size(243, 117);
            gbCiro.TabIndex = 1;
            gbCiro.TabStop = false;
            gbCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(54, 53);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(64, 35);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "0.00";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblToplamSiparis);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(394, 221);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(243, 117);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Toplam Sipariş";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamSiparis.ForeColor = Color.Red;
            lblToplamSiparis.Location = new Point(54, 53);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new Size(64, 35);
            lblToplamSiparis.TabIndex = 0;
            lblToplamSiparis.Text = "0.00";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblMalzemeGeliri);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(394, 347);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(243, 117);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ekstra Malzeme Geliri";
            // 
            // lblMalzemeGeliri
            // 
            lblMalzemeGeliri.AutoSize = true;
            lblMalzemeGeliri.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblMalzemeGeliri.ForeColor = Color.Red;
            lblMalzemeGeliri.Location = new Point(54, 55);
            lblMalzemeGeliri.Name = "lblMalzemeGeliri";
            lblMalzemeGeliri.Size = new Size(64, 35);
            lblMalzemeGeliri.TabIndex = 0;
            lblMalzemeGeliri.Text = "0.00";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblUrunAdedi);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(394, 472);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(243, 117);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // lblUrunAdedi
            // 
            lblUrunAdedi.AutoSize = true;
            lblUrunAdedi.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblUrunAdedi.ForeColor = Color.Red;
            lblUrunAdedi.Location = new Point(54, 53);
            lblUrunAdedi.Name = "lblUrunAdedi";
            lblUrunAdedi.Size = new Size(64, 35);
            lblUrunAdedi.TabIndex = 0;
            lblUrunAdedi.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 43);
            label1.Name = "label1";
            label1.Size = new Size(213, 35);
            label1.TabIndex = 2;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // SiparisGoruntule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 653);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(gbCiro);
            Controls.Add(lstSiparisler);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SiparisGoruntule";
            Text = "Siparis Görüntüle";
            Load += SiparisGoruntule_Load;
            gbCiro.ResumeLayout(false);
            gbCiro.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSiparisler;
        private GroupBox gbCiro;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private Label lblCiro;
        private Label lblToplamSiparis;
        private Label lblMalzemeGeliri;
        private Label lblUrunAdedi;
    }
}