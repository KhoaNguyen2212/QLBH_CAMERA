using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLT_Win
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tên đăng nhập")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Tên đăng nhập";
                txtUsername.ForeColor = Color.Gray;
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Mật khẩu")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
                txtPass.ForeColor = Color.Black;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "Mật khẩu";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Tên đăng nhập";
            txtUsername.ForeColor = Color.Gray;
            txtPass.Text = "Mật khẩu";
            txtPass.ForeColor = Color.Gray;
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
