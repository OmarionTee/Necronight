using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Necronight
{
    public partial class Form1 : Form
    {
        // Player and zombie images
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
        static Image Heart_Full = global::Necronight.Properties.Resources.Heart_Full;
        static Image Heart_Empty = global::Necronight.Properties.Resources.Heart_Empty;
        static Image Heart_Half = global::Necronight.Properties.Resources.Heart_Half;

        private Heart playerHealth; // Player health manager
        int ammo = 10; // Player ammo
        int score = 0; // Player score
        string facing = "Front"; // Direction player is facing
        Random random = new Random(); // Random generator for zombie spawning and ammo drops
        bool hasMedkit = false; // track if player is carrying a medkit

        List<Zombie> zombies = new List<Zombie>(); // List of zombies

        Image bob = F3; // Player image
        static int x = 450; // Player X cords
        static int y = 300; // Player Y cords

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerHealth = new Heart(100); // Start at full health
            UpdateHearts();
        }

        // Update heart images based on health
        private void UpdateHearts()
        {
            int health = playerHealth.CurrentHealth;

            if (health >= 50)
            {
                heart1.Image = Heart_Full;
            }

            else if (health > 0)
            {
                heart1.Image = Heart_Half;
            }

            else
            {
                heart1.Image = Heart_Empty;
            }

            if (health >= 100)
            {
                heart2.Image = Heart_Full; 
            }

            else if (health > 50)
            {
                heart2.Image = Heart_Half;
            }

            else
            {
                heart2.Image = Heart_Empty;
            }

            if (health == 0)
            {
                EndGame();
            }
        }

        // End game when player dies
        public void EndGame()
        {
            GameTimer.Stop();
            MessageBox.Show("GG, you ran out of hearts.");
            Application.Exit();
        }

        // Shoot a bullet
        private void Shoot(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction; // Set bullet direction based on player facing
            shootBullet.bulletLeft = x + 20;
            shootBullet.bulletTop = y + 30;
            shootBullet.drawBullet(this);
        }

        // Spawn a zombie
        private void ZombieSpawn()
        {
            Zombie Spawn = new Zombie(this, random);
            zombies.Add(Spawn);
        }

        // Drop ammo on map
        private void dropAmmo()
        {
            PictureBox ammoDrop = new PictureBox();
            ammoDrop.Tag = "ammo";
            ammoDrop.Image = Properties.Resources.rifle_ammo; // Set ammo drop image (I chose rifle as it looked best)
            ammoDrop.Left = random.Next(10, this.ClientSize.Width - ammoDrop.Width); // Random X position within form bounds
            ammoDrop.Top = random.Next(10, this.ClientSize.Height - ammoDrop.Height); // Random Y position within form bounds
            ammoDrop.SizeMode = PictureBoxSizeMode.AutoSize;
            ammoDrop.BackColor = Color.Transparent;
            this.Controls.Add(ammoDrop);
            ammoDrop.BringToFront();
        }

        // Drop medkit on map
        private void dropMedkit()
        {
            PictureBox medkitDrop = new PictureBox();
            medkitDrop.Tag = "medkit";
            medkitDrop.Image = Properties.Resources.medkit;
            medkitDrop.Left = random.Next(10, this.ClientSize.Width - medkitDrop.Width);
            medkitDrop.Top = random.Next(10, this.ClientSize.Height - medkitDrop.Height);
            medkitDrop.SizeMode = PictureBoxSizeMode.AutoSize;
            medkitDrop.BackColor = Color.Transparent;
            this.Controls.Add(medkitDrop);
            medkitDrop.BringToFront();
        }

        // Handle player input
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) // Move left 
            { 
                bob = L3; x -= 10; facing = "Left"; 
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) // Move right
            { 
                bob = R3; x += 10; facing = "Right";
            }

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) // Move up
            { 
                bob = F3; y -= 10; facing = "Front"; 
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) // Move down
            {
                bob = B3; y += 10; facing = "Back";
            }

            if (e.KeyCode == Keys.Space && ammo > 0) // Shoot bullet and check if player has ammo
            {
                Shoot(facing); // Shoot bullet in direction player is facing
                ammo--;
                if (ammo < 1) dropAmmo(); // Drop more ammo if player runs out
            }

            if (e.KeyCode == Keys.H && hasMedkit) // Heal player if they have a medkit
            { 
                playerHealth.Heal(50);
                UpdateHearts(); 

                hasMedkit = false; // Player has used the medkit, so set to false
                Healables.Image = Properties.Resources.Secondary; // Clear medkit from secondary slot
            }
            if (e.KeyCode == Keys.M) dropMedkit();
        }

        // Main game loop
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Ammo.Text = "Ammo: " + ammo;
            Score.Text = "Score: " + score;

            // Pick up ammo
            foreach (Control ammoPick in this.Controls)
            {
                if (ammoPick is PictureBox && ammoPick.Tag?.ToString() == "ammo")
                {
                    if (ammoPick.Bounds.IntersectsWith(new Rectangle(x, y, 30, 40)))
                    {
                        ammo += 10;
                        this.Controls.Remove(ammoPick);
                        ((PictureBox)ammoPick).Dispose();
                    }
                }
            }

            //Pick up medkit
            foreach (Control medkit in this.Controls)
            {
                if (medkit is PictureBox && medkit.Tag?.ToString() == "medkit")
                {
                    if (medkit.Bounds.IntersectsWith(new Rectangle(x, y, 30, 40))) // player collision
                    {
                        hasMedkit = true; // Player is now carrying a medkit
                        Healables.Image = Properties.Resources.Secondary_Medkit; // Show medkit in secondary slot

                        this.Controls.Remove(medkit);
                        ((PictureBox)medkit).Dispose();
                        break;
                    }
                }
            }

            // Bullet hits zombie
            foreach (Control bullet in this.Controls)
            {
                if (bullet is PictureBox && bullet.Tag?.ToString() == "bullet")
                {
                    foreach (Zombie zombie in zombies.ToList())
                    {
                        if (bullet.Bounds.IntersectsWith(zombie.ZombieSprite.Bounds))
                        {
                            zombie.TakeDamage(25);
                            this.Controls.Remove(bullet);
                            bullet.Dispose();
                            break;
                        }
                    }
                }
            }

            Rectangle playerBounds = new Rectangle(x, y, 30, 40);

            // Update zombies
            foreach (Zombie zombie in zombies.ToList())
            {
                zombie.MoveTowards(x, y);

                // Prevent zombies overlapping
                foreach (Zombie other in zombies)
                {
                    if (other != zombie)
                    {
                        Rectangle overlap = Rectangle.Intersect(zombie.ZombieSprite.Bounds, other.ZombieSprite.Bounds);
                        if (!overlap.IsEmpty)
                        {
                            if (overlap.Width > 0) zombie.ZombieSprite.Left -= overlap.Width / 2;
                            if (overlap.Height > 0) zombie.ZombieSprite.Top -= overlap.Height / 2;
                        }
                    }
                }

                // Zombie attacks player
                if (zombie.TryAttack(playerBounds))
                {
                    playerHealth.TakeDamage(25);
                    UpdateHearts();
                }

                // Remove dead zombies
                if (zombie.IsDead)
                {
                    zombies.Remove(zombie);
                    score++;
                    ZombieSpawn();
                    
                    if(random.Next(0, 100) < 20) // 20% chance to drop ammo
                    {
                        dropMedkit();
                    }
                }
            }

            // Spawn more zombies if less than 3
            if (zombies.Count < 3)
            {
                ZombieSpawn();
            }
                
            this.Invalidate(); // Redraw screen
        }

        // Spawn the player
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bob, x, y, 30, 40);
        }
    }
}