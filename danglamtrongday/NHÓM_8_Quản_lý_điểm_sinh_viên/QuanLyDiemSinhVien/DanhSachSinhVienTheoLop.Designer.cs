
namespace QuanLyDiemSinhVien
{
    partial class DanhSachSinhVienTheoLop
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
            this.btnTricXuat_Excel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblHedaotao = new System.Windows.Forms.Label();
            this.lblKhoahoc = new System.Windows.Forms.Label();
            this.lblSiso = new System.Windows.Forms.Label();
            this.lblMalop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comLop = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH SÁCH ĐIỂM SINH VIÊN THEO LỚP";
            // 
            // btnTricXuat_Excel
            // 
            this.btnTricXuat_Excel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTricXuat_Excel.Location = new System.Drawing.Point(550, 798);
            this.btnTricXuat_Excel.Margin = new System.Windows.Forms.Padding(4);
            this.btnTricXuat_Excel.Name = "btnTricXuat_Excel";
            this.btnTricXuat_Excel.Size = new System.Drawing.Size(252, 72);
            this.btnTricXuat_Excel.TabIndex = 6;
            this.btnTricXuat_Excel.Text = "Trích xuất dữ liệu ra Excel";
            this.btnTricXuat_Excel.UseVisualStyleBackColor = false;
            this.btnTricXuat_Excel.Click += new System.EventHandler(this.btnTricXuat_Excel_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(887, 798);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 72);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mã lớp:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblKhoa);
            this.groupBox1.Controls.Add(this.lblHedaotao);
            this.groupBox1.Controls.Add(this.lblKhoahoc);
            this.groupBox1.Controls.Add(this.lblSiso);
            this.groupBox1.Controls.Add(this.lblMalop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(539, 514);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sĩ số: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Khoa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hệ đào tạo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khóa học:";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(228, 399);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(64, 20);
            this.lblKhoa.TabIndex = 7;
            this.lblKhoa.Text = "Mã lớp:";
            // 
            // lblHedaotao
            // 
            this.lblHedaotao.AutoSize = true;
            this.lblHedaotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHedaotao.Location = new System.Drawing.Point(228, 318);
            this.lblHedaotao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHedaotao.Name = "lblHedaotao";
            this.lblHedaotao.Size = new System.Drawing.Size(64, 20);
            this.lblHedaotao.TabIndex = 7;
            this.lblHedaotao.Text = "Mã lớp:";
            // 
            // lblKhoahoc
            // 
            this.lblKhoahoc.AutoSize = true;
            this.lblKhoahoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoahoc.Location = new System.Drawing.Point(228, 236);
            this.lblKhoahoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKhoahoc.Name = "lblKhoahoc";
            this.lblKhoahoc.Size = new System.Drawing.Size(64, 20);
            this.lblKhoahoc.TabIndex = 7;
            this.lblKhoahoc.Text = "Mã lớp:";
            // 
            // lblSiso
            // 
            this.lblSiso.AutoSize = true;
            this.lblSiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiso.Location = new System.Drawing.Point(228, 155);
            this.lblSiso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSiso.Name = "lblSiso";
            this.lblSiso.Size = new System.Drawing.Size(64, 20);
            this.lblSiso.TabIndex = 7;
            this.lblSiso.Text = "Mã lớp:";
            // 
            // lblMalop
            // 
            this.lblMalop.AutoSize = true;
            this.lblMalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalop.Location = new System.Drawing.Point(228, 74);
            this.lblMalop.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMalop.Name = "lblMalop";
            this.lblMalop.Size = new System.Drawing.Size(64, 20);
            this.lblMalop.TabIndex = 7;
            this.lblMalop.Text = "Mã lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã lớp:";
            // 
            // comLop
            // 
            this.comLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comLop.FormattingEnabled = true;
            this.comLop.Location = new System.Drawing.Point(217, 142);
            this.comLop.Margin = new System.Windows.Forms.Padding(4);
            this.comLop.Name = "comLop";
            this.comLop.Size = new System.Drawing.Size(384, 28);
            this.comLop.TabIndex = 10;
            this.comLop.SelectedValueChanged += new System.EventHandler(this.comLop_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(647, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(833, 591);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DanhSachSinhVienTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1545, 896);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comLop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTricXuat_Excel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachSinhVienTheoLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachSinhVienTheoLop";
            this.Load += new System.EventHandler(this.DanhSachSinhVienTheoLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTricXuat_Excel;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblHedaotao;
        private System.Windows.Forms.Label lblKhoahoc;
        private System.Windows.Forms.Label lblSiso;
        private System.Windows.Forms.Label lblMalop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}