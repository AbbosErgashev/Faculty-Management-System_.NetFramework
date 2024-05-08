using System;
using System.Windows.Forms;

namespace FacultyManagementSystem
{
    public partial class Fakultet : Form
    {
        public Fakultet()
        {
            InitializeComponent();
        }

        private void YLbl_Click(object sender, EventArgs e)
        {
            Yonalish p = new Yonalish();
            p.TopLevel = false;
            startpnl.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void FLbl_Click(object sender, EventArgs e)
        {
            StartPage p = new StartPage();
            p.TopLevel = false;
            startpnl.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Fakultet f = new Fakultet();
            f.Show();
            this.Hide();
        }

        private void OLbl_Click(object sender, EventArgs e)
        {
            Oqituvchi p = new Oqituvchi();
            p.TopLevel = false;
            startpnl.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void KLbl_Click(object sender, EventArgs e)
        {
            Kafedra p = new Kafedra();
            p.TopLevel = false;
            startpnl.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void FanLbl_Click(object sender, EventArgs e)
        {
            Fan p = new Fan();
            p.TopLevel = false;
            startpnl.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void LLbl_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}