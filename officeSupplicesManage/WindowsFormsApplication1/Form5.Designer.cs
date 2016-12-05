namespace WindowsFormsApplication1
{
    partial class Form5
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
            System.Windows.Forms.Label supplierLabel;
            System.Windows.Forms.Label leibieLabel;
            System.Windows.Forms.Label shulingLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.officeSuppliesManagementSystemDatabaseDataSet5 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5();
            this.ruKuXinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruKuXinTableAdapter = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.RuKuXinTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.TableAdapterManager();
            this.ruKuXinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.leibieTextBox = new System.Windows.Forms.TextBox();
            this.shulingTextBox = new System.Windows.Forms.TextBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            supplierLabel = new System.Windows.Forms.Label();
            leibieLabel = new System.Windows.Forms.Label();
            shulingLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.BackColor = System.Drawing.Color.Transparent;
            supplierLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            supplierLabel.Location = new System.Drawing.Point(496, 151);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new System.Drawing.Size(80, 16);
            supplierLabel.TabIndex = 4;
            supplierLabel.Text = "供 货 商:";
            // 
            // leibieLabel
            // 
            leibieLabel.AutoSize = true;
            leibieLabel.BackColor = System.Drawing.Color.Transparent;
            leibieLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            leibieLabel.Location = new System.Drawing.Point(496, 199);
            leibieLabel.Name = "leibieLabel";
            leibieLabel.Size = new System.Drawing.Size(80, 16);
            leibieLabel.TabIndex = 5;
            leibieLabel.Text = "类    别:";
            // 
            // shulingLabel
            // 
            shulingLabel.AutoSize = true;
            shulingLabel.BackColor = System.Drawing.Color.Transparent;
            shulingLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            shulingLabel.Location = new System.Drawing.Point(496, 252);
            shulingLabel.Name = "shulingLabel";
            shulingLabel.Size = new System.Drawing.Size(80, 16);
            shulingLabel.TabIndex = 7;
            shulingLabel.Text = "数    量:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.BackColor = System.Drawing.Color.Transparent;
            remarkLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            remarkLabel.Location = new System.Drawing.Point(496, 305);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(80, 16);
            remarkLabel.TabIndex = 9;
            remarkLabel.Text = "备    注:";
            // 
            // officeSuppliesManagementSystemDatabaseDataSet5
            // 
            this.officeSuppliesManagementSystemDatabaseDataSet5.DataSetName = "OfficeSuppliesManagementSystemDatabaseDataSet5";
            this.officeSuppliesManagementSystemDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ruKuXinBindingSource
            // 
            this.ruKuXinBindingSource.DataMember = "RuKuXin";
            this.ruKuXinBindingSource.DataSource = this.officeSuppliesManagementSystemDatabaseDataSet5;
            // 
            // ruKuXinTableAdapter
            // 
            this.ruKuXinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RuKuXinTableAdapter = this.ruKuXinTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ruKuXinDataGridView
            // 
            this.ruKuXinDataGridView.AutoGenerateColumns = false;
            this.ruKuXinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ruKuXinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4});
            this.ruKuXinDataGridView.DataSource = this.ruKuXinBindingSource;
            this.ruKuXinDataGridView.Location = new System.Drawing.Point(12, 132);
            this.ruKuXinDataGridView.Name = "ruKuXinDataGridView";
            this.ruKuXinDataGridView.RowTemplate.Height = 23;
            this.ruKuXinDataGridView.Size = new System.Drawing.Size(442, 224);
            this.ruKuXinDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Supplier";
            this.dataGridViewTextBoxColumn2.HeaderText = "供货商";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Leibie";
            this.dataGridViewTextBoxColumn7.HeaderText = "类别";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Shuling";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "库存剩余量";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn4.HeaderText = "备注";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bindingNavigator1.BackgroundImage")));
            this.bindingNavigator1.BindingSource = this.ruKuXinBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(8);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(741, 39);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(140, 20);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(156, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(602, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(90, 18);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "返回上一级";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Supplier", true));
            this.supplierTextBox.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.supplierTextBox.Location = new System.Drawing.Point(582, 148);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(108, 26);
            this.supplierTextBox.TabIndex = 5;
            // 
            // leibieTextBox
            // 
            this.leibieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Leibie", true));
            this.leibieTextBox.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leibieTextBox.Location = new System.Drawing.Point(582, 195);
            this.leibieTextBox.Name = "leibieTextBox";
            this.leibieTextBox.Size = new System.Drawing.Size(108, 26);
            this.leibieTextBox.TabIndex = 6;
            // 
            // shulingTextBox
            // 
            this.shulingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Shuling", true));
            this.shulingTextBox.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shulingTextBox.Location = new System.Drawing.Point(582, 248);
            this.shulingTextBox.Name = "shulingTextBox";
            this.shulingTextBox.Size = new System.Drawing.Size(108, 26);
            this.shulingTextBox.TabIndex = 8;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Remark", true));
            this.remarkTextBox.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remarkTextBox.Location = new System.Drawing.Point(582, 301);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(108, 26);
            this.remarkTextBox.TabIndex = 10;
            this.remarkTextBox.TextChanged += new System.EventHandler(this.remarkTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(496, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "详细信息:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "库存数量浏览:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(741, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(shulingLabel);
            this.Controls.Add(this.shulingTextBox);
            this.Controls.Add(leibieLabel);
            this.Controls.Add(this.leibieTextBox);
            this.Controls.Add(supplierLabel);
            this.Controls.Add(this.supplierTextBox);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.ruKuXinDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "办公用品库存数量统计";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OfficeSuppliesManagementSystemDatabaseDataSet5 officeSuppliesManagementSystemDatabaseDataSet5;
        private System.Windows.Forms.BindingSource ruKuXinBindingSource;
        private OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.RuKuXinTableAdapter ruKuXinTableAdapter;
        private OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ruKuXinDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.TextBox leibieTextBox;
        private System.Windows.Forms.TextBox shulingTextBox;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}