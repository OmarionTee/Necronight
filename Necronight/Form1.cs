using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Necronight
{
    public partial class Form1 : Form
    {

        static Image F1 = Necronight.Properties.Resources.F1survivor_unarmed;
        static Image B1 = Necronight.Properties.Resources.B1survivor_unarmed;
        static Image L1 = Necronight.Properties.Resources.L1survivor_unarmed;
        static Image R1 = Necronight.Properties.Resources.R1survivor_unarmed;

        Image bob = F1;
        static int y = 20;
        static int x = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                bob = L1;
                x = x - 10;
            } // left

            pictureBox1.Refresh();
            pictureBox1.Update();

            if (e.KeyCode == Keys.D)
            {
                bob = R1;
                x = x + 10;
            } // right

            pictureBox1.Refresh();
            pictureBox1.Update();

            if (e.KeyCode == Keys.W)
            {
                bob = F1;
                y = y - 10;
            } // up

            pictureBox1.Refresh();
            pictureBox1.Update();

            if (e.KeyCode == Keys.S)
            {
                bob = B1;
                y = y + 10;
            } // down

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bob, x, y, 30, 40);

        }
    }
}
