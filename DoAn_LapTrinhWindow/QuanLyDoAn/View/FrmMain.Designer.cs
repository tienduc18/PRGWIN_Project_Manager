﻿namespace QuanLyDoAn.View
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuanLyDeTai = new System.Windows.Forms.ToolStripMenuItem();
            this.tctTabMain = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSinhVien,
            this.MenuGiangVien,
            this.MenuQuanLyDeTai});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuSinhVien
            // 
            this.MenuSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSinhVien.Name = "MenuSinhVien";
            this.MenuSinhVien.Size = new System.Drawing.Size(102, 27);
            this.MenuSinhVien.Text = "Sinh Viên";
            this.MenuSinhVien.Click += new System.EventHandler(this.MenuSinhVien_Click);
            // 
            // MenuGiangVien
            // 
            this.MenuGiangVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGiangVien.Name = "MenuGiangVien";
            this.MenuGiangVien.Size = new System.Drawing.Size(117, 27);
            this.MenuGiangVien.Text = "Giảng Viên";
            this.MenuGiangVien.Click += new System.EventHandler(this.MenuGiangVien_Click);
            // 
            // MenuQuanLyDeTai
            // 
            this.MenuQuanLyDeTai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuQuanLyDeTai.Name = "MenuQuanLyDeTai";
            this.MenuQuanLyDeTai.Size = new System.Drawing.Size(142, 27);
            this.MenuQuanLyDeTai.Text = "Quản lý đề tài";
            this.MenuQuanLyDeTai.Click += new System.EventHandler(this.MenuQuanLyDeTai_Click);
            // 
            // tctTabMain
            // 
            this.tctTabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tctTabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctTabMain.Location = new System.Drawing.Point(0, 31);
            this.tctTabMain.Name = "tctTabMain";
            this.tctTabMain.SelectedIndex = 0;
            this.tctTabMain.Size = new System.Drawing.Size(1081, 34);
            this.tctTabMain.TabIndex = 6;
            this.tctTabMain.SelectedIndexChanged += new System.EventHandler(this.tctTabMain_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 641);
            this.Controls.Add(this.tctTabMain);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Trang chủ";
            this.MdiChildActivate += new System.EventHandler(this.FrmMain_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem MenuGiangVien;
        private System.Windows.Forms.ToolStripMenuItem MenuQuanLyDeTai;
        private System.Windows.Forms.TabControl tctTabMain;
    }
}



