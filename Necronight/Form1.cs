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
        static Image F2 = Necronight.Properties.Resources.F2zombie;
        static Image B2 = Necronight.Properties.Resources.B2zombie;
        static Image L2 = Necronight.Properties.Resources.L2zombie;
        static Image R2 = Necronight.Properties.Resources.R2zombie;
        static Image F3 = Necronight.Properties.Resources.F3survivor_pistol;
        static Image B3 = Necronight.Properties.Resources.B3survivor_pistol;
        static Image L3 = Necronight.Properties.Resources.L3survivor_pistol;
        static Image R3 = Necronight.Properties.Resources.R3survivor_pistol;
        static Image F4 = Necronight.Properties.Resources.F4survivor_shotgun;
        static Image B4 = Necronight.Properties.Resources.B4survivor_shotgun;
        static Image L4 = Necronight.Properties.Resources.L4survivor_shotgun;
        static Image R4 = Necronight.Properties.Resources.R4survivor_shotgun;
        static Image F5 = Necronight.Properties.Resources.F5survivor_rifle;
        static Image B5 = Necronight.Properties.Resources.B5survivor_rifle;
        static Image L5 = Necronight.Properties.Resources.L5survivor_rifle;
        static Image R5 = Necronight.Properties.Resources.R5survivor_rifle;
        static Image F6 = Necronight.Properties.Resources.F5survivor_smg;
        static Image B6 = Necronight.Properties.Resources.B5survivor_smg;
        static Image L6 = Necronight.Properties.Resources.L5survivor_smg;
        static Image R6 = Necronight.Properties.Resources.R5survivor_smg;

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
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                bob = L1;
                x = x - 10;
            } // left

            pictureBox1.Refresh();
            pictureBox1.Update();

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                bob = R1;
                x = x + 10;
            } // right

            pictureBox1.Refresh();
            pictureBox1.Update();

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                bob = F1;
                y = y - 10;
            } // up

            pictureBox1.Refresh();
            pictureBox1.Update();

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                bob = B1;
                y = y + 10;
            } // down

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bob, x, y, 30, 40);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
