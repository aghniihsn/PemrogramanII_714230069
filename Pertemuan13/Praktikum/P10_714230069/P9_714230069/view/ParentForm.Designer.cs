﻿namespace P13_714230069.view
{
    partial class ParentForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataNilaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tugasPraktikumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMasterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataMahasiswaToolStripMenuItem,
            this.dataNilaiToolStripMenuItem,
            this.tugasPraktikumToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataMahasiswaToolStripMenuItem
            // 
            this.dataMahasiswaToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.dataMahasiswaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dataMahasiswaToolStripMenuItem.Name = "dataMahasiswaToolStripMenuItem";
            this.dataMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.dataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa";
            this.dataMahasiswaToolStripMenuItem.Click += new System.EventHandler(this.dataMahasiswaToolStripMenuItem_Click);
            // 
            // dataNilaiToolStripMenuItem
            // 
            this.dataNilaiToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.dataNilaiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dataNilaiToolStripMenuItem.Name = "dataNilaiToolStripMenuItem";
            this.dataNilaiToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.dataNilaiToolStripMenuItem.Text = "Data Nilai";
            this.dataNilaiToolStripMenuItem.Click += new System.EventHandler(this.dataNilaiToolStripMenuItem_Click);
            // 
            // tugasPraktikumToolStripMenuItem
            // 
            this.tugasPraktikumToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.tugasPraktikumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMasterBarangToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem});
            this.tugasPraktikumToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tugasPraktikumToolStripMenuItem.Name = "tugasPraktikumToolStripMenuItem";
            this.tugasPraktikumToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.tugasPraktikumToolStripMenuItem.Text = "Tugas Praktikum 12";
            // 
            // dataMasterBarangToolStripMenuItem
            // 
            this.dataMasterBarangToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.dataMasterBarangToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dataMasterBarangToolStripMenuItem.Name = "dataMasterBarangToolStripMenuItem";
            this.dataMasterBarangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataMasterBarangToolStripMenuItem.Text = "Data Master Barang";
            this.dataMasterBarangToolStripMenuItem.Click += new System.EventHandler(this.dataMasterBarangToolStripMenuItem_Click);
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.BackColor = System.Drawing.Color.Brown;
            this.dataTransaksiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            this.dataTransaksiToolStripMenuItem.Click += new System.EventHandler(this.dataTransaksiToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParentForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataNilaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tugasPraktikumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMasterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
    }
}