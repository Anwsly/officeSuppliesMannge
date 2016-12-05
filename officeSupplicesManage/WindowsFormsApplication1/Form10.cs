using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bumenXinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          //  this.bumenXinBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.officeSuppliesManagementSystemDatabaseDataSet8);
//
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet15.BumenXin”中。您可以根据需要移动或删除它。
            this.bumenXinTableAdapter1.Fill(this.officeSuppliesManagementSystemDatabaseDataSet15.BumenXin);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSetBumenxin.BumenXin”中。您可以根据需要移动或删除它。
            this.bumenXinTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSetBumenxin.BumenXin);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet11.LinQu”中。您可以根据需要移动或删除它。
            this.linQuTableAdapter1.Fill(this.officeSuppliesManagementSystemDatabaseDataSet11.LinQu);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet14.LinQu”中。您可以根据需要移动或删除它。
            this.linQuTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSet14.LinQu);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet7.RuKuXin”中。您可以根据需要移动或删除它。
            this.ruKuXinTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSet7.RuKuXin);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet8.BumenXin”中。您可以根据需要移动或删除它。
         //   this.bumenXinTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSet8.BumenXin);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            //连接数据库
            //1.准备好连接语句
            string sql = "select * from LinQu where BuMin='"+listBox1.SelectedValue+"'";
           // string sql = "select * from LinQu";
            string conStr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
            //2创建连接对象
            SqlConnection conn = new SqlConnection(conStr);
            //3打开连接
            conn.Open();
            //4创建执行对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            //5.执行         
           SqlDataAdapter sda = new SqlDataAdapter(cmd);//上面两行代码与下面一行代码等效
            //6.创建数据集
           DataSet ds = new DataSet();
            //7.填充数据集
          sda.Fill(ds, "aa");
          DataTable dt = ds.Tables["aa"];        
            //显示数据
         this.linQuDataGridView.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
