namespace WindowsFormsApplication1
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bumenXinBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.officeSuppliesManagementSystemDatabaseDataSet7 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet7();
            this.ruKuXinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruKuXinTableAdapter = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet7TableAdapters.RuKuXinTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.officeSuppliesManagementSystemDatabaseDataSet14 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet14();
            this.linQuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linQuTableAdapter = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet14TableAdapters.LinQuTableAdapter();
            this.officeSuppliesManagementSystemDatabaseDataSet11 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet11();
            this.linQuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.linQuTableAdapter1 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet11TableAdapters.LinQuTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet11TableAdapters.TableAdapterManager();
            this.linQuDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.officeSuppliesManagementSystemDatabaseDataSetBumenxin = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSetBumenxin();
            this.bumenXinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bumenXinTableAdapter = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSetBumenxinTableAdapters.BumenXinTableAdapter();
            this.officeSuppliesManagementSystemDatabaseDataSet15 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet15();
            this.bumenXinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bumenXinTableAdapter1 = new WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet15TableAdapters.BumenXinTableAdapter();
            this.bumenXinBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bumenXinBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bumenXinBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linQuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linQuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linQuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSetBumenxin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bumenXinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bumenXinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bumenXinBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bumenXinBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel2.Location = new System.Drawing.Point(506, 24);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(90, 18);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "返回上一级";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "部门名称:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBox1.DataSource = this.bumenXinBindingSource3;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(98, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 40);
            this.listBox1.TabIndex = 5;
            this.listBox1.ValueMember = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "查询条件:";
            // 
            // officeSuppliesManagementSystemDatabaseDataSet7
            // 
            this.officeSuppliesManagementSystemDatabaseDataSet7.DataSetName = "OfficeSuppliesManagementSystemDatabaseDataSet7";
            this.officeSuppliesManagementSystemDatabaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ruKuXinBindingSource
            // 
            this.ruKuXinBindingSource.DataMember = "RuKuXin";
            this.ruKuXinBindingSource.DataSource = this.officeSuppliesManagementSystemDatabaseDataSet7;
            // 
            // ruKuXinTableAdapter
            // 
            this.ruKuXinTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "各部门领用信息统计:";
            // 
            // officeSuppliesManagementSystemDatabaseDataSet14
            // 
            this.officeSuppliesManagementSystemDatabaseDataSet14.DataSetName = "OfficeSuppliesManagementSystemDatabaseDataSet14";
            this.officeSuppliesManagementSystemDatabaseDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linQuBindingSource
            // 
            this.linQuBindingSource.DataMember = "LinQu";
            this.linQuBindingSource.DataSource = this.officeSuppliesManagementSystemDatabaseDataSet14;
            // 
            // linQuTableAdapter
            // 
            this.linQuTableAdapter.ClearBeforeFill = true;
            // 
            // officeSuppliesManagementSystemDatabaseDataSet11
            // 
            this.officeSuppliesManagementSystemDatabaseDataSet11.DataSetName = "OfficeSuppliesManagementSystemDatabaseDataSet11";
            this.officeSuppliesManagementSystemDatabaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linQuBindingSource1
            // 
            this.linQuBindingSource1.DataMember = "LinQu";
            this.linQuBindingSource1.DataSource = this.officeSuppliesManagementSystemDatabaseDataSet11;
            // 
            // linQuTableAdapter1
            // 
            this.linQuTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.LinQuTableAdapter = this.linQuTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplication1.OfficeSuppliesManagementSystemDatabaseDataSet11TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // linQuDataGridView
            // 
            this.linQuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linQuDataGridView.Location = new System.Drawing.Point(24, 158);
            this.linQuDataGridView.Name = "linQuDataGridView";
            this.linQuDataGridView.ReadOnly = true;
            this.linQuDataGridView.RowTemplate.Height = 23;
            this.linQuDataGridView.Size = new System.Drawing.Size(580, 232);
            this.linQuDataGridView.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // officeSuppliesManagementSystemDatabaseDataSetBumenxin
            // 
            this.officeSuppliesManagementSystemDatabaseDataSetBumenxin.DataSetName = "OfficeSuppliesManagementSystemDatabaseDataSetBumenxin";
            this.officeSuppliesManagementSystemDatabaseDataSetBumenxin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bumenXinBindingSource
            // 
            this.bumenXinBindingSource.DataMember = "BumenXin";
            this.bumenXinBindingSource.DataSource = this.officeSuppliesManagementSystemDatabaseDataSetBumenxin;
            // 
            // bumenXinTableAdapter
            // 
            this.bumenXinTableAdapter.ClearBeforeFill = true;
            // 
            // officeSuppliesManagementSystemDatabaseDataSet15
            // 
            this.officeSuppliesManagementSystemDatabaseDataSet15.DataSetName = "OfficeSuppliesManagementSystemDatabaseDataSet15";
            this.officeSuppliesManagementSystemDatabaseDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bumenXinBindingSource1
            // 
            this.bumenXinBindingSource1.DataMember = "BumenXin";
            this.bumenXinBindingSource1.DataSource = this.officeSuppliesManagementSystemDatabaseDataSet15;
            // 
            // bumenXinTableAdapter1
            // 
            this.bumenXinTableAdapter1.ClearBeforeFill = true;
            // 
            // bumenXinBindingSource3
            // 
            this.bumenXinBindingSource3.DataMember = "BumenXin";
            this.bumenXinBindingSource3.DataSource = this.officeSuppliesManagementSystemDatabaseDataSet15;
            // 
            // bumenXinBindingSource4
            // 
            this.bumenXinBindingSource4.DataMember = "BumenXin";
            this.bumenXinBindingSource4.DataSource = this.officeSuppliesManagementSystemDatabaseDataSet15;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linQuDataGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "各部门领用信息统计";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bumenXinBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruKuXinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linQuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linQuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linQuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSetBumenxin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bumenXinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSuppliesManagementSystemDatabaseDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bumenXinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bumenXinBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bumenXinBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource bumenXinBindingSource2;
        private System.Windows.Forms.Label label5;
        private OfficeSuppliesManagementSystemDatabaseDataSet7 officeSuppliesManagementSystemDatabaseDataSet7;
        private System.Windows.Forms.BindingSource ruKuXinBindingSource;
        private OfficeSuppliesManagementSystemDatabaseDataSet7TableAdapters.RuKuXinTableAdapter ruKuXinTableAdapter;
        private System.Windows.Forms.Label label7;
        private OfficeSuppliesManagementSystemDatabaseDataSet14 officeSuppliesManagementSystemDatabaseDataSet14;
        private System.Windows.Forms.BindingSource linQuBindingSource;
        private OfficeSuppliesManagementSystemDatabaseDataSet14TableAdapters.LinQuTableAdapter linQuTableAdapter;
        private OfficeSuppliesManagementSystemDatabaseDataSet11 officeSuppliesManagementSystemDatabaseDataSet11;
        private System.Windows.Forms.BindingSource linQuBindingSource1;
        private OfficeSuppliesManagementSystemDatabaseDataSet11TableAdapters.LinQuTableAdapter linQuTableAdapter1;
        private OfficeSuppliesManagementSystemDatabaseDataSet11TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView linQuDataGridView;
        private System.Windows.Forms.Button button1;
        private OfficeSuppliesManagementSystemDatabaseDataSetBumenxin officeSuppliesManagementSystemDatabaseDataSetBumenxin;
        private System.Windows.Forms.BindingSource bumenXinBindingSource;
        private OfficeSuppliesManagementSystemDatabaseDataSetBumenxinTableAdapters.BumenXinTableAdapter bumenXinTableAdapter;
        private OfficeSuppliesManagementSystemDatabaseDataSet15 officeSuppliesManagementSystemDatabaseDataSet15;
        private System.Windows.Forms.BindingSource bumenXinBindingSource1;
        private OfficeSuppliesManagementSystemDatabaseDataSet15TableAdapters.BumenXinTableAdapter bumenXinTableAdapter1;
        private System.Windows.Forms.BindingSource bumenXinBindingSource3;
        private System.Windows.Forms.BindingSource bumenXinBindingSource4;
    }
}