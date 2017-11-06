namespace PPK_Bab4_Perpustakaan
{
    partial class PeminjamForm
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
            this.listViewPeminjam = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.btnTambahPeminjam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPeminjam
            // 
            this.listViewPeminjam.Location = new System.Drawing.Point(13, 12);
            this.listViewPeminjam.Name = "listViewPeminjam";
            this.listViewPeminjam.Size = new System.Drawing.Size(359, 337);
            this.listViewPeminjam.TabIndex = 0;
            this.listViewPeminjam.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tambah Anggota Peminjam";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(457, 75);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(166, 20);
            this.textBoxNama.TabIndex = 2;
            // 
            // btnTambahPeminjam
            // 
            this.btnTambahPeminjam.Location = new System.Drawing.Point(488, 118);
            this.btnTambahPeminjam.Name = "btnTambahPeminjam";
            this.btnTambahPeminjam.Size = new System.Drawing.Size(75, 23);
            this.btnTambahPeminjam.TabIndex = 3;
            this.btnTambahPeminjam.Text = "Tambah";
            this.btnTambahPeminjam.UseVisualStyleBackColor = true;
            this.btnTambahPeminjam.Click += new System.EventHandler(this.btnTambahPeminjam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // PeminjamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTambahPeminjam);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPeminjam);
            this.MaximizeBox = false;
            this.Name = "PeminjamForm";
            this.Text = "PeminjamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPeminjam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button btnTambahPeminjam;
        private System.Windows.Forms.Label label2;
    }
}