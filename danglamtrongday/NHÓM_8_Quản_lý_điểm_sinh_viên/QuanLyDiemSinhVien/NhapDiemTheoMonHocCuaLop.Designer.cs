
namespace QuanLyDiemSinhVien
{
    partial class NhapDiemTheoMonHocCuaLop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comLop = new System.Windows.Forms.ComboBox();
            this.combDSMonHoc = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemDiem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comLop);
            this.groupBox1.Controls.Add(this.combDSMonHoc);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(84, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(604, 351);
            this.groupBox1.TabIndex = 1005;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã lớp";
            // 
            // comLop
            // 
            this.comLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comLop.FormattingEnabled = true;
            this.comLop.Location = new System.Drawing.Point(220, 143);
            this.comLop.Name = "comLop";
            this.comLop.Size = new System.Drawing.Size(281, 33);
            this.comLop.TabIndex = 3;
            // 
            // combDSMonHoc
            // 
            this.combDSMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combDSMonHoc.FormattingEnabled = true;
            this.combDSMonHoc.Location = new System.Drawing.Point(220, 72);
            this.combDSMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.combDSMonHoc.Name = "combDSMonHoc";
            this.combDSMonHoc.Size = new System.Drawing.Size(281, 33);
            this.combDSMonHoc.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(317, 239);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 65);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Location = new System.Drawing.Point(126, 239);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 65);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMon,
            this.maSinhVien,
            this.tenSinhVien,
            this.diem});
            this.dataGridView1.Location = new System.Drawing.Point(721, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(663, 646);
            this.dataGridView1.TabIndex = 1006;
            // 
            // maMon
            // 
            this.maMon.HeaderText = "Mã môn học";
            this.maMon.MinimumWidth = 8;
            this.maMon.Name = "maMon";
            this.maMon.ReadOnly = true;
            this.maMon.Width = 150;
            // 
            // maSinhVien
            // 
            this.maSinhVien.HeaderText = "Mã sinh viên";
            this.maSinhVien.MinimumWidth = 8;
            this.maSinhVien.Name = "maSinhVien";
            this.maSinhVien.ReadOnly = true;
            this.maSinhVien.Width = 150;
            // 
            // tenSinhVien
            // 
            this.tenSinhVien.HeaderText = "Tên sinh viên";
            this.tenSinhVien.MinimumWidth = 8;
            this.tenSinhVien.Name = "tenSinhVien";
            this.tenSinhVien.ReadOnly = true;
            this.tenSinhVien.Width = 150;
            // 
            // diem
            // 
            this.diem.HeaderText = "Điểm";
            this.diem.MinimumWidth = 8;
            this.diem.Name = "diem";
            this.diem.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(895, 38);
            this.label3.TabIndex = 1007;
            this.label3.Text = "NHẬP ĐIỂM CHO SINH VIÊN THEO LỚP VÀ MÔN HỌC";
            // 
            // btnThemDiem
            // 
            this.btnThemDiem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemDiem.Location = new System.Drawing.Point(183, 657);
            this.btnThemDiem.Name = "btnThemDiem";
            this.btnThemDiem.Size = new System.Drawing.Size(172, 72);
            this.btnThemDiem.TabIndex = 1008;
            this.btnThemDiem.Text = "Cập nhật";
            this.btnThemDiem.UseVisualStyleBackColor = false;
            this.btnThemDiem.Click += new System.EventHandler(this.btnThemDiem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(421, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 72);
            this.button1.TabIndex = 1009;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NhapDiemTheoMonHocCuaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1467, 919);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThemDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhapDiemTheoMonHocCuaLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapDiemTheoMonHocCuaLop";
            this.Load += new System.EventHandler(this.NhapDiemTheoMonHocCuaLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combDSMonHoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comLop;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.Button button1;
    }
}