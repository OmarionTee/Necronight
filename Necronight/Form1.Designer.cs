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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.armour = new System.Windows.Forms.PictureBox();
            this.heart = new System.Windows.Forms.PictureBox();
            this.secondary = new System.Windows.Forms.PictureBox();
            this.primary = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openspot1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.armour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openspot1)).BeginInit();
            this.SuspendLayout();
            // 
            // armour
            // 
            this.armour.BackColor = System.Drawing.Color.Transparent;
            this.armour.Image = global::Necronight.Properties.Resources.Armour_Heart;
            this.armour.Location = new System.Drawing.Point(111, 252);
            this.armour.Name = "armour";
            this.armour.Size = new System.Drawing.Size(60, 60);
            this.armour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.armour.TabIndex = 5;
            this.armour.TabStop = false;
            // 
            // heart
            // 
            this.heart.BackColor = System.Drawing.Color.Transparent;
            this.heart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart.Image = global::Necronight.Properties.Resources.Heart_Full;
            this.heart.Location = new System.Drawing.Point(22, 252);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(60, 60);
            this.heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart.TabIndex = 4;
            this.heart.TabStop = false;
            // 
            // secondary
            // 
            this.secondary.Image = global::Necronight.Properties.Resources.Secondary;
            this.secondary.Location = new System.Drawing.Point(62, 123);
            this.secondary.Name = "secondary";
            this.secondary.Size = new System.Drawing.Size(70, 70);
            this.secondary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondary.TabIndex = 3;
            this.secondary.TabStop = false;
            // 
            // primary
            // 
            this.primary.Image = global::Necronight.Properties.Resources.Primary;
            this.primary.Location = new System.Drawing.Point(53, 27);
            this.primary.Name = "primary";
            this.primary.Size = new System.Drawing.Size(90, 90);
            this.primary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.primary.TabIndex = 2;
            this.primary.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Necronight.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(202, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // openspot1
            // 
            this.openspot1.Location = new System.Drawing.Point(191, 12);
            this.openspot1.Name = "openspot1";
            this.openspot1.Size = new System.Drawing.Size(831, 607);
            this.openspot1.TabIndex = 6;
            this.openspot1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1045, 635);
            this.Controls.Add(this.armour);
            this.Controls.Add(this.heart);
            this.Controls.Add(this.secondary);
            this.Controls.Add(this.primary);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openspot1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.armour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openspot1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox primary;
        private System.Windows.Forms.PictureBox secondary;
        private System.Windows.Forms.PictureBox heart;
        private System.Windows.Forms.PictureBox armour;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox openspot1;
    }
}

