using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Necronight
{
    internal class Bullet
    {
        public string direction; // The direction the bullet is moving (e.g., "F", "B", "L", "R")
        public int bulletLeft; // The x-coordinate of the bullet's position
        public int bulletTop; // The y-coordinate of the bullet's position
        private int speed = 10; // The speed at which the bullet moves
        private PictureBox bullet = new PictureBox(); // The PictureBox object representing the bullet in the game
        private Timer bulletTimer = new Timer(); // A Timer object to control the movement of the bullet

        public void drawBullet(Form form) // Method to initialize and display the bullet on the form
        {
            bullet.BackColor = Color.Yellow; // Sets the background color of the bullet to yellow
            bullet.Size = new Size(3, 3); // Sets the size of the bullet to 3x3 pixels
            bullet.Tag = "bullet"; // Assigns a tag to the bullet for identification purposes
            bullet.Left = bulletLeft; // Sets the initial x-coordinate of the bullet
            bullet.Top = bulletTop; // Sets the initial y-coordinate of the bullet


            form.Controls.Add(bullet); // Adds the bullet PictureBox to the form's controls
            bulletTimer.Interval = speed;// Sets the interval of the timer based on the bullet's speed, determining how often the bullet's position will be updated
            bulletTimer.Tick += new EventHandler(BulletTimerEvent); // Subscribes the BulletTimerEvent method to the Tick event of the timer, which will be called every time the timer ticks
            bulletTimer.Start(); // Starts the timer to begin moving the bullet
        }

    
        private void BulletTimerEvent(object sender, EventArgs e) // Method that handles the movement of the bullet based on its direction
        {
            switch (direction) // Checks the direction of the bullet and updates its position accordingly
            {
                case "Front":
                    bullet.Top -= speed; // Moves the bullet upwards by decreasing its y-coordinate
                    break;

                case "Back":
                    bullet.Top += speed; // Moves the bullet downwards by increasing its y-coordinate
                    break;

                case "Left":
                    bullet.Left -= speed; // Moves the bullet left by decreasing its x-coordinate
                    break;

                case "Right":
                    bullet.Left += speed; // Moves the bullet right by increasing its x-coordinate
                    break;
            }

            if (bullet.Left < 0 || bullet.Left > 1500 || bullet.Top < 0 || bullet.Top > 800) // Checks if the bullet has moved outside the bounds of the game area (assuming a game area of 1500x800 pixels)
            {
                bulletTimer.Stop(); // Stops the timer to prevent further movement of the bullet
                bulletTimer.Dispose(); // Disposes of the timer to free up resources
                bullet.Dispose(); // Disposes of the bullet PictureBox to free up resources
                bulletTimer = null; // Sets the bulletTimer variable to null to indicate that it is no longer in use
                bullet = null; // Sets the bullet variable to null to indicate that it is no longer in use
            }
        }

    }
}
