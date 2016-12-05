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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 入库登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void 退出系统ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
      

        private void 入库明细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  Form4 f4 = new Form4();
          //  f4.Show();
           // this.Close();
        }


        private void 库存数量统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }

       

        
        private void 库存动态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form6 f6 = new Form6();
           // f6.Show();
           // this.Close();
        }

        private void 金额统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Close();
        }

        private void 操作员设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //修改密码
            Form8 f8 = new Form8();
            f8.Show();
            this.Close();
          
        }

        private void 出库信息登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //出库信息
            Form9 f9 = new Form9();
            f9.Show();
            this.Close();
        }

        private void 各部门领用信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void 已出库信息查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }

      
    }
}
