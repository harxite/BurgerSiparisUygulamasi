namespace BurgerSiparis
{
    partial class MenuEkle
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
            gbMenuEkle = new GroupBox();
            nudMenuFiyat = new NumericUpDown();
            txtMenuAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnEkle = new Button();
            gbMenuEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyat).BeginInit();
            SuspendLayout();
            // 
            // gbMenuEkle
            // 
            gbMenuEkle.Controls.Add(nudMenuFiyat);
            gbMenuEkle.Controls.Add(txtMenuAd);
            gbMenuEkle.Controls.Add(label2);
            gbMenuEkle.Controls.Add(label1);
            gbMenuEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbMenuEkle.Location = new Point(90, 38);
            gbMenuEkle.Name = "gbMenuEkle";
            gbMenuEkle.Size = new Size(291, 163);
            gbMenuEkle.TabIndex = 0;
            gbMenuEkle.TabStop = false;
            gbMenuEkle.Text = "Menü Ekle";
            // 
            // nudMenuFiyat
            // 
            nudMenuFiyat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudMenuFiyat.Location = new Point(113, 103);
            nudMenuFiyat.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudMenuFiyat.Name = "nudMenuFiyat";
            nudMenuFiyat.Size = new Size(155, 23);
            nudMenuFiyat.TabIndex = 2;
            // 
            // txtMenuAd
            // 
            txtMenuAd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMenuAd.Location = new Point(113, 50);
            txtMenuAd.Name = "txtMenuAd";
            txtMenuAd.Size = new Size(155, 23);
            txtMenuAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 111);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 0;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 58);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(203, 221);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(155, 34);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 284);
            ControlBox = false;
            Controls.Add(btnEkle);
            Controls.Add(gbMenuEkle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEkle";
            Text = "Menu Ekle";
            gbMenuEkle.ResumeLayout(false);
            gbMenuEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbMenuEkle;
        private NumericUpDown nudMenuFiyat;
        private TextBox txtMenuAd;
        private Label label2;
        private Label label1;
        private Button btnEkle;
    }
}