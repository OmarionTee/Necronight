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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.Healables = new System.Windows.Forms.PictureBox();
            this.Weapon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openspot1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Wave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Healables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openspot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            this.SuspendLayout();
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart1.Image = global::Necronight.Properties.Resources.Heart_Full;
            this.heart1.Location = new System.Drawing.Point(33, 253);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(60, 60);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 4;
            this.heart1.TabStop = false;
            // 
            // Healables
            // 
            this.Healables.Image = global::Necronight.Properties.Resources.Secondary;
            this.Healables.Location = new System.Drawing.Point(63, 137);
            this.Healables.Name = "Healables";
            this.Healables.Size = new System.Drawing.Size(70, 71);
            this.Healables.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Healables.TabIndex = 3;
            this.Healables.TabStop = false;
            // 
            // Weapon
            // 
            this.Weapon.Image = global::Necronight.Properties.Resources.Primary;
            this.Weapon.Location = new System.Drawing.Point(54, 42);
            this.Weapon.Name = "Weapon";
            this.Weapon.Size = new System.Drawing.Size(90, 89);
            this.Weapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Weapon.TabIndex = 2;
            this.Weapon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Necronight.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(216, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // openspot1
            // 
            this.openspot1.Location = new System.Drawing.Point(202, 53);
            this.openspot1.Name = "openspot1";
            this.openspot1.Size = new System.Drawing.Size(838, 608);
            this.openspot1.TabIndex = 6;
            this.openspot1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart2.Image = global::Necronight.Properties.Resources.Heart_Full;
            this.heart2.Location = new System.Drawing.Point(110, 253);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(60, 60);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 7;
            this.heart2.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(12, 379);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(102, 32);
            this.Score.TabIndex = 8;
            this.Score.Text = "Score:";
            // 
            // Wave
            // 
            this.Wave.AutoSize = true;
            this.Wave.BackColor = System.Drawing.Color.Transparent;
            this.Wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Wave.ForeColor = System.Drawing.Color.White;
            this.Wave.Location = new System.Drawing.Point(198, 14);
            this.Wave.Name = "Wave";
            this.Wave.Size = new System.Drawing.Size(99, 32);
            this.Wave.TabIndex = 9;
            this.Wave.Text = "Wave:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 699);
            this.Controls.Add(this.Wave);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.Healables);
            this.Controls.Add(this.Weapon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openspot1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Necronight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Healables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openspot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Weapon;
        private System.Windows.Forms.PictureBox Healables;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox openspot1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Wave;
    }
}

