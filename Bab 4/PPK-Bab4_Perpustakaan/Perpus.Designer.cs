namespace PPK_Bab4_Perpustakaan
{
    partial class Perpus
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formPinjamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formPengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPeminjamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBukuDipinjamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewBukuDiPinjam = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formPinjamToolStripMenuItem,
            this.formPengembalianToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "File";
            // 
            // formPinjamToolStripMenuItem
            // 
            this.formPinjamToolStripMenuItem.Name = "formPinjamToolStripMenuItem";
            this.formPinjamToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.formPinjamToolStripMenuItem.Text = "Form Pinjam";
            this.formPinjamToolStripMenuItem.Click += new System.EventHandler(this.formPinjamToolStripMenuItem_Click);
            // 
            // formPengembalianToolStripMenuItem
            // 
            this.formPengembalianToolStripMenuItem.Name = "formPengembalianToolStripMenuItem";
            this.formPengembalianToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.formPengembalianToolStripMenuItem.Text = "Form Pengembalian";
            this.formPengembalianToolStripMenuItem.Click += new System.EventHandler(this.formPengembalianToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPeminjamToolStripMenuItem,
            this.dataBukuDipinjamToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // dataPeminjamToolStripMenuItem
            // 
            this.dataPeminjamToolStripMenuItem.Name = "dataPeminjamToolStripMenuItem";
            this.dataPeminjamToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dataPeminjamToolStripMenuItem.Text = "Data Peminjam";
            this.dataPeminjamToolStripMenuItem.Click += new System.EventHandler(this.dataPeminjamToolStripMenuItem_Click);
            // 
            // dataBukuDipinjamToolStripMenuItem
            // 
            this.dataBukuDipinjamToolStripMenuItem.Name = "dataBukuDipinjamToolStripMenuItem";
            this.dataBukuDipinjamToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dataBukuDipinjamToolStripMenuItem.Text = "Data Buku";
            this.dataBukuDipinjamToolStripMenuItem.Click += new System.EventHandler(this.dataBukuDipinjamToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // listViewBukuDiPinjam
            // 
            this.listViewBukuDiPinjam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBukuDiPinjam.Location = new System.Drawing.Point(12, 74);
            this.listViewBukuDiPinjam.Name = "listViewBukuDiPinjam";
            this.listViewBukuDiPinjam.Size = new System.Drawing.Size(766, 375);
            this.listViewBukuDiPinjam.TabIndex = 1;
            this.listViewBukuDiPinjam.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Daftar Buku Dipinjam";
            // 
            // Perpus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewBukuDiPinjam);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Perpus";
            this.Text = "Aplikasi Peminjaman Buku";
            this.Load += new System.EventHandler(this.Perpus_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formPinjamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formPengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPeminjamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBukuDipinjamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ListView listViewBukuDiPinjam;
        private System.Windows.Forms.Label label1;
    }
}

