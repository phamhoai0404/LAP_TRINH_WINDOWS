
namespace bai_1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label masvLabel;
            System.Windows.Forms.Label hotenLabel;
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label dienthoaiLabel;
            System.Windows.Forms.Label malopLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhviendbDataSet = new bai_1.sinhviendbDataSet();
            this.sinhvienTableAdapter = new bai_1.sinhviendbDataSetTableAdapters.sinhvienTableAdapter();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.tableAdapterManager = new bai_1.sinhviendbDataSetTableAdapters.TableAdapterManager();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocMa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            masvLabel = new System.Windows.Forms.Label();
            hotenLabel = new System.Windows.Forms.Label();
            diachiLabel = new System.Windows.Forms.Label();
            dienthoaiLabel = new System.Windows.Forms.Label();
            malopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhviendbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masvLabel
            // 
            masvLabel.AutoSize = true;
            masvLabel.Location = new System.Drawing.Point(279, 89);
            masvLabel.Name = "masvLabel";
            masvLabel.Size = new System.Drawing.Size(103, 20);
            masvLabel.TabIndex = 2;
            masvLabel.Text = "Mã Sinh Viên";
            // 
            // hotenLabel
            // 
            hotenLabel.AutoSize = true;
            hotenLabel.Location = new System.Drawing.Point(279, 145);
            hotenLabel.Name = "hotenLabel";
            hotenLabel.Size = new System.Drawing.Size(61, 20);
            hotenLabel.TabIndex = 4;
            hotenLabel.Text = "Họ Tên";
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(279, 201);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(60, 20);
            diachiLabel.TabIndex = 6;
            diachiLabel.Text = "Địa Chỉ";
            // 
            // dienthoaiLabel
            // 
            dienthoaiLabel.AutoSize = true;
            dienthoaiLabel.Location = new System.Drawing.Point(279, 257);
            dienthoaiLabel.Name = "dienthoaiLabel";
            dienthoaiLabel.Size = new System.Drawing.Size(85, 20);
            dienthoaiLabel.TabIndex = 8;
            dienthoaiLabel.Text = "Điện Thoại";
            // 
            // malopLabel
            // 
            malopLabel.AutoSize = true;
            malopLabel.Location = new System.Drawing.Point(279, 313);
            malopLabel.Name = "malopLabel";
            malopLabel.Size = new System.Drawing.Size(56, 20);
            malopLabel.TabIndex = 10;
            malopLabel.Text = "Mã lớp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.dienthoaiDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sinhvienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(956, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // masvDataGridViewTextBoxColumn
            // 
            this.masvDataGridViewTextBoxColumn.DataPropertyName = "masv";
            this.masvDataGridViewTextBoxColumn.HeaderText = "Mã Sinh Viên";
            this.masvDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.masvDataGridViewTextBoxColumn.Name = "masvDataGridViewTextBoxColumn";
            this.masvDataGridViewTextBoxColumn.ReadOnly = true;
            this.masvDataGridViewTextBoxColumn.Width = 50;
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.hotenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            this.hotenDataGridViewTextBoxColumn.Width = 150;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.Width = 150;
            // 
            // dienthoaiDataGridViewTextBoxColumn
            // 
            this.dienthoaiDataGridViewTextBoxColumn.DataPropertyName = "dienthoai";
            this.dienthoaiDataGridViewTextBoxColumn.HeaderText = "Điện Thoại";
            this.dienthoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dienthoaiDataGridViewTextBoxColumn.Name = "dienthoaiDataGridViewTextBoxColumn";
            this.dienthoaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "malop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.malopDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            this.malopDataGridViewTextBoxColumn.Width = 50;
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "sinhvien";
            this.sinhvienBindingSource.DataSource = this.sinhviendbDataSet;
            // 
            // sinhviendbDataSet
            // 
            this.sinhviendbDataSet.DataSetName = "sinhviendbDataSet";
            this.sinhviendbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(806, 249);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(93, 53);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lophocTableAdapter = null;
            this.tableAdapterManager.sinhvienTableAdapter = this.sinhvienTableAdapter;
            this.tableAdapterManager.UpdateOrder = bai_1.sinhviendbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtMasv
            // 
            this.txtMasv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "masv", true));
            this.txtMasv.Location = new System.Drawing.Point(411, 86);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(212, 26);
            this.txtMasv.TabIndex = 3;
            // 
            // txtHoten
            // 
            this.txtHoten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "hoten", true));
            this.txtHoten.Location = new System.Drawing.Point(411, 142);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(212, 26);
            this.txtHoten.TabIndex = 5;
            // 
            // txtDiachi
            // 
            this.txtDiachi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "diachi", true));
            this.txtDiachi.Location = new System.Drawing.Point(411, 198);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(212, 26);
            this.txtDiachi.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "dienthoai", true));
            this.txtDienThoai.Location = new System.Drawing.Point(411, 254);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(212, 26);
            this.txtDienThoai.TabIndex = 9;
            // 
            // txtMalop
            // 
            this.txtMalop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "malop", true));
            this.txtMalop.Location = new System.Drawing.Point(411, 310);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(212, 26);
            this.txtMalop.TabIndex = 11;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.sinhvienBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1034, 33);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(802, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã lớp";
            // 
            // txtLocMa
            // 
            this.txtLocMa.Location = new System.Drawing.Point(806, 130);
            this.txtLocMa.Name = "txtLocMa";
            this.txtLocMa.Size = new System.Drawing.Size(100, 26);
            this.txtLocMa.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(806, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Lọc Theo Mã Lớp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 787);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLocMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(malopLabel);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(dienthoaiLabel);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(diachiLabel);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(hotenLabel);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(masvLabel);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhviendbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sinhviendbDataSet sinhviendbDataSet;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private sinhviendbDataSetTableAdapters.sinhvienTableAdapter sinhvienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCapNhat;
        private sinhviendbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocMa;
        private System.Windows.Forms.Button button1;
    }
}

