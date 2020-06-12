namespace QuanLyDoAn.View
{
    partial class FrmAddNhomSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoaiDoAn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.cbMaMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhVienNhom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDNhom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddNhom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại đồ án";
            // 
            // cbLoaiDoAn
            // 
            this.cbLoaiDoAn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiDoAn.FormattingEnabled = true;
            this.cbLoaiDoAn.Items.AddRange(new object[] {
            "Đồ án môn học",
            "Tiểu luận chuyên ngành",
            "Đồ án tốt nghiệp"});
            this.cbLoaiDoAn.Location = new System.Drawing.Point(199, 40);
            this.cbLoaiDoAn.Name = "cbLoaiDoAn";
            this.cbLoaiDoAn.Size = new System.Drawing.Size(163, 30);
            this.cbLoaiDoAn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhóm";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhom.Location = new System.Drawing.Point(199, 105);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(212, 29);
            this.txtTenNhom.TabIndex = 3;
            // 
            // cbMaMonHoc
            // 
            this.cbMaMonHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaMonHoc.FormattingEnabled = true;
            this.cbMaMonHoc.Location = new System.Drawing.Point(743, 37);
            this.cbMaMonHoc.Name = "cbMaMonHoc";
            this.cbMaMonHoc.Size = new System.Drawing.Size(163, 30);
            this.cbMaMonHoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn học";
            // 
            // cbMaChuyenNganh
            // 
            this.cbMaChuyenNganh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaChuyenNganh.FormattingEnabled = true;
            this.cbMaChuyenNganh.Location = new System.Drawing.Point(743, 104);
            this.cbMaChuyenNganh.Name = "cbMaChuyenNganh";
            this.cbMaChuyenNganh.Size = new System.Drawing.Size(163, 30);
            this.cbMaChuyenNganh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã chuyên ngành";
            // 
            // txtThanhVienNhom
            // 
            this.txtThanhVienNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhVienNhom.Location = new System.Drawing.Point(199, 176);
            this.txtThanhVienNhom.Name = "txtThanhVienNhom";
            this.txtThanhVienNhom.Size = new System.Drawing.Size(247, 29);
            this.txtThanhVienNhom.TabIndex = 9;
            this.txtThanhVienNhom.Text = "(MSSV1,MSSV2,MSSV3,...)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thành viên nhóm";
            // 
            // txtIDNhom
            // 
            this.txtIDNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNhom.Location = new System.Drawing.Point(743, 176);
            this.txtIDNhom.Name = "txtIDNhom";
            this.txtIDNhom.Size = new System.Drawing.Size(163, 29);
            this.txtIDNhom.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID Nhóm";
            // 
            // btnAddNhom
            // 
            this.btnAddNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNhom.Location = new System.Drawing.Point(743, 278);
            this.btnAddNhom.Name = "btnAddNhom";
            this.btnAddNhom.Size = new System.Drawing.Size(134, 41);
            this.btnAddNhom.TabIndex = 12;
            this.btnAddNhom.Text = "Add";
            this.btnAddNhom.UseVisualStyleBackColor = true;
            this.btnAddNhom.Click += new System.EventHandler(this.btnAddNhom_Click);
            // 
            // FrmAddNhomSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.btnAddNhom);
            this.Controls.Add(this.txtIDNhom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtThanhVienNhom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMaChuyenNganh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMaMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLoaiDoAn);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddNhomSinhVien";
            this.Text = "FrmAddNhomSinhVien";
            this.Load += new System.EventHandler(this.FrmAddNhomSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiDoAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.ComboBox cbMaMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaChuyenNganh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhVienNhom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDNhom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddNhom;
    }
}