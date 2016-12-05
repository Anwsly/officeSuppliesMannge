using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet11.LinQu”中。您可以根据需要移动或删除它。
            this.linQuTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSet11.LinQu);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet11.LinQu”中。您可以根据需要移动或删除它。
          //  this.linQuTableAdapter1.Fill(this.officeSuppliesManagementSystemDatabaseDataSet11.LinQu);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet10.LinQu”中。您可以根据需要移动或删除它。
          //  this.linQuTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSet10.LinQu);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet9.LinQu”中。您可以根据需要移动或删除它。
          //  this.linQuTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSet9.LinQu);

        }

        private void linQuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.linQuBindingSource.EndEdit();
         //   this.tableAdapterManager.UpdateAll(this.officeSuppliesManagementSystemDatabaseDataSet10);

        }

        private void linQuBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.linQuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.officeSuppliesManagementSystemDatabaseDataSet11);

        }

        private void 返回上一级_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void linQuDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
