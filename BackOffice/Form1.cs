using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class QuickCarry : Form
    {
        public QuickCarry()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(22, 75, 96);
            this.SlidePanel.BackColor = Color.FromArgb(79, 192, 208);
            this.buttonClose.BackColor = Color.FromArgb(27, 107, 147);
            this.buttonMaximize.BackColor = Color.FromArgb(27, 107, 147);
            this.buttonMinimize.BackColor = Color.FromArgb(27, 107, 147);
        }

        //Variables para controlar la posicion del slide
        public int m, x, y;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             [BUG] - > No reescala items del form.
             this.WindowState = FormWindowState.Minimized;

             */
        }

        private void SlidePanel_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            x = e.X;
            y = e.Y;
        }

        private void SlidePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void SlidePanel_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


    }
}
