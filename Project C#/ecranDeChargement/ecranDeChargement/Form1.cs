using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;                                         //pour le mettre round

namespace ecranDeChargement
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));  //Pour les bordures
            ProgressBar1.Value = 0;

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value += 2;
            ProgressBar1.Text = ProgressBar1.Value.ToString() + "%"; //Laffichage du pourcentage 

            if (ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                homePage h = new homePage();
                h.Show();
                this.Hide();
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
