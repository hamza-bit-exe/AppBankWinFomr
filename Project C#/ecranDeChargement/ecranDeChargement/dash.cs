using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ecranDeChargement
{
    public partial class dash : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
 (
 int nLeftRect,
 int nTopRect,
 int RightRect,
 int nBottomRect,
 int nWidthEllipse,
 int nHeightEllipse

 );
        public dash()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));  //Pour les bordures
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void dash_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPayment.Height;
            pnlNav.Top = btnPayment.Top;
            btnPayment.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnTransfert_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTransfert.Height;
            pnlNav.Top = btnTransfert.Top;
            btnTransfert.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCarte_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCarte.Height;
            pnlNav.Top = btnCarte.Top;
            btnCarte.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnConvert.Height;
            pnlNav.Top = btnConvert.Top;
            btnConvert.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }



        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPayment_Leave(object sender, EventArgs e)
        {
            btnPayment.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnTransfert_Leave(object sender, EventArgs e)
        {
            btnTransfert.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnCarte_Leave(object sender, EventArgs e)
        {
            btnCarte.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConvert_Leave(object sender, EventArgs e)
        {
            btnConvert.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
