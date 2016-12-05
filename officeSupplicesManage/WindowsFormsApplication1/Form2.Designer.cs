namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.办公用品入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库信息登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已出库信息查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.办公用品库存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存数量统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分析与统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.金额统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.各部门领用信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.办公用品入库ToolStripMenuItem,
            this.办公用品库存ToolStripMenuItem,
            this.分析与统计ToolStripMenuItem,
            this.系统设置ToolStripMenuItem,
            this.退出系统ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8);
            this.menuStrip1.Size = new System.Drawing.Size(680, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 办公用品入库ToolStripMenuItem
            // 
            this.办公用品入库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库登记ToolStripMenuItem,
            this.出库信息登记ToolStripMenuItem,
            this.已出库信息查看ToolStripMenuItem});
            this.办公用品入库ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("办公用品入库ToolStripMenuItem.Image")));
            this.办公用品入库ToolStripMenuItem.Name = "办公用品入库ToolStripMenuItem";
            this.办公用品入库ToolStripMenuItem.Size = new System.Drawing.Size(212, 20);
            this.办公用品入库ToolStripMenuItem.Text = "办公用品入库及出库登记";
            // 
            // 入库登记ToolStripMenuItem
            // 
            this.入库登记ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("入库登记ToolStripMenuItem.Image")));
            this.入库登记ToolStripMenuItem.Name = "入库登记ToolStripMenuItem";
            this.入库登记ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.入库登记ToolStripMenuItem.Text = "入库信息登记";
            this.入库登记ToolStripMenuItem.Click += new System.EventHandler(this.入库登记ToolStripMenuItem_Click);
            // 
            // 出库信息登记ToolStripMenuItem
            // 
            this.出库信息登记ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("出库信息登记ToolStripMenuItem.Image")));
            this.出库信息登记ToolStripMenuItem.Name = "出库信息登记ToolStripMenuItem";
            this.出库信息登记ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.出库信息登记ToolStripMenuItem.Text = "出库信息登记";
            this.出库信息登记ToolStripMenuItem.Click += new System.EventHandler(this.出库信息登记ToolStripMenuItem_Click);
            // 
            // 已出库信息查看ToolStripMenuItem
            // 
            this.已出库信息查看ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("已出库信息查看ToolStripMenuItem.Image")));
            this.已出库信息查看ToolStripMenuItem.Name = "已出库信息查看ToolStripMenuItem";
            this.已出库信息查看ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.已出库信息查看ToolStripMenuItem.Text = "已出库信息查看";
            this.已出库信息查看ToolStripMenuItem.Click += new System.EventHandler(this.已出库信息查看ToolStripMenuItem_Click);
            // 
            // 办公用品库存ToolStripMenuItem
            // 
            this.办公用品库存ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存数量统计ToolStripMenuItem});
            this.办公用品库存ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("办公用品库存ToolStripMenuItem.Image")));
            this.办公用品库存ToolStripMenuItem.Name = "办公用品库存ToolStripMenuItem";
            this.办公用品库存ToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.办公用品库存ToolStripMenuItem.Text = "办公用品库存";
            // 
            // 库存数量统计ToolStripMenuItem
            // 
            this.库存数量统计ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("库存数量统计ToolStripMenuItem.Image")));
            this.库存数量统计ToolStripMenuItem.Name = "库存数量统计ToolStripMenuItem";
            this.库存数量统计ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.库存数量统计ToolStripMenuItem.Text = "库存数量统计";
            this.库存数量统计ToolStripMenuItem.Click += new System.EventHandler(this.库存数量统计ToolStripMenuItem_Click);
            // 
            // 分析与统计ToolStripMenuItem
            // 
            this.分析与统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.金额统计ToolStripMenuItem,
            this.各部门领用信息ToolStripMenuItem});
            this.分析与统计ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("分析与统计ToolStripMenuItem.Image")));
            this.分析与统计ToolStripMenuItem.Name = "分析与统计ToolStripMenuItem";
            this.分析与统计ToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.分析与统计ToolStripMenuItem.Text = "分析与统计";
            // 
            // 金额统计ToolStripMenuItem
            // 
            this.金额统计ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("金额统计ToolStripMenuItem.Image")));
            this.金额统计ToolStripMenuItem.Name = "金额统计ToolStripMenuItem";
            this.金额统计ToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.金额统计ToolStripMenuItem.Text = "金额统计";
            this.金额统计ToolStripMenuItem.Click += new System.EventHandler(this.金额统计ToolStripMenuItem_Click);
            // 
            // 各部门领用信息ToolStripMenuItem
            // 
            this.各部门领用信息ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("各部门领用信息ToolStripMenuItem.Image")));
            this.各部门领用信息ToolStripMenuItem.Name = "各部门领用信息ToolStripMenuItem";
            this.各部门领用信息ToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.各部门领用信息ToolStripMenuItem.Text = "各部门领用信息统计";
            this.各部门领用信息ToolStripMenuItem.Click += new System.EventHandler(this.各部门领用信息ToolStripMenuItem_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作员设置ToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("系统设置ToolStripMenuItem.Image")));
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 操作员设置ToolStripMenuItem
            // 
            this.操作员设置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("操作员设置ToolStripMenuItem.Image")));
            this.操作员设置ToolStripMenuItem.Name = "操作员设置ToolStripMenuItem";
            this.操作员设置ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.操作员设置ToolStripMenuItem.Text = "修改密码";
            this.操作员设置ToolStripMenuItem.Click += new System.EventHandler(this.操作员设置ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem1
            // 
            this.退出系统ToolStripMenuItem1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.退出系统ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("退出系统ToolStripMenuItem1.Image")));
            this.退出系统ToolStripMenuItem1.Name = "退出系统ToolStripMenuItem1";
            this.退出系统ToolStripMenuItem1.Size = new System.Drawing.Size(100, 20);
            this.退出系统ToolStripMenuItem1.Text = "退出系统";
            this.退出系统ToolStripMenuItem1.Click += new System.EventHandler(this.退出系统ToolStripMenuItem1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(680, 454);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "办公用品管理系统";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 办公用品入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 办公用品库存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作员设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 分析与统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存数量统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 金额统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库信息登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 各部门领用信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已出库信息查看ToolStripMenuItem;
    }
}