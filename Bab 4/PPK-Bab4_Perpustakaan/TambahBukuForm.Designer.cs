namespace PPK_Bab4_Perpustakaan
{
    partial class TambahBukuForm
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
            this.textBoxJudulBuku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPenerbitBuku = new System.Windows.Forms.TextBox();
            this.textBoxAuthorBuku = new System.Windows.Forms.TextBox();
            this.btnTambahBuku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxJudulBuku
            // 
            this.textBoxJudulBuku.Location = new System.Drawing.Point(76, 39);
            this.textBoxJudulBuku.Name = "textBoxJudulBuku";
            this.textBoxJudulBuku.Size = new System.Drawing.Size(196, 20);
            this.textBoxJudulBuku.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Judul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Penerbit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author";
            // 
            // textBoxPenerbitBuku
            // 
            this.textBoxPenerbitBuku.Location = new System.Drawing.Point(76, 84);
            this.textBoxPenerbitBuku.Name = "textBoxPenerbitBuku";
            this.textBoxPenerbitBuku.Size = new System.Drawing.Size(196, 20);
            this.textBoxPenerbitBuku.TabIndex = 4;
            // 
            // textBoxAuthorBuku
            // 
            this.textBoxAuthorBuku.Location = new System.Drawing.Point(76, 128);
            this.textBoxAuthorBuku.Name = "textBoxAuthorBuku";
            this.textBoxAuthorBuku.Size = new System.Drawing.Size(196, 20);
            this.textBoxAuthorBuku.TabIndex = 5;
            // 
            // btnTambahBuku
            // 
            this.btnTambahBuku.Location = new System.Drawing.Point(104, 191);
            this.btnTambahBuku.Name = "btnTambahBuku";
            this.btnTambahBuku.Size = new System.Drawing.Size(75, 23);
            this.btnTambahBuku.TabIndex = 6;
            this.btnTambahBuku.Text = "Tambah";
            this.btnTambahBuku.UseVisualStyleBackColor = true;
            this.btnTambahBuku.Click += new System.EventHandler(this.btnTambahBuku_Click);
            // 
            // TambahBukuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnTambahBuku);
            this.Controls.Add(this.textBoxAuthorBuku);
            this.Controls.Add(this.textBoxPenerbitBuku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJudulBuku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TambahBukuForm";
            this.Text = "TambahBukuForm";
            this.Load += new System.EventHandler(this.TambahBukuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxJudulBuku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPenerbitBuku;
        private System.Windows.Forms.TextBox textBoxAuthorBuku;
        private System.Windows.Forms.Button btnTambahBuku;
    }
}