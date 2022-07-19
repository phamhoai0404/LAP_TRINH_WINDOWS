
namespace bai_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label masvLabel;
            System.Windows.Forms.Label hotenLabel;
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label dienthoaiLabel;
            System.Windows.Forms.Label malopLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhviendbDataSet1 = new bai_1.sinhviendbDataSet1();
            this.sinhvienTableAdapter = new bai_1.sinhviendbDataSet1TableAdapters.sinhvienTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableAdapterManager = new bai_1.sinhviendbDataSet1TableAdapters.TableAdapterManager();
            this.masvTextBox = new System.Windows.Forms.TextBox();
            this.hotenTextBox = new System.Windows.Forms.TextBox();
            this.diachiTextBox = new System.Windows.Forms.TextBox();
            this.dienthoaiTextBox = new System.Windows.Forms.TextBox();
            this.malopTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.masvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            masvLabel = new System.Windows.Forms.Label();
            hotenLabel = new System.Windows.Forms.Label();
            diachiLabel = new System.Windows.Forms.Label();
            dienthoaiLabel = new System.Windows.Forms.Label();
            malopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhviendbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.dienthoaiDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sinhvienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(105, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "sinhvien";
            this.sinhvienBindingSource.DataSource = this.sinhviendbDataSet1;
            // 
            // sinhviendbDataSet1
            // 
            this.sinhviendbDataSet1.DataSetName = "sinhviendbDataSet1";
            this.sinhviendbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cập Nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1155, 33);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sinhvienTableAdapter = this.sinhvienTableAdapter;
            this.tableAdapterManager.UpdateOrder = bai_1.sinhviendbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // masvLabel
            // 
            masvLabel.AutoSize = true;
            masvLabel.Location = new System.Drawing.Point(309, 69);
            masvLabel.Name = "masvLabel";
            masvLabel.Size = new System.Drawing.Size(50, 20);
            masvLabel.TabIndex = 3;
            masvLabel.Text = "masv:";
            // 
            // masvTextBox
            // 
            this.masvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "masv", true));
            this.masvTextBox.Location = new System.Drawing.Point(439, 69);
            this.masvTextBox.Name = "masvTextBox";
            this.masvTextBox.Size = new System.Drawing.Size(100, 26);
            this.masvTextBox.TabIndex = 4;
            // 
            // hotenLabel
            // 
            hotenLabel.AutoSize = true;
            hotenLabel.Location = new System.Drawing.Point(309, 117);
            hotenLabel.Name = "hotenLabel";
            hotenLabel.Size = new System.Drawing.Size(54, 20);
            hotenLabel.TabIndex = 5;
            hotenLabel.Text = "hoten:";
            // 
            // hotenTextBox
            // 
            this.hotenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "hoten", true));
            this.hotenTextBox.Location = new System.Drawing.Point(439, 117);
            this.hotenTextBox.Name = "hotenTextBox";
            this.hotenTextBox.Size = new System.Drawing.Size(100, 26);
            this.hotenTextBox.TabIndex = 6;
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(309, 165);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(54, 20);
            diachiLabel.TabIndex = 7;
            diachiLabel.Text = "diachi:";
            // 
            // diachiTextBox
            // 
            this.diachiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "diachi", true));
            this.diachiTextBox.Location = new System.Drawing.Point(439, 165);
            this.diachiTextBox.Name = "diachiTextBox";
            this.diachiTextBox.Size = new System.Drawing.Size(100, 26);
            this.diachiTextBox.TabIndex = 8;
            // 
            // dienthoaiLabel
            // 
            dienthoaiLabel.AutoSize = true;
            dienthoaiLabel.Location = new System.Drawing.Point(309, 213);
            dienthoaiLabel.Name = "dienthoaiLabel";
            dienthoaiLabel.Size = new System.Drawing.Size(78, 20);
            dienthoaiLabel.TabIndex = 9;
            dienthoaiLabel.Text = "dienthoai:";
            // 
            // dienthoaiTextBox
            // 
            this.dienthoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "dienthoai", true));
            this.dienthoaiTextBox.Location = new System.Drawing.Point(439, 213);
            this.dienthoaiTextBox.Name = "dienthoaiTextBox";
            this.dienthoaiTextBox.Size = new System.Drawing.Size(100, 26);
            this.dienthoaiTextBox.TabIndex = 10;
            // 
            // malopLabel
            // 
            malopLabel.AutoSize = true;
            malopLabel.Location = new System.Drawing.Point(309, 261);
            malopLabel.Name = "malopLabel";
            malopLabel.Size = new System.Drawing.Size(56, 20);
            malopLabel.TabIndex = 11;
            malopLabel.Text = "malop:";
            // 
            // malopTextBox
            // 
            this.malopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhvienBindingSource, "malop", true));
            this.malopTextBox.Location = new System.Drawing.Point(439, 261);
            this.malopTextBox.Name = "malopTextBox";
            this.malopTextBox.Size = new System.Drawing.Size(100, 26);
            this.malopTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 71);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(765, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 15;
            // 
            // masvDataGridViewTextBoxColumn
            // 
            this.masvDataGridViewTextBoxColumn.DataPropertyName = "masv";
            this.masvDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            this.masvDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.masvDataGridViewTextBoxColumn.Name = "masvDataGridViewTextBoxColumn";
            this.masvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "hoten";
            this.hotenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "diachi";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // dienthoaiDataGridViewTextBoxColumn
            // 
            this.dienthoaiDataGridViewTextBoxColumn.DataPropertyName = "dienthoai";
            this.dienthoaiDataGridViewTextBoxColumn.HeaderText = "dienthoai";
            this.dienthoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dienthoaiDataGridViewTextBoxColumn.Name = "dienthoaiDataGridViewTextBoxColumn";
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "malop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "malop";
            this.malopDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 485);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(malopLabel);
            this.Controls.Add(this.malopTextBox);
            this.Controls.Add(dienthoaiLabel);
            this.Controls.Add(this.dienthoaiTextBox);
            this.Controls.Add(diachiLabel);
            this.Controls.Add(this.diachiTextBox);
            this.Controls.Add(hotenLabel);
            this.Controls.Add(this.hotenTextBox);
            this.Controls.Add(masvLabel);
            this.Controls.Add(this.masvTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhviendbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sinhviendbDataSet1 sinhviendbDataSet1;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private sinhviendbDataSet1TableAdapters.sinhvienTableAdapter sinhvienTableAdapter;
        private System.Windows.Forms.Button button1;
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
        private sinhviendbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox masvTextBox;
        private System.Windows.Forms.TextBox hotenTextBox;
        private System.Windows.Forms.TextBox diachiTextBox;
        private System.Windows.Forms.TextBox dienthoaiTextBox;
        private System.Windows.Forms.TextBox malopTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
    }
}