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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet12.BumenXin”中。您可以根据需要移动或删除它。
            this.bumenXinTableAdapter1.Fill(this.officeSuppliesManagementSystemDatabaseDataSet12.BumenXin);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSetBumenxin.BumenXin”中。您可以根据需要移动或删除它。
            this.bumenXinTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSetBumenxin.BumenXin);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet5.RuKuXin”中。您可以根据需要移动或删除它。
            this.ruKuXinTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSet5.RuKuXin);
            //连接数据库
           // int jiner =Convert.ToInt32( textBox9.Text);
            //1.创建连接字符串
            //2.创建连接对象
            //3.编写sql语句
            //4.创建命令对象
            //5.打开连接
            #region
           // //连接数据库
           // //1.
           // string constr = ("Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True");
           //// int je =Convert.ToInt32( textBox9.Text);
           // int bh =Convert.ToInt32( textBox3.Text);
           // //2.
           // //  string sql = string.Format("SELECT COUNT(*) FROM RuKuXin WHERE InvoiceNumber='{0}' and Zongjine='{1}'",bh,je);
           //string sql ="SELECT Zongjine FROM RuKuXin WHERE InvoiceNumber="+textBox3.Text+"";
           // using (SqlConnection con = new SqlConnection(constr))
           // {
           //     using (SqlCommand cmd = new SqlCommand(sql, con))
           //     {
           //         con.Open();
           //         int count = (int)cmd.ExecuteScalar();
           //         if (count > 0)
           //         {
           //             MessageBox.Show("");

           //         }
           //     }
           // }



            #endregion

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
          //  //获取textbox里面的值
          ////  
          //  int  chul =Convert.ToInt32( textBox2.Text);
          //  string  mingcheng = textBox3.Text;
          //  string danj = textBox5.Text;
          //  string bumen = textBox4.Text;
          //  if (textBox2.Text != null)
          //  {
          //      //连接数据库
          //      //1.创建连接字符串
          //      string constr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
          //      //2.创建连接
          //      using (SqlConnection con = new SqlConnection(constr))
          //      {
                  
                
          //          //3.编写sql语句
          //          string sql = "update RuKuXin set Shuling=Shuling-"+chul+" where Leibie=" + textBox3.Text + "";
          //          //4.创建命令对象
          //          using (SqlCommand cmd = new SqlCommand(sql, con))
          //          {
          //              int zongl = Convert.ToInt32(textBox1.Text) -chul;
          //              //5.打开连接
          //              con.Open();
          //              MessageBox.Show("库存剩余:" + zongl +" !  所需资金:" + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox5.Text) + " ! ");

          //          }
          //      }
          //  }
          //  else
          //  {
          //      MessageBox.Show("出库数量为空，请重新输入或取消出库");


          //  }



            #endregion
            string shangpinmin = textBox6.Text;
            int shangpinhao =Convert.ToInt32( textBox3.Text);
            int danjia =Convert.ToInt32( textBox5.Text);
            string bumenmin = textBox7.Text;
            int bumenhao =Convert.ToInt32( textBox4.Text);
            int chukushu =Convert.ToInt32( textBox2.Text);
            string lingquren = textBox8.Text;
            int kucunzong =Convert.ToInt32( textBox1.Text);
           // int xuyaojiner =Convert.ToInt32( textBox9.Text);

            //连接数据库将信息插入表中
            string sql = "insert into LinQu (ShangPinId,BuMenId,ChuKuShu,LingQuRen,ShangMin,BuMin,DanJIa,ShiJian) values(@a,@b,@c,@d,@e,@f,@g,@h) ";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@a",textBox3.Text),
                new SqlParameter("@b",textBox4.Text),
                 new SqlParameter("@c",textBox2.Text),
                  new SqlParameter("@d",textBox8.Text),
                new SqlParameter("@e",textBox6.Text),
                 new SqlParameter("@f",textBox7.Text),
                  new SqlParameter("@g",textBox5.Text),
              new SqlParameter("@h",dateTimePicker1.Value),

            };
            string connStr = ("Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(pms);
            //5执行
            int i = cmd.ExecuteNonQuery();
            //6关闭
         //   conn.Close();
            if (i > 0)
            {


                MessageBox.Show("需要金额:" + danjia * chukushu + "", "出库成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                BindData();

            }
            else
            {
                MessageBox.Show("出库失败");
            }



        }

        private void BindData()
        {
            string shangpinmin = textBox6.Text;
            int shangpinhao = Convert.ToInt32(textBox3.Text);
            int danjia = Convert.ToInt32(textBox5.Text);
            string bumenmin = textBox7.Text;
            int bumenhao = Convert.ToInt32(textBox4.Text);
            int chukushu = Convert.ToInt32(textBox2.Text);
            string lingquren = textBox8.Text;
            int kucunzong = Convert.ToInt32(textBox1.Text);
            //出库信息更新到数据库
            // throw new NotImplementedException();
            //1.创建连接字符串

            string conStr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
            //2创建连接对象
            using(SqlConnection con=new SqlConnection(conStr))
            {
                string sql = "update RuKuXin set Shuling='" + kucunzong + "'-'" + chukushu + "' where InvoiceNumber='" + textBox3.Text + "'";
                using(SqlCommand cmd=new SqlCommand(sql,con))
                {
                    con.Open();
                
                }
            
            }
          //  SqlConnection conn = new SqlConnection(conStr);

          //  string sql = "update RuKuXin set Shuling='" + kucunzong + "'-'"+chukushu+"' where Leibie='" + textBox6.Text + "'";
            //4创建执行对象
           // SqlCommand cmd = new SqlCommand(sql, conn);
      //3打开连接
          //  conn.Open();
         //  MessageBox.Show("yuguyg");
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
