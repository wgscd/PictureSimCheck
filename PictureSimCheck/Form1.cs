using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureSimCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //https://www.cnblogs.com/technology/archive/2012/07/12/2588022.html
        private void button1_Click(object sender, EventArgs e)
        {
            SimilarPhoto s = new SimilarPhoto("d:\\1.jpg");
            string str1 = s.GetHash();
            richTextBox1.AppendText(str1 + "\r\n");
            s = new SimilarPhoto("d:\\2.jpg");
            string str2 = s.GetHash();
            richTextBox1.AppendText(str2 + "\r\n");
            int d = SimilarPhoto.CalcSimilarDegree(str1, str2);//如果不相同的数据位数不超过5, 就说明两张图片很相似, 如果大于10, 说明它们是两张不同的图片.
            Text = "相似度" + d + (d <= 10 ? " 很相似" : "不相似");
            MessageBox.Show(Text);


        }
    }
}
