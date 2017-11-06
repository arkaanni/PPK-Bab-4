namespace PPK_Bab4_Perpustakaan
{
    partial class PengembalianBuku
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
            this.textBoxIdBuku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKembalikanBuku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIdBuku
            // 
            this.textBoxIdBuku.Location = new System.Drawing.Point(124, 132);
            this.textBoxIdBuku.Name = "textBoxIdBuku";
            this.textBoxIdBuku.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdBuku.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pengembalian Buku";
            // 
            // btnKembalikanBuku
            // 
            this.btnKembalikanBuku.Location = new System.Drawing.Point(88, 194);
            this.btnKembalikanBuku.Name = "btnKembalikanBuku";
            this.btnKembalikanBuku.Size = new System.Drawing.Size(75, 23);
            this.btnKembalikanBuku.TabIndex = 3;
            this.btnKembalikanBuku.Text = "OK";
            this.btnKembalikanBuku.UseVisualStyleBackColor = true;
            this.btnKembalikanBuku.Click += new System.EventHandler(this.btnKembalikanBuku_Click);
            // 
            // PengembalianBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnKembalikanBuku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdBuku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PengembalianBuku";
            this.Text = "PengembalianBuku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdBuku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKembalikanBuku;
    }
}