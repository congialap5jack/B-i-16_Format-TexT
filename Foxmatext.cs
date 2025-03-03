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
    public partial class Formatext: Form
    {
        public Formatext()
        {
            InitializeComponent();
        }

        private void Color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Foxmatext_Load(object sender, EventArgs e)
        {
            redRed.Checked = true;
            txtNhapTen.Focus();
           
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Text = txtNhapTen.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = System.Drawing.Color.Red;
            txtNhapTen.ForeColor = System.Drawing.Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = System.Drawing.Color.Green;
            txtNhapTen.ForeColor = System.Drawing.Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = System.Drawing.Color.Blue;
            txtNhapTen.ForeColor = System.Drawing.Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = System.Drawing.Color.Black;
            txtNhapTen.ForeColor = System.Drawing.Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size,
           lblLaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size,
           lblLaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size,
            lblLaptrinh.Font.Style ^ FontStyle.Underline);
            // them ghi chu
        }
    }
}
