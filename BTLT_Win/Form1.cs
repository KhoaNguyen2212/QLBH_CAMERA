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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Xóa viền 3D mặc định của MenuStrip để giao diện phẳng và hiện đại hơn
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new ProfessionalColorTable() { UseSystemColors = false });
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void quảnKýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.ShowDialog();
        }

        private void báoCáoDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void viewCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNV frm = new QLNV();
            frm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            QLNV frm = new QLNV();
            frm.ShowDialog();
        }

        private void tốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSP1 frm = new QLSP1();
            frm.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKH frm = new QLKH();
            frm.ShowDialog();
        }

        private void quảnLýĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDL frm = new QLDL();
            frm.ShowDialog();
        }

        private void traCứuSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCSP frm = new TCSP();
            frm.ShowDialog();
        }

        private void traCứuKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCKH frm = new TCKH();
            frm.ShowDialog();
        }

        private void traCứuNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCNV frm = new TCNV();
            frm.ShowDialog();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNCC frm = new QLNCC();
            frm.ShowDialog();
        }

        private void traCứuHóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCHDX frm = new TCHDX();
            frm.ShowDialog();
        }

        private void traCứuHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCHDN frm = new TCHDN();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
        }
    }
}