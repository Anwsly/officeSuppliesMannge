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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载窗体form1时显示验证码
            Random r = new Random();
            textBox4.Text = Convert.ToString((char)r.Next(65, 90))
                + Convert.ToString((char)r.Next(65, 90))
                 + Convert.ToString((char)r.Next(65, 90))
                  + Convert.ToString((char)r.Next(65, 90));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random r = new Random();
            textBox4.Text = Convert.ToString((char)r.Next(65, 90))
                + Convert.ToString((char)r.Next(65, 90))
                 + Convert.ToString((char)r.Next(65, 90))
                + Convert.ToString((char)r.Next(65, 90));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //登录验证
        private void button1_Click(object sender, EventArgs e)
        {
            //验证编号和密码是否正确
            string bh = textBox1.Text.Trim();
            string mi = textBox2.Text;
            //连接数据库
            //根据数据库查找是否有对应用户
            //1.创建连接字符串
            string constr = ("Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True");
            using (SqlConnection con = new SqlConnection(constr))
            { 
            //2.编写sql语句
                string sql = string.Format("select COUNT(*) from Administrator where Id= '{0}' and Psw='{1}'", bh, mi);
                //3.创建sql语句的对象，命令对象（sql command）
                using (SqlCommand cmd = new SqlCommand(sql, con))
                { 
                //4.打开连接
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    { 
                        //count>0说明数据库表里找到了编号和密码
                        //验证码是否正确
                        if (textBox3.Text == textBox4.Text)
                        {
                            //登录成功
                          //  MessageBox.Show("登录成功");
                            Form2 f2 = new Form2();
                            f2.Show();
                            this.Hide();

                        }
                        else 
                        {
                            MessageBox.Show("验证码错误", "提示");
                      
                        }

                    }
                    else
                    {
                        MessageBox.Show("用户名或密码输入错误","提示");

                    }
                }
            
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
