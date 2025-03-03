using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_16_Format_TexT
{
    public partial class mainFrom1: Form
    {
        public mainFrom1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formatextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string ten = "Nguyễn Tuấn Kiệt";
            lblInfo.Text = "Họ và tên thí sinh: " + ten + Environment.NewLine;
            lblInfo.Text += "Ngày viết chứng trình: " + System.DateTime.Now;
        }
    }
}
