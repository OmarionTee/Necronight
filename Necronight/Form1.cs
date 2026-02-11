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

        static Image F1 = global::Necronight.Properties.Resources.F1survivor_unarmed;
        static Image B1 = global::Necronight.Properties.Resources.B1survivor_unarmed;
        static Image L1 = global::Necronight.Properties.Resources.L1survivor_unarmed;
        static Image R1 = global::Necronight.Properties.Resources.R1survivor_unarmed;
        static Image F2 = global::Necronight.Properties.Resources.F2zombie;
        static Image B2 = global::Necronight.Properties.Resources.B2zombie;
        static Image L2 = global::Necronight.Properties.Resources.L2zombie;
        static Image R2 = global::Necronight.Properties.Resources.R2zombie;
        static Image F3 = global::Necronight.Properties.Resources.F3survivor_pistol;
        static Image B3 = global::Necronight.Properties.Resources.B3survivor_pistol;
        static Image L3 = global::Necronight.Properties.Resources.L3survivor_pistol;
        static Image R3 = global::Necronight.Properties.Resources.R3survivor_pistol;
        static Image F4 = global::Necronight.Properties.Resources.F4survivor_shotgun;
        static Image B4 = global::Necronight.Properties.Resources.B4survivor_shotgun;
        static Image L4 = global::Necronight.Properties.Resources.L4survivor_shotgun;
        static Image R4 = global::Necronight.Properties.Resources.R4survivor_shotgun;
        static Image F5 = global::Necronight.Properties.Resources.F5survivor_rifle;
        static Image B5 = global::Necronight.Properties.Resources.B5survivor_rifle;
        static Image L5 = global::Necronight.Properties.Resources.L5survivor_rifle;
        static Image R5 = global::Necronight.Properties.Resources.R5survivor_rifle;
        static Image F6 = global::Necronight.Properties.Resources.F5survivor_smg;
        static Image B6 = global::Necronight.Properties.Resources.B5survivor_smg;
        static Image L6 = global::Necronight.Properties.Resources.L5survivor_smg;
        static Image R6 = global::Necronight.Properties.Resources.R5survivor_smg;
        static Image Heart_Full = global::Necronight.Properties.Resources.Heart_Full;
        static Image Heart_Empty = global::Necronight.Properties.Resources.Heart_Empty;
        static Image Heart_Half = global::Necronight.Properties.Resources.Heart_Half;


        private Heart playerHealth; // Declares a private variable "playerHealth" of type "Heart", which will be used to manage the player's health in the game


        Image bob = F1; // Initializes the variable "bob" with the forward-facing image (F1) as the default image to be displayed
        static int y = 20; // Initializes the variable "y" with the value 20, which represents the initial y coordinate of the image
        static int x = 20; // Initializes the variable "x" with the value 20, which represents the initial x coordinate of the image

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            playerHealth = new Heart(100);
            UpdateHearts();

        }

        private void UpdateHearts()
        {
            int health = playerHealth.CurrentHealth;

            // First heart
            if (health >= 50) // Checks if the player's health is greater than or equal to 50
                heart1.Image = Heart_Full;  // If the player's health is greater than or equal to 50, it sets the image of the first heart (heart1) to the full heart image (Heart_Full)
            else if (health > 0) // Checks if the player's health is greater than 0
                heart1.Image = Heart_Half; // If the player's health is greater than 0 but less than 50, it sets the image of the first heart (heart1) to the half heart image (Heart_Half)
            else
                heart1.Image = Heart_Empty; // If the player's health is 0 or less, it sets the image of the first heart (heart1) to the empty heart image (Heart_Empty)

            // Second heart
            if (health >= 100) // Checks if the player's health is greater than or equal to 100
                heart2.Image = Heart_Full; // If the player's health is greater than or equal to 100, it sets the image of the second heart (heart2) to the full heart image (Heart_Full)
            else if (health > 50) // Checks if the player's health is greater than 50
                heart2.Image = Heart_Half; // If the player's health is greater than 50 but less than 100, it sets the image of the second heart (heart2) to the half heart image (Heart_Half)
            else
                heart2.Image = Heart_Empty; // If the player's health is 50 or less, it sets the image of the second heart (heart2) to the empty heart image (Heart_Empty)

            if (playerHealth.IsDead())
            {
                EndGame();
            }

        }

        public void EndGame() // Method that checks if the player's health has reached zero, indicating that the game is over
        {
            if (playerHealth.CurrentHealth <= 0) // Checks if the Current health is less than or equal to zero
            {
                MessageBox.Show("GG, you ran out of hearts.");
                Application.Exit();
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                bob = L1; // Updates the image to the left-facing image (L1) when the left key is pressed
                x = x - 10; // Updates the x coordinate of the image by subtracting 10, which moves it to the left
            } // left

            pictureBox1.Refresh();
            pictureBox1.Update();

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                bob = R1; // Updates the image to the right-facing image (R1) when the right key is pressed
                x = x + 10; // Updates the x coordinate of the image by adding 10, which moves it to the right
            } // right

            pictureBox1.Refresh();
            pictureBox1.Update();

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                bob = F1; // Updates the image to the forward-facing image (F1) when the up key is pressed
                y = y - 10; // Updates the y coordinate of the image by subtracting 10, which moves it up
            } // up

            pictureBox1.Refresh();
            pictureBox1.Update();

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                bob = B1; // Updates the image to the backward-facing image (B1) when the down key is pressed
                y = y + 10; //  Updates the y coordinate of the image by adding 10, which moves it down
            } // down


            if (e.KeyCode == Keys.T) // Press T to test damage
            {
                playerHealth.TakeDamage(25);
                UpdateHearts();
            }
            
            if (e.KeyCode == Keys.Y) // Press H to test healing
            {
                playerHealth.Heal(25);
                UpdateHearts();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bob, x, y, 30, 40); // Draws the current image (bob) at the specified coordinates (x, y) with a width of 30 and a height of 40

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
