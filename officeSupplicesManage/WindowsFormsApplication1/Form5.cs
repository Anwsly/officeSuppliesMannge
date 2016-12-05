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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void Form5_Load(object sender, EventArgs e)
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

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void remarkTextBox_TextChanged(object sender, EventArgs e)
        {
           // int s =Convert.ToInt32( shulingTextBox.Text);
            
            if (remarkTextBox.Text == "货源紧张")
            {

                remarkTextBox.BackColor = Color.Red;


            }
            else 
            {
                remarkTextBox.BackColor = Color.Blue;
            
            
            }
        }
    }
}
