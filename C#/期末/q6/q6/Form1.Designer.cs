namespace q6
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查看数据集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看数据集ToolStripMenuItem,
            this.添加记录ToolStripMenuItem,
            this.修改记录ToolStripMenuItem,
            this.删除记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查看数据集ToolStripMenuItem
            // 
            this.查看数据集ToolStripMenuItem.Name = "查看数据集ToolStripMenuItem";
            this.查看数据集ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.查看数据集ToolStripMenuItem.Text = "查看数据集";
            this.查看数据集ToolStripMenuItem.Click += new System.EventHandler(this.查看数据集ToolStripMenuItem_Click);
            // 
            // 添加记录ToolStripMenuItem
            // 
            this.添加记录ToolStripMenuItem.Name = "添加记录ToolStripMenuItem";
            this.添加记录ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.添加记录ToolStripMenuItem.Text = "添加记录";
            this.添加记录ToolStripMenuItem.Click += new System.EventHandler(this.添加记录ToolStripMenuItem_Click);
            // 
            // 修改记录ToolStripMenuItem
            // 
            this.修改记录ToolStripMenuItem.Name = "修改记录ToolStripMenuItem";
            this.修改记录ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.修改记录ToolStripMenuItem.Text = "修改记录";
            this.修改记录ToolStripMenuItem.Click += new System.EventHandler(this.修改记录ToolStripMenuItem_Click);
            // 
            // 删除记录ToolStripMenuItem
            // 
            this.删除记录ToolStripMenuItem.Name = "删除记录ToolStripMenuItem";
            this.删除记录ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.删除记录ToolStripMenuItem.Text = "删除记录";
            this.删除记录ToolStripMenuItem.Click += new System.EventHandler(this.删除记录ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 509);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 552);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "数据库操作";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看数据集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除记录ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

