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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoaiDoAn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.cbMaMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDNhom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddNhom = new System.Windows.Forms.Button();
            this.lstViewThanhVienNhom = new System.Windows.Forms.ListView();
            this.txtFindMSSV = new System.Windows.Forms.TextBox();
            this.helptxtFindMSSV = new System.Windows.Forms.HelpProvider();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThanhVienNhom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại đồ án";
            // 
            // cbLoaiDoAn
            // 
            this.cbLoaiDoAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiDoAn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiDoAn.FormattingEnabled = true;
            this.cbLoaiDoAn.Items.AddRange(new object[] {
            "Đồ án môn học",
            "Tiểu luận chuyên ngành",
            "Đồ án tốt nghiệp"});
            this.cbLoaiDoAn.Location = new System.Drawing.Point(199, 40);
            this.cbLoaiDoAn.Name = "cbLoaiDoAn";
            this.cbLoaiDoAn.Size = new System.Drawing.Size(294, 29);
            this.cbLoaiDoAn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhóm";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhom.Location = new System.Drawing.Point(199, 105);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(294, 29);
            this.txtTenNhom.TabIndex = 3;
            // 
            // cbMaMonHoc
            // 
            this.cbMaMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaMonHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaMonHoc.FormattingEnabled = true;
            this.cbMaMonHoc.Location = new System.Drawing.Point(713, 40);
            this.cbMaMonHoc.Name = "cbMaMonHoc";
            this.cbMaMonHoc.Size = new System.Drawing.Size(213, 29);
            this.cbMaMonHoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn học";
            // 
            // cbMaChuyenNganh
            // 
            this.cbMaChuyenNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaChuyenNganh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaChuyenNganh.FormattingEnabled = true;
            this.cbMaChuyenNganh.Location = new System.Drawing.Point(713, 107);
            this.cbMaChuyenNganh.Name = "cbMaChuyenNganh";
            this.cbMaChuyenNganh.Size = new System.Drawing.Size(213, 29);
            this.cbMaChuyenNganh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã chuyên ngành";
            // 
            // txtIDNhom
            // 
            this.txtIDNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNhom.Location = new System.Drawing.Point(713, 179);
            this.txtIDNhom.Name = "txtIDNhom";
            this.txtIDNhom.ReadOnly = true;
            this.txtIDNhom.Size = new System.Drawing.Size(213, 29);
            this.txtIDNhom.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID Nhóm";
            // 
            // btnAddNhom
            // 
            this.btnAddNhom.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNhom.Location = new System.Drawing.Point(792, 497);
            this.btnAddNhom.Name = "btnAddNhom";
            this.btnAddNhom.Size = new System.Drawing.Size(134, 58);
            this.btnAddNhom.TabIndex = 12;
            this.btnAddNhom.Text = "Add";
            this.btnAddNhom.UseVisualStyleBackColor = true;
            this.btnAddNhom.Click += new System.EventHandler(this.btnAddNhom_Click);
            // 
            // lstViewThanhVienNhom
            // 
            this.lstViewThanhVienNhom.AllowDrop = true;
            this.lstViewThanhVienNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewThanhVienNhom.HideSelection = false;
            this.lstViewThanhVienNhom.Location = new System.Drawing.Point(199, 240);
            this.lstViewThanhVienNhom.Name = "lstViewThanhVienNhom";
            this.lstViewThanhVienNhom.Size = new System.Drawing.Size(294, 123);
            this.lstViewThanhVienNhom.TabIndex = 13;
            this.lstViewThanhVienNhom.UseCompatibleStateImageBehavior = false;
            this.lstViewThanhVienNhom.View = System.Windows.Forms.View.Tile;
            this.lstViewThanhVienNhom.Visible = false;
            this.lstViewThanhVienNhom.DoubleClick += new System.EventHandler(this.lstViewThanhVienNhom_DoubleClick);
            // 
            // txtFindMSSV
            // 
            this.txtFindMSSV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindMSSV.Location = new System.Drawing.Point(199, 176);
            this.txtFindMSSV.Name = "txtFindMSSV";
            this.txtFindMSSV.Size = new System.Drawing.Size(174, 29);
            this.txtFindMSSV.TabIndex = 14;
            this.txtFindMSSV.TextChanged += new System.EventHandler(this.txtFindMSSV_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tìm kiếm sinh viên";
            // 
            // txtThanhVienNhom
            // 
            this.txtThanhVienNhom.AllowDrop = true;
            this.txtThanhVienNhom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhVienNhom.Location = new System.Drawing.Point(199, 393);
            this.txtThanhVienNhom.Multiline = true;
            this.txtThanhVienNhom.Name = "txtThanhVienNhom";
            this.txtThanhVienNhom.ReadOnly = true;
            this.txtThanhVienNhom.Size = new System.Drawing.Size(294, 72);
            this.txtThanhVienNhom.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Thành viên nhóm";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddNhomSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 587);
            this.Controls.Add(this.txtThanhVienNhom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFindMSSV);
            this.Controls.Add(this.lstViewThanhVienNhom);
            this.Controls.Add(this.btnAddNhom);
            this.Controls.Add(this.txtIDNhom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMaChuyenNganh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMaMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLoaiDoAn);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddNhomSinhVien";
            this.Text = "Thêm nhóm";
            this.Load += new System.EventHandler(this.FrmAddNhomSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox txtIDNhom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddNhom;
        private System.Windows.Forms.ListView lstViewThanhVienNhom;
        private System.Windows.Forms.TextBox txtFindMSSV;
        private System.Windows.Forms.HelpProvider helptxtFindMSSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThanhVienNhom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}