using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace thuchanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào bạn!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hesoluong = Convert.ToDouble(txthesoluong.Text);
            double luongcoban = Convert.ToDouble(txtluongcoban.Text);
            double luong = hesoluong * luongcoban;
            txtluong.Text = luong.ToString();
        }

        //private void txthesoluong_TextChanged(object sender, EventArgs e)
        //{
        //if((()))
        //}

        private void txthesoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '.')
                || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
