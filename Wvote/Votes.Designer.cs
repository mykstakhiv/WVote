namespace Wvote
{
    partial class Votes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Votes));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            Jolteon = new CheckBox();
            Squirtle = new CheckBox();
            pikachu = new CheckBox();
            JolteonLb = new Label();
            SquirtleLb = new Label();
            PickachuLb = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pickachue;
            pictureBox1.Location = new Point(78, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(322, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pokemon_png_29;
            pictureBox3.Location = new Point(558, 157);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(145, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pokemon_logo_transparent_png_2;
            pictureBox4.Location = new Point(157, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(473, 107);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // Jolteon
            // 
            Jolteon.AutoSize = true;
            Jolteon.Location = new Point(625, 336);
            Jolteon.Name = "Jolteon";
            Jolteon.Size = new Size(18, 17);
            Jolteon.TabIndex = 4;
            Jolteon.UseVisualStyleBackColor = true;
            // 
            // Squirtle
            // 
            Squirtle.AutoSize = true;
            Squirtle.Location = new Point(382, 336);
            Squirtle.Name = "Squirtle";
            Squirtle.Size = new Size(18, 17);
            Squirtle.TabIndex = 5;
            Squirtle.UseVisualStyleBackColor = true;
            // 
            // pikachu
            // 
            pikachu.AutoSize = true;
            pikachu.Location = new Point(134, 336);
            pikachu.Name = "pikachu";
            pikachu.Size = new Size(18, 17);
            pikachu.TabIndex = 6;
            pikachu.UseVisualStyleBackColor = true;
            pikachu.CheckedChanged += pikachu_CheckedChanged;
            // 
            // JolteonLb
            // 
            JolteonLb.AutoSize = true;
            JolteonLb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JolteonLb.Location = new Point(587, 289);
            JolteonLb.Name = "JolteonLb";
            JolteonLb.Size = new Size(94, 31);
            JolteonLb.TabIndex = 7;
            JolteonLb.Text = "Jolteon";
            // 
            // SquirtleLb
            // 
            SquirtleLb.AutoSize = true;
            SquirtleLb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SquirtleLb.Location = new Point(347, 289);
            SquirtleLb.Name = "SquirtleLb";
            SquirtleLb.Size = new Size(100, 31);
            SquirtleLb.TabIndex = 8;
            SquirtleLb.Text = "Squirtle";
            // 
            // PickachuLb
            // 
            PickachuLb.AutoSize = true;
            PickachuLb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PickachuLb.Location = new Point(95, 289);
            PickachuLb.Name = "PickachuLb";
            PickachuLb.Size = new Size(110, 31);
            PickachuLb.TabIndex = 9;
            PickachuLb.Text = "Pickachu";
            // 
            // Votes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PickachuLb);
            Controls.Add(SquirtleLb);
            Controls.Add(JolteonLb);
            Controls.Add(pikachu);
            Controls.Add(Squirtle);
            Controls.Add(Jolteon);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Votes";
            Text = "Votes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private CheckBox Jolteon;
        private CheckBox Squirtle;
        private CheckBox pikachu;
        private Label JolteonLb;
        private Label SquirtleLb;
        private Label PickachuLb;
    }
}