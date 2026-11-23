namespace ToplamaÇarpma
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
            this.İşlemler = new System.Windows.Forms.GroupBox();
            this.RBtnToplama = new System.Windows.Forms.RadioButton();
            this.RBtnCarpma = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.Btnİslem = new System.Windows.Forms.Button();
            this.RBtnCıkarma = new System.Windows.Forms.RadioButton();
            this.RBtnBölme = new System.Windows.Forms.RadioButton();
            this.İşlemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // İşlemler
            // 
            this.İşlemler.Controls.Add(this.RBtnBölme);
            this.İşlemler.Controls.Add(this.RBtnCıkarma);
            this.İşlemler.Controls.Add(this.RBtnCarpma);
            this.İşlemler.Controls.Add(this.RBtnToplama);
            this.İşlemler.Location = new System.Drawing.Point(34, 33);
            this.İşlemler.Name = "İşlemler";
            this.İşlemler.Size = new System.Drawing.Size(333, 88);
            this.İşlemler.TabIndex = 0;
            this.İşlemler.TabStop = false;
            this.İşlemler.Text = "İşlemler";
            // 
            // RBtnToplama
            // 
            this.RBtnToplama.AutoSize = true;
            this.RBtnToplama.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnToplama.Location = new System.Drawing.Point(8, 19);
            this.RBtnToplama.Name = "RBtnToplama";
            this.RBtnToplama.Size = new System.Drawing.Size(104, 17);
            this.RBtnToplama.TabIndex = 0;
            this.RBtnToplama.TabStop = true;
            this.RBtnToplama.Text = "Toplama İşlemi";
            this.RBtnToplama.UseVisualStyleBackColor = true;
            // 
            // RBtnCarpma
            // 
            this.RBtnCarpma.AutoSize = true;
            this.RBtnCarpma.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCarpma.Location = new System.Drawing.Point(199, 19);
            this.RBtnCarpma.Name = "RBtnCarpma";
            this.RBtnCarpma.Size = new System.Drawing.Size(100, 17);
            this.RBtnCarpma.TabIndex = 0;
            this.RBtnCarpma.TabStop = true;
            this.RBtnCarpma.Text = "Çarpma İşlemi";
            this.RBtnCarpma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Sayıyı Giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Sayıyı Giriniz :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sonuç :";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(230, 229);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 25);
            this.lblSonuc.TabIndex = 1;
            // 
            // Btnİslem
            // 
            this.Btnİslem.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnİslem.Location = new System.Drawing.Point(98, 283);
            this.Btnİslem.Name = "Btnİslem";
            this.Btnİslem.Size = new System.Drawing.Size(190, 28);
            this.Btnİslem.TabIndex = 3;
            this.Btnİslem.Text = "İşlemi Yap";
            this.Btnİslem.UseVisualStyleBackColor = true;
            this.Btnİslem.Click += new System.EventHandler(this.Btnİslem_Click);
            // 
            // RBtnCıkarma
            // 
            this.RBtnCıkarma.AutoSize = true;
            this.RBtnCıkarma.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnCıkarma.Location = new System.Drawing.Point(8, 54);
            this.RBtnCıkarma.Name = "RBtnCıkarma";
            this.RBtnCıkarma.Size = new System.Drawing.Size(102, 17);
            this.RBtnCıkarma.TabIndex = 0;
            this.RBtnCıkarma.TabStop = true;
            this.RBtnCıkarma.Text = "Çıkarma İşlemi";
            this.RBtnCıkarma.UseVisualStyleBackColor = true;
            // 
            // RBtnBölme
            // 
            this.RBtnBölme.AutoSize = true;
            this.RBtnBölme.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnBölme.Location = new System.Drawing.Point(199, 54);
            this.RBtnBölme.Name = "RBtnBölme";
            this.RBtnBölme.Size = new System.Drawing.Size(93, 17);
            this.RBtnBölme.TabIndex = 0;
            this.RBtnBölme.TabStop = true;
            this.RBtnBölme.Text = "Bölme İşlemi";
            this.RBtnBölme.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 603);
            this.Controls.Add(this.Btnİslem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.İşlemler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.İşlemler.ResumeLayout(false);
            this.İşlemler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox İşlemler;
        private System.Windows.Forms.RadioButton RBtnCarpma;
        private System.Windows.Forms.RadioButton RBtnToplama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBtnBölme;
        private System.Windows.Forms.RadioButton RBtnCıkarma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button Btnİslem;
    }
}

