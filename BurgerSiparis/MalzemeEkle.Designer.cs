namespace BurgerSiparis
{
    partial class MalzemeEkle
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
            btnEkle = new Button();
            gbMalzemeEkle = new GroupBox();
            nudMalzemeFiyat = new NumericUpDown();
            txtMalzemeAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gbMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMalzemeFiyat).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(233, 294);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(177, 45);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // gbMalzemeEkle
            // 
            gbMalzemeEkle.Controls.Add(nudMalzemeFiyat);
            gbMalzemeEkle.Controls.Add(txtMalzemeAd);
            gbMalzemeEkle.Controls.Add(label2);
            gbMalzemeEkle.Controls.Add(label1);
            gbMalzemeEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbMalzemeEkle.Location = new Point(104, 50);
            gbMalzemeEkle.Margin = new Padding(3, 4, 3, 4);
            gbMalzemeEkle.Name = "gbMalzemeEkle";
            gbMalzemeEkle.Padding = new Padding(3, 4, 3, 4);
            gbMalzemeEkle.Size = new Size(333, 217);
            gbMalzemeEkle.TabIndex = 2;
            gbMalzemeEkle.TabStop = false;
            gbMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            // 
            // nudMalzemeFiyat
            // 
            nudMalzemeFiyat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudMalzemeFiyat.Location = new Point(129, 137);
            nudMalzemeFiyat.Margin = new Padding(3, 4, 3, 4);
            nudMalzemeFiyat.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudMalzemeFiyat.Name = "nudMalzemeFiyat";
            nudMalzemeFiyat.Size = new Size(177, 27);
            nudMalzemeFiyat.TabIndex = 2;
            // 
            // txtMalzemeAd
            // 
            txtMalzemeAd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMalzemeAd.Location = new Point(129, 67);
            txtMalzemeAd.Margin = new Padding(3, 4, 3, 4);
            txtMalzemeAd.Name = "txtMalzemeAd";
            txtMalzemeAd.Size = new Size(177, 27);
            txtMalzemeAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 148);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 0;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 77);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // MalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 379);
            ControlBox = false;
            Controls.Add(btnEkle);
            Controls.Add(gbMalzemeEkle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MalzemeEkle";
            Text = "Ekstra Malzeme Ekle";
            gbMalzemeEkle.ResumeLayout(false);
            gbMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMalzemeFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        private GroupBox gbMalzemeEkle;
        private NumericUpDown nudMalzemeFiyat;
        private TextBox txtMalzemeAd;
        private Label label2;
        private Label label1;
    }
}