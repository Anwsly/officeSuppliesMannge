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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //密码修改
            //1.采集输入的用户
            string um = textBox1.Text.Trim();
            string oldPwd = textBox2.Text;
            string newPwd = textBox3.Text;
            string newPwdt = textBox4.Text;
            //2.校验两次输入的新密码是否相同
            if (textBox3.Text != "")
            {
                if (newPwd == newPwdt)
                {
                    // 3.校验旧密码是否正确
                    //使用旧密码和当前获取的GolbalHelper._Id进行匹配
                    if (CheckUserOldPassWord(oldPwd, GolbalHelper._Id))
                    {
                        //如果返回true则旧密码正确
                        //4.修改密码
                        //直接写个UpdataPassword方法
                        //修改当前登录用户的密码
                        if (UpdatePassword(GolbalHelper._Id, newPwd))
                        {
                            //如果该方法返回True，则提示用户修改密码成功
                            MessageBox.Show("密码修改成功！请重新登录");
                            Form1 f1 = new Form1();
                            f1.Show();
                            this.Close();
                        }
                        else
                        {
                            //如果返回值为False则提示用户密码修改失败
                            MessageBox.Show("密码修改失败！");
                        }
                    }
                    else
                    {
                        //否则旧密码错误
                        MessageBox.Show("旧密码错误", "提示");
                    }
                }
                else
                {

                    MessageBox.Show("两次新密码输入不一致，请重新输入", "提示");
                }
            }
            else 
            {
                MessageBox.Show("请输入新密码","提示");
            
            
            }
        }
        //修改密码的方法
        private bool UpdatePassword(int Id, string newPwdt)
        {

            //创建连接字符串来连接数据库
            string constr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
            //创建连接对象
            using (SqlConnection con = new SqlConnection(constr))
            {
                //修改密码的Sql语句
                string sql = string.Format("update Administrator set Psw='" + textBox3.Text + "' where Id='" + textBox1.Text.Trim() + "'", con);
                //创建执行Sql语句的对象（命令对象），SqlCommand
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //打开连接
                    con.Open();
                    //执行对象，调用Command的NonQuery方法，因为该方法返回insert，delete，Update的Sql查询（增删改），
                    int r = cmd.ExecuteNonQuery();
                    //返回值r为sql查询所影响的行数
                    return r > 0;

                }
            }

        }
        //校验旧密码是否正确
        private bool CheckUserOldPassWord(string oldPwd, int Id)
        {
            //确定校验旧密码的Sql语句
            string sql = string.Format("select count(*) from Administrator where Id='" + textBox1.Text.Trim() + "'and Psw='{1}'", Id, oldPwd);
            //连接数据库执行
            string constr = "Data Source=PC-20151031ZOLO;Initial Catalog=OfficeSuppliesManagementSystemDatabase;Integrated Security=True";
            //创建连接对象
            using (SqlConnection con = new SqlConnection(constr))
            {
                //创建一个执行Sql语句的对象（命令对象），SqlCommand
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //开始执行
                    //打开连接
                    con.Open();
                    //执行该Sql语句调用Command的Scalar方法，因为是返回单个值。该方法返回值不可能为空，因为是COUNT聚合函数
                    int r = (int)cmd.ExecuteScalar();
                    //判断如果return大于0，则返回True，否则返回False
                    return r > 0;

                }


            }

        }

    }
}
