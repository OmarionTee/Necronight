using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Necronight
{
    internal class Zombie
    {
        public PictureBox ZombieSprite;

        private int speed = 3; // speed at which the zombie moves
        private int health = 50; // health for the zombie

        private int attackCooldown = 0; // Timer to track when the zombie can attack again
        private int attackDelay = 20; // Hw long the zombie must wait between attacks

        public bool IsDead => health <= 0; // Property to check if the zombie is dead based on its health

        public Zombie(Form form, Random random) // Constructor that initializes the zombie's sprite, spawns it at a random location, and adds it to the form
        {
            ZombieSprite = new PictureBox();
            ZombieSprite.SizeMode = PictureBoxSizeMode.AutoSize;
            ZombieSprite.Image = Properties.Resources.F2zombie;
            ZombieSprite.BackColor = Color.Transparent;
            ZombieSprite.Tag = "zombie";
            ZombieSprite.BringToFront();

            Spawn(form, random);

            form.Controls.Add(ZombieSprite);  
        }

        private void Spawn(Form form, Random random) // Method to spawn the zombie at a random location around the edges of the "map"
        {
            int side = random.Next(4); // Randomly select a side of the form (0 = top, 1 = bottom, 2 = left, 3 = right)

            switch (side)
            {
                case 0: // top
                    ZombieSprite.Left = random.Next(0, form.ClientSize.Width);
                    ZombieSprite.Top = -50;
                    break;

                case 1: // bottom
                    ZombieSprite.Left = random.Next(0, form.ClientSize.Width);
                    ZombieSprite.Top = form.ClientSize.Height + 50;
                    break;

                case 2: // left
                    ZombieSprite.Left = -50;
                    ZombieSprite.Top = random.Next(0, form.ClientSize.Height);
                    break;

                case 3: // right
                    ZombieSprite.Left = form.ClientSize.Width + 50;
                    ZombieSprite.Top = random.Next(0, form.ClientSize.Height);
                    break;
            }
        }

        public void MoveTowards(int playerX, int playerY) // Method to move the zombie towards the player
        {
            if (IsDead) return;

            if (ZombieSprite.Left > playerX)
            { 
                ZombieSprite.Left -= speed;
            }

            if (ZombieSprite.Left < playerX)
            {
                ZombieSprite.Left += speed;
            }

            if (ZombieSprite.Top > playerY)
            {
                ZombieSprite.Top -= speed;
            }

            if (ZombieSprite.Top < playerY)
            {
                ZombieSprite.Top += speed;
            }

        }

        public bool TryAttack(Rectangle playerBounds) // Method to attempt an attack on the player if the zombie is close
        {
            if (ZombieSprite.Bounds.IntersectsWith(playerBounds))
            {
                if (attackCooldown == 0)
                {
                    attackCooldown = attackDelay;
                    return true;
                }
            }

            return false;
        }

        public void TakeDamage(int damage) // Method to reduce the zombie's health by the specified damage and check if it dies
        {
            health -= damage;

            if (health <= 0)
                Die();
        }

        private void Die() // Method to handle the zombie's death by removing its sprite from the form
        {
            ZombieSprite.Dispose();
        }
    }
}
