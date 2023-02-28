using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login successful!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reset();
        }

        private void Reset()
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
