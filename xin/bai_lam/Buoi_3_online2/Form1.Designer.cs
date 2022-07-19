
namespace Buoi_3_online2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radCong = new System.Windows.Forms.RadioButton();
            this.radTru = new System.Windows.Forms.RadioButton();
            this.radNhan = new System.Windows.Forms.RadioButton();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(219, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(219, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết Quả";
            // 
            // radCong
            // 
            this.radCong.AutoSize = true;
            this.radCong.Location = new System.Drawing.Point(280, 215);
            this.radCong.Name = "radCong";
            this.radCong.Size = new System.Drawing.Size(72, 24);
            this.radCong.TabIndex = 3;
            this.radCong.TabStop = true;
            this.radCong.Text = "Cộng";
            this.radCong.UseVisualStyleBackColor = true;
            this.radCong.CheckedChanged += new System.EventHandler(this.radCong_CheckedChanged);
            // 
            // radTru
            // 
            this.radTru.AutoSize = true;
            this.radTru.Location = new System.Drawing.Point(352, 215);
            this.radTru.Name = "radTru";
            this.radTru.Size = new System.Drawing.Size(61, 24);
            this.radTru.TabIndex = 4;
            this.radTru.TabStop = true;
            this.radTru.Text = "Trừ ";
            this.radTru.UseVisualStyleBackColor = true;
            this.radTru.CheckedChanged += new System.EventHandler(this.radTru_CheckedChanged);
            // 
            // radNhan
            // 
            this.radNhan.AutoSize = true;
            this.radNhan.Location = new System.Drawing.Point(413, 215);
            this.radNhan.Name = "radNhan";
            this.radNhan.Size = new System.Drawing.Size(72, 24);
            this.radNhan.TabIndex = 5;
            this.radNhan.TabStop = true;
            this.radNhan.Text = "Nhân";
            this.radNhan.UseVisualStyleBackColor = true;
            this.radNhan.CheckedChanged += new System.EventHandler(this.radNhan_CheckedChanged);
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Location = new System.Drawing.Point(485, 215);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(66, 24);
            this.radChia.TabIndex = 6;
            this.radChia.TabStop = true;
            this.radChia.Text = "Chia";
            this.radChia.UseVisualStyleBackColor = true;
            this.radChia.CheckedChanged += new System.EventHandler(this.radChia_CheckedChanged);
            // 
            // txtSo1
            // 
            this.txtSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo1.Location = new System.Drawing.Point(310, 114);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(139, 28);
            this.txtSo1.TabIndex = 7;
            // 
            // txtSo2
            // 
            this.txtSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo2.Location = new System.Drawing.Point(310, 162);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(139, 28);
            this.txtSo2.TabIndex = 8;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(310, 329);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(211, 28);
            this.txtKetQua.TabIndex = 9;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(310, 264);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(68, 36);
            this.btnTinh.TabIndex = 10;
            this.btnTinh.Text = "Tính ";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(384, 264);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 36);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(339, 389);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(74, 43);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "PHÉP TÍNH ĐƠN GIẢN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(732, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 9);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kết quả đầu tay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(750, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 9);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hoài";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.radChia);
            this.Controls.Add(this.radNhan);
            this.Controls.Add(this.radTru);
            this.Controls.Add(this.radCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Toán";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radCong;
        private System.Windows.Forms.RadioButton radTru;
        private System.Windows.Forms.RadioButton radNhan;
        private System.Windows.Forms.RadioButton radChia;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

