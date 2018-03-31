﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            pForm1 = this;
            InitializeComponent();
        }
        public static Form1 pForm1 = null;
        OleDbDataAdapter adapter;
        public DataTable table = new DataTable();
        string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=student.mdb";
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 查看数据集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
            string sql = "Select * from student";
            adapter = new OleDbDataAdapter(sql, str);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Fill(table);
            table.DefaultView.Sort = "学号 asc";
            dataGridView1.DataSource = table;
        }

        private void 添加记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.ShowDialog();
            DataRow row = table.NewRow();
            row["学号"] = add.num;
            row["姓名"] = add.name;
            row["性别"] = add.sex;
            row["出生年月"] = add.birth;
            row["籍贯"] = add.home;
            row["专业"] = add.major;
            row["手机号"] = add.phnum;
            row["Email地址"] = add.email;
            table.Rows.Add(row);
            dataGridView1.EndEdit();
            adapter.Update(table);
            MessageBox.Show("已成功添加记录！", "添加学生信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void 修改记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 update = new Form3();
            update.ShowDialog();
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = str;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Update student Set 姓名='" + update.name + "',性别='" + update.sex + "',出生年月='" + update.birth + "',籍贯='" + update.home + "',专业='" + update.major + "',手机号='" + update.phnum + "',Email地址='" + update.email + "' Where 学号='"+update.num+"'";
            int val = cmd.ExecuteNonQuery();
            if (val > 0)
                MessageBox.Show("已成功修改指定记录！", "修改指定记录", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("未找到目标记录，请确认信息！", "修改指定记录", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void 删除记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 delete = new Form4();
            delete.ShowDialog();
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            conn.ConnectionString = str;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Delete From student Where 学号='" + delete.num + "'";
            int val = cmd.ExecuteNonQuery();
            if (val > 0)
                MessageBox.Show("已成功删除指定记录！", "删除指定记录", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("未找到目标记录，请确认信息！", "删除指定记录", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
