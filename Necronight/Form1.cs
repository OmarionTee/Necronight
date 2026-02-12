using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        int ammo = 10; //Initializes the variable "ammo" with the value 20, which represents the initial amount of ammunition the player has in the game
        int zombieSpeed = 3; // Initializes the variable "zombieSpeed" with the value 5, which represents the speed at which zombies will move in the game 
        int score = 0; // Initializes the variable "score" with the value 0, which represents the player's initial score in the game
        Random random = new Random(); // Creates a new instance of the Random class, which will be used to generate random numbers for various game mechanics such as zombie spawning and item drops
        string facing = "F"; // Initializes the variable "facing" with the value "F", which represents the initial direction the player is facing (forward) 

        List<PictureBox> zombies = new List<PictureBox>(); // Initializes a list of PictureBox objects called "zombies", which will be used to store and manage the zombie characters in the game

        Image bob = F3; // Initializes the variable "bob" with the image F3, which represents the initial image of the player character in the game (facing forward with a pistol)
        static int y = 300; // Initializes the variable "y" with the value 300, which represents the initial y coordinate of the image
        static int x = 450; // Initializes the variable "x" with the value 450, which represents the initial x coordinate of the image

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
                heart1.Image = Heart_Full;  // If the player's health is greater than or equal to 50,
                                            // it sets the image of the first heart (heart1) to the full heart image (Heart_Full)
            else if (health > 0) // Checks if the player's health is greater than 0
                heart1.Image = Heart_Half; // If the player's health is greater than 0 but less than 50,
                                           // it sets the image of the first heart (heart1) to the half heart image (Heart_Half)
            else
                heart1.Image = Heart_Empty; // If the player's health is 0 or less,
                                            // it sets the image of the first heart (heart1) to the empty heart image (Heart_Empty)

            // Second heart
            if (health >= 100) // Checks if the player's health is greater than or equal to 100
                heart2.Image = Heart_Full; // If the player's health is greater than or equal to 100,
                                           // it sets the image of the second heart (heart2) to the full heart image (Heart_Full)
            else if (health > 50) // Checks if the player's health is greater than 50
                heart2.Image = Heart_Half; // If the player's health is greater than 50 but less than 100,
                                           // it sets the image of the second heart (heart2) to the half heart image (Heart_Half)
            else
                heart2.Image = Heart_Empty; // If the player's health is 50 or less,
                                            // it sets the image of the second heart (heart2) to the empty heart image (Heart_Empty)

            if (playerHealth.IsDead())
            {
                EndGame(); // Calls the EndGame method to check if the player's health has reached zero and end the game if necessary
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


        private void Shoot(string direction)
        {
            Bullet shootBullet = new Bullet(); // Creates a new instance of the Bullet class called "shootBullet", which will be used to manage the bullet that is fired when the player shoots
            shootBullet.direction = direction; // Sets the direction property of the shootBullet object to the value of the "direction" parameter passed to the Shoot method, which determines the direction in which the bullet will be fired 
            shootBullet.bulletLeft = x + 15; // Sets the bulletLeft property of the shootBullet object to the current x coordinate of the player plus 15, which determines the initial horizontal position of the bullet when it is fired
            shootBullet.bulletTop = y + 20; // Sets the bulletTop property of the shootBullet object to the current y coordinate of the player plus 20, which determines the initial vertical position of the bullet when it is fired
            shootBullet.drawBullet(this); // Calls the drawBullet method of the shootBullet object, passing the current form (this) as a parameter, which will handle the drawing of the bullet on the screen

        }

        private void ZombieSpawn()
        {
            PictureBox zombie = new PictureBox(); // Creates a new instance of the PictureBox class called "zombie", which will be used to represent a zombie character in the game
            zombie.Tag = "zombie"; // Sets the Tag property of the zombie PictureBox to "zombie", which can be used for identification and management of zombie objects in the game
            zombie.Image = Properties.Resources.B2zombie; // Sets the Image property of the zombie PictureBox to the image of a zombie (B2zombie) from the game's resources, which will be displayed on the screen to represent the zombie character
            zombie.Left = random.Next(0, 900); // Sets the Left property of the zombie PictureBox to a random value between 0 and 900, which determines the initial horizontal position of the zombie when it spawns on the screen
            zombie.Top = random.Next(0, 600); // Sets the Top property of the zombie PictureBox to a random value between 0 and 600, which determines the initial vertical position of the zombie when it spawns on the screen
            zombie.SizeMode = PictureBoxSizeMode.AutoSize; // Sets the SizeMode property of the zombie PictureBox to AutoSize, which allows the PictureBox to automatically adjust its size to fit the dimensions of the image it contains
            zombies.Add(zombie); // Adds the zombie PictureBox to the "zombies" list, which is used to manage all the zombie characters in the game
            this.Controls.Add(zombie); // Adds the zombie PictureBox to the form's Controls collection, which allows it to be displayed on the screen as part of the game's user interface
        }

        private void dropAmmo()
        { 
            PictureBox ammoDrop = new PictureBox(); // Creates a new instance of the PictureBox class called "ammoDrop", which will be used to represent an ammunition drop in the game
            ammoDrop.Tag = "ammo"; // Sets the Tag property of the ammoDrop PictureBox to "ammo", which can be used for identification and management of ammunition drop objects in the game
            ammoDrop.Image = Properties.Resources.rifle_ammo; // Sets the Image property of the ammoDrop PictureBox to the image of rifle ammunition (rifle_ammo) from the game's resources, which will be displayed on the screen to represent the ammunition drop
            ammoDrop.Left = random.Next(10, this.ClientSize.Width - ammoDrop.Width); // Sets the Left property of the ammoDrop PictureBox to a random value between 10 and the width of the form's client area minus the width of the ammoDrop PictureBox minus 10, which determines the initial horizontal position of the ammunition drop when it spawns on the screen, ensuring it stays within the visible area of the form
            ammoDrop.Top = random.Next(10, this.ClientSize.Height - ammoDrop.Height); // Sets the Top property of the ammoDrop PictureBox to a random value between 10 and the height of the form's client area minus the height of the ammoDrop PictureBox minus 10, which determines the initial vertical position of the ammunition drop when it spawns on the screen, ensuring it stays within the visible area of the form
            ammoDrop.SizeMode = PictureBoxSizeMode.AutoSize; // Sets the SizeMode property of the ammoDrop PictureBox to AutoSize, which allows the PictureBox to automatically adjust its size to fit the dimensions of the image it contains
            this.Controls.Add(ammoDrop); // Adds the ammoDrop PictureBox to the form's Controls collection, which allows it to be displayed on the screen as part of the game's user interface, enabling players to see and interact with the ammunition drop in the game
            ammoDrop.BackColor = Color.Transparent; // Sets the BackColor property of the ammoDrop PictureBox to Transparent, which allows the background of the ammunition drop to be see-through, making it visually blend with the game environment and enhancing the overall aesthetics of the game
            ammoDrop.BringToFront(); // Calls the BringToFront method on the ammoDrop PictureBox, which ensures that the ammunition drop is displayed in front of other controls on the form, making it more visible and accessible to players when it spawns in the game
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                bob = L3; // Updates the image to the left-facing image (L1) when the left key is pressed
                x = x - 10; // Updates the x coordinate of the image by subtracting 10, which moves it to the left
                facing = "L"; // Track that the player is now facing left
            } // left

            this.Refresh();
            this.Update();

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                bob = R3; // Updates the image to the right-facing image (R1) when the right key is pressed
                x = x + 10; // Updates the x coordinate of the image by adding 10, which moves it to the right
                facing = "R"; // Track that the player is now facing right
            } // right

            this.Refresh();
            this.Update();

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                bob = F3; // Updates the image to the forward-facing image (F1) when the up key is pressed
                y = y - 10; // Updates the y coordinate of the image by subtracting 10, which moves it up
                facing = "F"; // Track that the player is now facing forward/up
            } // up

            this.Refresh();
            this.Update();

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                bob = B3; // Updates the image to the backward-facing image (B1) when the down key is pressed
                y = y + 10; //  Updates the y coordinate of the image by adding 10, which moves it down
                facing = "B"; // Track that the player is now facing backward/down
            } // down

            this.Refresh();
            this.Update();

            if (e.KeyCode == Keys.Space && ammo > 0) // Checks if the space key is pressed and if the player has more than 0 ammunition
            {
                Shoot(facing); // Calls the Shoot method, passing the current direction the player is facing as a parameter, which will handle the shooting mechanics based on the player's orientation
                ammo--; // Decreases the ammo count by 1 each time the player shoots

                if (ammo < 1) // Checks if the ammo count is less than 1 after shooting
                {
                    dropAmmo(); // If the ammo count is below 0, it calls the dropAmmo method to spawn an ammunition drop in the game, allowing the player to replenish their ammo
                    
                }

            }

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

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Ammo.Text = "Ammo: " + ammo; // Updates the text of the txtAmmo label to display the current amount of ammunition the player has, prefixed with "Ammo: "
            Score.Text = "Score: " + score; // Updates the text of the txtScore label to display the current score, which is determined by the number of zombies in the game (zombies.Count)

            foreach (Control z in this.Controls) // Iterates through each control in the form's Controls collection to check for interactions with ammo pickups
            {
                if (z is PictureBox && z.Tag != null && z.Tag.ToString() == "ammo")
                {
                    // Use the player's x,y fields for intersection (bob is an Image, not a control)
                    if (z.Bounds.IntersectsWith(new Rectangle(x, y, 30, 40)))
                    {
                        ammo += 10; // Add ammo to player
                        this.Controls.Remove(z); // Remove the pickup from the form
                        ((PictureBox)z).Dispose(); // Dispose the PictureBox
                    }
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bob, x, y, 30, 40 ); // Draws the image (bob) at the current x and y coordinates with a width of 30 and a height of 40 pixels on the form

        }
    }
}
