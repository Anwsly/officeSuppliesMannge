namespace WindowsFormsApplication1
{
    partial class Form3
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label supplierLabel;
            System.Windows.Forms.Label invoiceNumberLabel;
            System.Windows.Forms.Label lingquRLabel;
            System.Windows.Forms.Label shulingLabel;
            System.Windows.Forms.Label leibieLabel;
            System.Windows.Forms.Label remarkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ruKuXinTableAdapter1 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.RuKuXinTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.TableAdapterManager();
            this.officeSuppliesManagementSystemDatabaseDataSet5 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5();
            this.ruKuXinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruKuXinDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.lingquRTextBox = new System.Windows.Forms.TextBox();
            this.shulingTextBox = new System.Windows.Forms.TextBox();
            this.leibieTextBox = new System.Windows.Forms.TextBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.ruKuXinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            supplierLabel = new System.Windows.Forms.Label();
            invoiceNumberLabel = new System.Windows.Forms.Label();
            lingquRLabel = new System.Windows.Forms.Label();
            shulingLabel = new System.Windows.Forms.Label();
            leibieLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = System.Drawing.Color.Transparent;
            dateLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dateLabel.Location = new System.Drawing.Point(637, 137);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(80, 16);
            dateLabel.TabIndex = 15;
            dateLabel.Text = "入库日期:";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.BackColor = System.Drawing.Color.Transparent;
            supplierLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            supplierLabel.Location = new System.Drawing.Point(637, 164);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new System.Drawing.Size(80, 16);
            supplierLabel.TabIndex = 16;
            supplierLabel.Text = "供 货 商:";
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.BackColor = System.Drawing.Color.Transparent;
            invoiceNumberLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            invoiceNumberLabel.Location = new System.Drawing.Point(637, 191);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(80, 16);
            invoiceNumberLabel.TabIndex = 17;
            invoiceNumberLabel.Text = "发票编号:";
            // 
            // lingquRLabel
            // 
            lingquRLabel.AutoSize = true;
            lingquRLabel.BackColor = System.Drawing.Color.Transparent;
            lingquRLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lingquRLabel.Location = new System.Drawing.Point(637, 218);
            lingquRLabel.Name = "lingquRLabel";
            lingquRLabel.Size = new System.Drawing.Size(80, 16);
            lingquRLabel.TabIndex = 18;
            lingquRLabel.Text = "领 取 人:";
            // 
            // shulingLabel
            // 
            shulingLabel.AutoSize = true;
            shulingLabel.BackColor = System.Drawing.Color.Transparent;
            shulingLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            shulingLabel.Location = new System.Drawing.Point(637, 248);
            shulingLabel.Name = "shulingLabel";
            shulingLabel.Size = new System.Drawing.Size(80, 16);
            shulingLabel.TabIndex = 19;
            shulingLabel.Text = "数    量:";
            // 
            // leibieLabel
            // 
            leibieLabel.AutoSize = true;
            leibieLabel.BackColor = System.Drawing.Color.Transparent;
            leibieLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            leibieLabel.Location = new System.Drawing.Point(637, 275);
            leibieLabel.Name = "leibieLabel";
            leibieLabel.Size = new System.Drawing.Size(80, 16);
            leibieLabel.TabIndex = 20;
            leibieLabel.Text = "类    别:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.BackColor = System.Drawing.Color.Transparent;
            remarkLabel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            remarkLabel.Location = new System.Drawing.Point(637, 302);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(80, 16);
            remarkLabel.TabIndex = 21;
            remarkLabel.Text = "备    注:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(661, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(757, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "入库信息浏览:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(636, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "详细信息:";
            // 
            // ruKuXinTableAdapter1
            // 
            this.ruKuXinTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.RuKuXinTableAdapter = this.ruKuXinTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // ruKuXinDataGridView
            // 
            this.ruKuXinDataGridView.AutoGenerateColumns = false;
            this.ruKuXinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ruKuXinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4});
            this.ruKuXinDataGridView.DataSource = this.ruKuXinBindingSource;
            this.ruKuXinDataGridView.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.ruKuXinDataGridView.Location = new System.Drawing.Point(37, 124);
            this.ruKuXinDataGridView.Name = "ruKuXinDataGridView";
            this.ruKuXinDataGridView.RowTemplate.Height = 23;
            this.ruKuXinDataGridView.Size = new System.Drawing.Size(565, 273);
            this.ruKuXinDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "入库日期";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LingquR";
            this.dataGridViewTextBoxColumn5.HeaderText = "领取人";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Shuling";
            this.dataGridViewTextBoxColumn6.HeaderText = "数量";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Leibie";
            this.dataGridViewTextBoxColumn7.HeaderText = "类别";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
            this.bindingNavigator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(919, 39);
            this.bindingNavigator1.TabIndex = 15;
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
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(723, 137);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(130, 21);
            this.dateTextBox.TabIndex = 16;
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Supplier", true));
            this.supplierTextBox.Location = new System.Drawing.Point(723, 164);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(130, 21);
            this.supplierTextBox.TabIndex = 17;
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "InvoiceNumber", true));
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(723, 191);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(130, 21);
            this.invoiceNumberTextBox.TabIndex = 18;
            // 
            // lingquRTextBox
            // 
            this.lingquRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "LingquR", true));
            this.lingquRTextBox.Location = new System.Drawing.Point(723, 218);
            this.lingquRTextBox.Name = "lingquRTextBox";
            this.lingquRTextBox.Size = new System.Drawing.Size(130, 21);
            this.lingquRTextBox.TabIndex = 19;
            // 
            // shulingTextBox
            // 
            this.shulingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Shuling", true));
            this.shulingTextBox.Location = new System.Drawing.Point(723, 248);
            this.shulingTextBox.Name = "shulingTextBox";
            this.shulingTextBox.Size = new System.Drawing.Size(130, 21);
            this.shulingTextBox.TabIndex = 20;
            // 
            // leibieTextBox
            // 
            this.leibieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Leibie", true));
            this.leibieTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.leibieTextBox.Location = new System.Drawing.Point(723, 275);
            this.leibieTextBox.Name = "leibieTextBox";
            this.leibieTextBox.Size = new System.Drawing.Size(130, 21);
            this.leibieTextBox.TabIndex = 21;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruKuXinBindingSource, "Remark", true));
            this.remarkTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.remarkTextBox.Location = new System.Drawing.Point(723, 302);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(130, 21);
            this.remarkTextBox.TabIndex = 22;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(729, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(106, 18);
            this.linkLabel2.TabIndex = 24;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "返回到上一级";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 25;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(919, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(leibieLabel);
            this.Controls.Add(this.leibieTextBox);
            this.Controls.Add(shulingLabel);
            this.Controls.Add(this.shulingTextBox);
            this.Controls.Add(lingquRLabel);
            this.Controls.Add(this.lingquRTextBox);
            this.Controls.Add(invoiceNumberLabel);
            this.Controls.Add(this.invoiceNumberTextBox);
            this.Controls.Add(supplierLabel);
            this.Controls.Add(this.supplierTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.ruKuXinDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "办公用品入库登记";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource ruKuXinBindingSource1;
        private OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.RuKuXinTableAdapter ruKuXinTableAdapter1;
        private OfficeSuppliesManagementSystemDatabaseDataSet5TableAdapters.TableAdapterManager tableAdapterManager1;
        private OfficeSuppliesManagementSystemDatabaseDataSet5 officeSuppliesManagementSystemDatabaseDataSet5;
        private System.Windows.Forms.BindingSource ruKuXinBindingSource;
        private System.Windows.Forms.DataGridView ruKuXinDataGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
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
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.TextBox lingquRTextBox;
        private System.Windows.Forms.TextBox shulingTextBox;
        private System.Windows.Forms.TextBox leibieTextBox;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;

    }
}