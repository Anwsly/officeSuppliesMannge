namespace WindowsFormsApplication1
{
    partial class Form7
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
            System.Windows.Forms.Label leibieLabel;
            System.Windows.Forms.Label invoiceNumberLabel;
            System.Windows.Forms.Label supplierLabel;
            System.Windows.Forms.Label shulingLabel;
            System.Windows.Forms.Label danjiaLabel;
            System.Windows.Forms.Label zongjineLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.officeSuppliesManagementSystemDatabaseDataSet5 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5();
            this.ruKuXinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruKuXinTableAdapter = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.RuKuXinTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.TableAdapterManager();
            this.ruKuXinBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ruKuXinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leibieTextBox = new System.Windows.Forms.TextBox();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.shulingTextBox = new System.Windows.Forms.TextBox();
            this.danjiaTextBox = new System.Windows.Forms.TextBox();
            this.zongjineTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            leibieLabel = new System.Windows.Forms.Label();
            invoiceNumberLabel = new System.Windows.Forms.Label();
            supplierLabel = new System.Windows.Forms.Label();
            shulingLabel = new System.Windows.Forms.Label();
            danjiaLabel = new System.Windows.Forms.Label();
            zongjineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingNavigator)).BeginInit();
            this.ruKuXinBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leibieLabel
            // 
            leibieLabel.AutoSize = true;
            leibieLabel.BackColor = System.Drawing.Color.Transparent;
            leibieLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            leibieLabel.Location = new System.Drawing.Point(591, 131);
            leibieLabel.Name = "leibieLabel";
            leibieLabel.Size = new System.Drawing.Size(80, 16);
            leibieLabel.TabIndex = 3;
            leibieLabel.Text = "类    别:";
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.BackColor = System.Drawing.Color.Transparent;
            invoiceNumberLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            invoiceNumberLabel.Location = new System.Drawing.Point(591, 172);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(80, 16);
            invoiceNumberLabel.TabIndex = 5;
            invoiceNumberLabel.Text = "发票编号:";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.BackColor = System.Drawing.Color.Transparent;
            supplierLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            supplierLabel.Location = new System.Drawing.Point(591, 213);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new System.Drawing.Size(80, 16);
            supplierLabel.TabIndex = 7;
            supplierLabel.Text = "供 货 商:";
            // 
            // shulingLabel
            // 
            shulingLabel.AutoSize = true;
            shulingLabel.BackColor = System.Drawing.Color.Transparent;
            shulingLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            shulingLabel.Location = new System.Drawing.Point(591, 254);
            shulingLabel.Name = "shulingLabel";
            shulingLabel.Size = new System.Drawing.Size(80, 16);
            shulingLabel.TabIndex = 9;
            shulingLabel.Text = "数    量:";
            // 
            // danjiaLabel
            // 
            danjiaLabel.AutoSize = true;
            danjiaLabel.BackColor = System.Drawing.Color.Transparent;
            danjiaLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            danjiaLabel.Location = new System.Drawing.Point(591, 295);
            danjiaLabel.Name = "danjiaLabel";
            danjiaLabel.Size = new System.Drawing.Size(80, 16);
            danjiaLabel.TabIndex = 11;
            danjiaLabel.Text = "单    价:";
            // 
            // zongjineLabel
            // 
            zongjineLabel.AutoSize = true;
            zongjineLabel.BackColor = System.Drawing.Color.Transparent;
            zongjineLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            zongjineLabel.Location = new System.Drawing.Point(591, 336);
            zongjineLabel.Name = "zongjineLabel";
            zongjineLabel.Size = new System.Drawing.Size(80, 16);
            zongjineLabel.TabIndex = 13;
            zongjineLabel.Text = "总 金 额:";
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
            // ruKuXinBindingNavigator
            // 
            this.ruKuXinBindingNavigator.AddNewItem = null;
            this.ruKuXinBindingNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ruKuXinBindingNavigator.BackgroundImage")));
            this.ruKuXinBindingNavigator.BindingSource = this.ruKuXinBindingSource;
            this.ruKuXinBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ruKuXinBindingNavigator.DeleteItem = null;
            this.ruKuXinBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.ruKuXinBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ruKuXinBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ruKuXinBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ruKuXinBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ruKuXinBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ruKuXinBindingNavigator.Name = "ruKuXinBindingNavigator";
            this.ruKuXinBindingNavigator.Padding = new System.Windows.Forms.Padding(8);
            this.ruKuXinBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ruKuXinBindingNavigator.Size = new System.Drawing.Size(840, 39);
            this.ruKuXinBindingNavigator.TabIndex = 1;
            this.ruKuXinBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 20);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.bindingNavigatorMoveLastItem.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            // ruKuXinDataGridView
            // 
            this.ruKuXinDataGridView.AutoGenerateColumns = false;
            this.ruKuXinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ruKuXinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ruKuXinDataGridView.DataSource = this.ruKuXinBindingSource;
            this.ruKuXinDataGridView.Location = new System.Drawing.Point(12, 127);
            this.ruKuXinDataGridView.Name = "ruKuXinDataGridView";
            this.ruKuXinDataGridView.RowTemplate.Height = 23;
            this.ruKuXinDataGridView.Size = new System.Drawing.Size(561, 235);
            this.ruKuXinDataGridView.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn6.HeaderText = "数量";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Danjia";
            this.dataGridViewTextBoxColumn8.HeaderText = "单价";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Zongjine";
            this.dataGridViewTextBoxColumn9.HeaderText = "总金额";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Supplier";
            this.dataGridViewTextBoxColumn2.HeaderText = "供货商";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "InvoiceNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "发票编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn4.HeaderText = "备注";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // leibieTextBox
            // 
            this.leibieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Leibie", true));
            this.leibieTextBox.Location = new System.Drawing.Point(677, 130);
            this.leibieTextBox.Name = "leibieTextBox";
            this.leibieTextBox.Size = new System.Drawing.Size(114, 21);
            this.leibieTextBox.TabIndex = 4;
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "InvoiceNumber", true));
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(677, 172);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(114, 21);
            this.invoiceNumberTextBox.TabIndex = 6;
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Supplier", true));
            this.supplierTextBox.Location = new System.Drawing.Point(677, 213);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(114, 21);
            this.supplierTextBox.TabIndex = 8;
            // 
            // shulingTextBox
            // 
            this.shulingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Shuling", true));
            this.shulingTextBox.Location = new System.Drawing.Point(677, 254);
            this.shulingTextBox.Name = "shulingTextBox";
            this.shulingTextBox.Size = new System.Drawing.Size(114, 21);
            this.shulingTextBox.TabIndex = 10;
            // 
            // danjiaTextBox
            // 
            this.danjiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Danjia", true));
            this.danjiaTextBox.Location = new System.Drawing.Point(677, 295);
            this.danjiaTextBox.Name = "danjiaTextBox";
            this.danjiaTextBox.Size = new System.Drawing.Size(114, 21);
            this.danjiaTextBox.TabIndex = 12;
            // 
            // zongjineTextBox
            // 
            this.zongjineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.zongjineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Zongjine", true));
            this.zongjineTextBox.Location = new System.Drawing.Point(677, 336);
            this.zongjineTextBox.Name = "zongjineTextBox";
            this.zongjineTextBox.Size = new System.Drawing.Size(114, 21);
            this.zongjineTextBox.TabIndex = 14;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(703, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(90, 18);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "返回上一级";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "金额统计信息浏览:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(591, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "详细信息:";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(zongjineLabel);
            this.Controls.Add(this.zongjineTextBox);
            this.Controls.Add(danjiaLabel);
            this.Controls.Add(this.danjiaTextBox);
            this.Controls.Add(shulingLabel);
            this.Controls.Add(this.shulingTextBox);
            this.Controls.Add(supplierLabel);
            this.Controls.Add(this.supplierTextBox);
            this.Controls.Add(invoiceNumberLabel);
            this.Controls.Add(this.invoiceNumberTextBox);
            this.Controls.Add(leibieLabel);
            this.Controls.Add(this.leibieTextBox);
            this.Controls.Add(this.ruKuXinDataGridView);
            this.Controls.Add(this.ruKuXinBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "金额统计";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingNavigator)).EndInit();
            this.ruKuXinBindingNavigator.ResumeLayout(false);
            this.ruKuXinBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OfficeSuppliesManagementSystemDatabaseDataSet5 officeSuppliesManagementSystemDatabaseDataSet5;
        private System.Windows.Forms.BindingSource ruKuXinBindingSource;
        private OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.RuKuXinTableAdapter ruKuXinTableAdapter;
        private OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ruKuXinBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView ruKuXinDataGridView;
        private System.Windows.Forms.TextBox leibieTextBox;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.TextBox shulingTextBox;
        private System.Windows.Forms.TextBox danjiaTextBox;
        private System.Windows.Forms.TextBox zongjineTextBox;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}