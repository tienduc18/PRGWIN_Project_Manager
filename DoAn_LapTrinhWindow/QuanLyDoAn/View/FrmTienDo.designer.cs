namespace QuanLyDoAn.View
{
    partial class FrmTienDo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtSoBuoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgTienDo = new System.Windows.Forms.DataGridView();
            this.cBuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoiDungBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLinkTaiLieu = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cHoanThanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSoBuoi = new System.Windows.Forms.ComboBox();
            this.rtxtNoiDung = new System.Windows.Forms.RichTextBox();
            this.checkboxHoanTat = new System.Windows.Forms.CheckBox();
            this.txtLinkTaiLieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTienDo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgTienDo);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 478);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtLinkTaiLieu);
            this.splitContainer2.Panel1.Controls.Add(this.checkboxHoanTat);
            this.splitContainer2.Panel1.Controls.Add(this.rtxtNoiDung);
            this.splitContainer2.Panel1.Controls.Add(this.cbSoBuoi);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnFinish);
            this.splitContainer2.Panel2.Controls.Add(this.txtDiem);
            this.splitContainer2.Panel2.Controls.Add(this.txtSoBuoi);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.dtpDateEnd);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.dtpDateStart);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(1053, 238);
            this.splitContainer2.SplitterDistance = 614;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtDiem
            // 
            this.txtDiem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(294, 136);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(71, 26);
            this.txtDiem.TabIndex = 7;
            // 
            // txtSoBuoi
            // 
            this.txtSoBuoi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBuoi.Location = new System.Drawing.Point(105, 138);
            this.txtSoBuoi.Name = "txtSoBuoi";
            this.txtSoBuoi.Size = new System.Drawing.Size(66, 26);
            this.txtSoBuoi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số buổi:";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(144, 79);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(200, 26);
            this.dtpDateEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(144, 31);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(200, 26);
            this.dtpDateStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // dtgTienDo
            // 
            this.dtgTienDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTienDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTienDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBuoi,
            this.cNoiDungBaoCao,
            this.cLinkTaiLieu,
            this.cHoanThanh});
            this.dtgTienDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTienDo.Location = new System.Drawing.Point(0, 0);
            this.dtgTienDo.Name = "dtgTienDo";
            this.dtgTienDo.ReadOnly = true;
            this.dtgTienDo.Size = new System.Drawing.Size(1053, 236);
            this.dtgTienDo.TabIndex = 0;
            // 
            // cBuoi
            // 
            this.cBuoi.HeaderText = "Buổi";
            this.cBuoi.Name = "cBuoi";
            this.cBuoi.ReadOnly = true;
            // 
            // cNoiDungBaoCao
            // 
            this.cNoiDungBaoCao.HeaderText = "Nội dung báo cáo";
            this.cNoiDungBaoCao.Name = "cNoiDungBaoCao";
            this.cNoiDungBaoCao.ReadOnly = true;
            // 
            // cLinkTaiLieu
            // 
            this.cLinkTaiLieu.HeaderText = "Link tài liệu";
            this.cLinkTaiLieu.Name = "cLinkTaiLieu";
            this.cLinkTaiLieu.ReadOnly = true;
            // 
            // cHoanThanh
            // 
            this.cHoanThanh.HeaderText = "Đã báo cáo";
            this.cHoanThanh.Name = "cHoanThanh";
            this.cHoanThanh.ReadOnly = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(131, 187);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(172, 31);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Hoàn tất cập nhật";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buổi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nội dung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Link tài liệu";
            // 
            // cbSoBuoi
            // 
            this.cbSoBuoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoBuoi.FormattingEnabled = true;
            this.cbSoBuoi.Location = new System.Drawing.Point(112, 31);
            this.cbSoBuoi.Name = "cbSoBuoi";
            this.cbSoBuoi.Size = new System.Drawing.Size(121, 27);
            this.cbSoBuoi.TabIndex = 5;
            // 
            // rtxtNoiDung
            // 
            this.rtxtNoiDung.Location = new System.Drawing.Point(114, 92);
            this.rtxtNoiDung.Name = "rtxtNoiDung";
            this.rtxtNoiDung.Size = new System.Drawing.Size(228, 145);
            this.rtxtNoiDung.TabIndex = 6;
            this.rtxtNoiDung.Text = "";
            // 
            // checkboxHoanTat
            // 
            this.checkboxHoanTat.AutoSize = true;
            this.checkboxHoanTat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxHoanTat.Location = new System.Drawing.Point(383, 115);
            this.checkboxHoanTat.Name = "checkboxHoanTat";
            this.checkboxHoanTat.Size = new System.Drawing.Size(92, 23);
            this.checkboxHoanTat.TabIndex = 7;
            this.checkboxHoanTat.Text = "Hoàn tất";
            this.checkboxHoanTat.UseVisualStyleBackColor = true;
            this.checkboxHoanTat.CheckedChanged += new System.EventHandler(this.checkboxHoanTat_CheckedChanged);
            // 
            // txtLinkTaiLieu
            // 
            this.txtLinkTaiLieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkTaiLieu.Location = new System.Drawing.Point(481, 32);
            this.txtLinkTaiLieu.Multiline = true;
            this.txtLinkTaiLieu.Name = "txtLinkTaiLieu";
            this.txtLinkTaiLieu.Size = new System.Drawing.Size(121, 52);
            this.txtLinkTaiLieu.TabIndex = 8;
            // 
            // FrmTienDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 478);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmTienDo";
            this.Text = "FrmTienDo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTienDo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtSoBuoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgTienDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDungBaoCao;
        private System.Windows.Forms.DataGridViewLinkColumn cLinkTaiLieu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cHoanThanh;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ComboBox cbSoBuoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLinkTaiLieu;
        private System.Windows.Forms.CheckBox checkboxHoanTat;
        private System.Windows.Forms.RichTextBox rtxtNoiDung;
    }
}