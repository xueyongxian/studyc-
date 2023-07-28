using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyc_
{
    
    public partial class Form1 : Form
    {
        private Form2 Form2;
        private Form3 Form3;
        public Form1()
        {
            InitializeComponent();
            Form2 = new Form2();
            Form3 = new Form3();
            //初始化form1界面，使form2显示在panel中
            Form2.TopLevel = false;//设置为非最上面窗体
            panel1.Controls.Add(Form2);
            Form2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.TopLevel = false;//设置为非最上面窗体
            panel1.Controls.Clear();//清除panel中内容
            panel1.Controls.Add(Form2);
            Form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.TopLevel = false;//设置为非最上面窗体
            panel1.Controls.Clear();//清除panel中内容
            panel1.Controls.Add(Form3);
            Form3.Show();
        }
    }
}
