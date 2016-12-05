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
    public partial class Form3 : Form
    {
      //  private object InvoiceNumber;
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet5.RuKuXin”中。您可以根据需要移动或删除它。
            this.ruKuXinTableAdapter1.Fill(this.officeSuppliesManagementSystemDatabaseDataSet5.RuKuXin);
            // TODO: 这行代码将数据加载到表“officeSuppliesManagementSystemDatabaseDataSet.RuKuXin”中。您可以根据需要移动或删除它。
           // this.ruKuXinTableAdapter.Fill(this.officeSuppliesManagementSystemDatabaseDataSet.RuKuXin);
            //连接数据库
            //1.创建连接字符串
            string constr = ("Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True");
            using (SqlConnection con = new SqlConnection(constr))
            {
                //2.编写sql语句
                string sql = string.Format("select COUNT(*) from RuKuXin");
                //3.创建sql语句的对象，命令对象（sql command）
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //4.打开连接
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                }
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                
        }
        //新增
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into RuKuXin (Date,Supplier,InvoiceNumber,Remark,LingquR,Shuling,Leibie) values(@a,@b,@c,@d,@e,@f,@g) ";
            SqlParameter[] pms = new SqlParameter[]
            {
                new SqlParameter("@a",dateTextBox.Text),
                new SqlParameter("@b",supplierTextBox.Text),
                 new SqlParameter("@c",invoiceNumberTextBox.Text),
                  new SqlParameter("@d",remarkTextBox.Text),
                  new SqlParameter("@e",lingquRTextBox.Text),
                   new SqlParameter("@f",shulingTextBox.Text),
                    new SqlParameter("@g",leibieTextBox.Text),
            };
            string connStr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(pms);
            //5执行
            int i = cmd.ExecuteNonQuery();
            //6关闭
            conn.Close();
            if (i > 0)
            {



                MessageBox.Show("新增成功", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BindData();

            }
            else
            {
                MessageBox.Show("新增失败");
            }


        }
        private void BindData()
        {
            // throw new NotImplementedException();
            //1.准备好连接语句
            string sql = "select *from RuKuXin";

            string conStr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
            //2创建连接对象
            SqlConnection conn = new SqlConnection(conStr);
            //3打开连接
            conn.Open();
            //4创建执行对象
            SqlCommand cmd = new SqlCommand(sql, conn);

            //5.执行
            //适配器对象，一次性处理多个数据
            // SqlDataAdapter sda = new SqlDataAdapter();
            // sda.SelectCommand = cmd;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);//上面两行代码与下面一行代码等效
            ////6
            //DataTable dt = new DataTable();
            ////7
            //sda.Fill(dt);
            //6.创建数据集
            DataSet ds = new DataSet();
            //7.填充数据集
            sda.Fill(ds, "aa");
            DataTable dt = ds.Tables["aa"];
            //8.关闭
            conn.Close();
            //显示数据
            ruKuXinDataGridView.DataSource = dt;
        }
        private void remarkLabel_Click(object sender, EventArgs e)
        {

        }
        //删除
        private void button2_Click(object sender, EventArgs e)
        {
            #region
            


                     //连接数据库
             //1.创建连接字符串
             string constr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
             //  string constr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
             //2.创建连接对象
             using (SqlConnection con = new SqlConnection(constr))
             {
                 //3.编写Sql语句
                 string sql = "delete from RuKuXin where InvoiceNumber='" + invoiceNumberTextBox.Text + "'";
                 //4.创建命令对象
                 using (SqlCommand cmd = new SqlCommand(sql, con))
                 {
                     //5.打开连接
                     con.Open();
                     int i = cmd.ExecuteNonQuery();
          DialogResult dr = MessageBox.Show("是否确认删除", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           if (dr == DialogResult.OK) 
            {
           
                     if (i > 0)
                     {
                         
                         MessageBox.Show("删除成功");

                     }
                     else
                     {
                         MessageBox.Show("删除失败");
                     }

                 }

   else 
         {
             MessageBox.Show("已取消删除");
         }


             }
         }
      

          
            
            #endregion
            #region
            /*
            if (ruKuXinDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }
            string stuId = ruKuXinDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string sql = "delete from RuKuXin where InvoiceNumber=@a";
            SqlParameter pm = new SqlParameter("@a",stuId);
            string connStr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(pm);
            //5执行
            int i = cmd.ExecuteNonQuery();
            //6关闭
            conn.Close();
            if (i > 0)
            {
                MessageBox.Show("删除成功");
                BindData();


            }

            else
            {
                MessageBox.Show("删除失败");
            }
             */
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //修改
            //连接数据库
            //1.创建连接字符串
            string constr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
            //2.创建连接对象
            using (SqlConnection con = new SqlConnection(constr))
            {
                //3.编写sql语句
                //3.编写Sql语句
                string sql = "update RuKuXin set InvoiceNumber='" + invoiceNumberTextBox.Text + "',Date='" + dateTextBox.Text + "',Supplier='" + supplierTextBox.Text + "',LingquR='" + lingquRTextBox.Text + "',Shuling='" + shulingTextBox.Text + "',Leibie='" + leibieTextBox.TabIndex + "',Remark='"+remarkTextBox.Text+"'";


                //4.创建命令对象
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {

                    //5.打开连接
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    DialogResult dr = MessageBox.Show("是否确认修改", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        if (i > 0)
                        {

                            MessageBox.Show("更新成功");

                        }
                        else
                        {
                            MessageBox.Show("您未做出修改");
                        }
                    }
                }

            }


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        }
    }

