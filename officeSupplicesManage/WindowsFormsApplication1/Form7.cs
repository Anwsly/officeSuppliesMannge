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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void ruKuXinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ruKuXinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.officeSuppliesManagementSystemDatabaseDataSet5);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet5.RuKuXin”中。您可以根据需要移动或删除它。
            this.ruKuXinTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSet5.RuKuXin);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }
    }
}
