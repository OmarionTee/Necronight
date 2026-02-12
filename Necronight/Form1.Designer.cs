namespace Necronight
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.Healables = new System.Windows.Forms.PictureBox();
            this.Weapon = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Wave = new System.Windows.Forms.Label();
            this.Ammo = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Healables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.SeaGreen;
            this.heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart1.Image = global::Necronight.Properties.Resources.Heart_Full;
            this.heart1.Location = new System.Drawing.Point(880, 22);
            this.heart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(63, 63);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 4;
            this.heart1.TabStop = false;
            // 
            // Healables
            // 
            this.Healables.BackColor = System.Drawing.Color.SeaGreen;
            this.Healables.Image = global::Necronight.Properties.Resources.Secondary;
            this.Healables.Location = new System.Drawing.Point(82, 22);
            this.Healables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Healables.Name = "Healables";
            this.Healables.Size = new System.Drawing.Size(63, 63);
            this.Healables.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Healables.TabIndex = 3;
            this.Healables.TabStop = false;
            // 
            // Weapon
            // 
            this.Weapon.BackColor = System.Drawing.Color.SeaGreen;
            this.Weapon.Image = global::Necronight.Properties.Resources.Primary;
            this.Weapon.Location = new System.Drawing.Point(151, 10);
            this.Weapon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Weapon.Name = "Weapon";
            this.Weapon.Size = new System.Drawing.Size(75, 75);
            this.Weapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Weapon.TabIndex = 2;
            this.Weapon.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.SeaGreen;
            this.heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart2.Image = global::Necronight.Properties.Resources.Heart_Full;
            this.heart2.Location = new System.Drawing.Point(949, 22);
            this.heart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(63, 63);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 7;
            this.heart2.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.SeaGreen;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(295, 36);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(110, 29);
            this.Score.TabIndex = 8;
            this.Score.Text = "Score: 0";
            // 
            // Wave
            // 
            this.Wave.AutoSize = true;
            this.Wave.BackColor = System.Drawing.Color.SeaGreen;
            this.Wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Wave.ForeColor = System.Drawing.Color.White;
            this.Wave.Location = new System.Drawing.Point(517, 36);
            this.Wave.Name = "Wave";
            this.Wave.Size = new System.Drawing.Size(105, 29);
            this.Wave.TabIndex = 9;
            this.Wave.Text = "Wave: 0";
            // 
            // Ammo
            // 
            this.Ammo.AutoSize = true;
            this.Ammo.BackColor = System.Drawing.Color.SeaGreen;
            this.Ammo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Ammo.ForeColor = System.Drawing.Color.White;
            this.Ammo.Location = new System.Drawing.Point(716, 36);
            this.Ammo.Name = "Ammo";
            this.Ammo.Size = new System.Drawing.Size(114, 29);
            this.Ammo.TabIndex = 10;
            this.Ammo.Text = "Ammo: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.Score);
            this.panel1.Controls.Add(this.Wave);
            this.panel1.Controls.Add(this.Ammo);
            this.panel1.Controls.Add(this.Weapon);
            this.panel1.Controls.Add(this.Healables);
            this.panel1.Controls.Add(this.heart1);
            this.panel1.Controls.Add(this.heart2);
            this.panel1.Location = new System.Drawing.Point(-42, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 103);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Necronight.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Necronight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Healables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Weapon;
        private System.Windows.Forms.PictureBox Healables;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Wave;
        private System.Windows.Forms.Label Ammo;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel panel1;
    }
}

