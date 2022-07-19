
namespace QuanLyDiemSinhVien
{
    partial class TimKiemSinhVien
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
            this.comMaSV = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comLop = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comKhoaQuanLy = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comMaSV
            // 
            this.comMaSV.FormattingEnabled = true;
            this.comMaSV.Location = new System.Drawing.Point(341, 303);
            this.comMaSV.Name = "comMaSV";
            this.comMaSV.Size = new System.Drawing.Size(242, 33);
            this.comMaSV.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(177, 303);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 25);
            this.label21.TabIndex = 6;
            this.label21.Text = "Mã Sinh Viên";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(177, 231);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 25);
            this.label20.TabIndex = 7;
            this.label20.Text = "Lớp";
            // 
            // comLop
            // 
            this.comLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comLop.FormattingEnabled = true;
            this.comLop.Location = new System.Drawing.Point(341, 227);
            this.comLop.Name = "comLop";
            this.comLop.Size = new System.Drawing.Size(242, 33);
            this.comLop.TabIndex = 10;
            this.comLop.SelectedValueChanged += new System.EventHandler(this.comLop_SelectedValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(177, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 25);
            this.label18.TabIndex = 8;
            this.label18.Text = "Khoa Quản Lý";
            // 
            // comKhoaQuanLy
            // 
            this.comKhoaQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comKhoaQuanLy.FormattingEnabled = true;
            this.comKhoaQuanLy.Location = new System.Drawing.Point(341, 157);
            this.comKhoaQuanLy.Name = "comKhoaQuanLy";
            this.comKhoaQuanLy.Size = new System.Drawing.Size(242, 33);
            this.comKhoaQuanLy.TabIndex = 9;
            this.comKhoaQuanLy.SelectedValueChanged += new System.EventHandler(this.comKhoaQuanLy_SelectedValueChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Location = new System.Drawing.Point(167, 398);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 56);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(341, 398);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 56);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "TÌM KIẾM SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(525, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 56);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TimKiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(748, 516);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.comMaSV);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comLop);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comKhoaQuanLy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimKiemSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimKiemSinhVien";
            this.Load += new System.EventHandler(this.TimKiemSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comMaSV;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comLop;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comKhoaQuanLy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}