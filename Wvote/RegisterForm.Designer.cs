namespace Wvote
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            FullNameText = new TextBox();
            EmailText = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            LohInLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(525, 203);
            button1.Name = "button1";
            button1.Size = new Size(115, 41);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Register;
            // 
            // FullNameText
            // 
            FullNameText.Location = new Point(349, 170);
            FullNameText.Name = "FullNameText";
            FullNameText.Size = new Size(125, 27);
            FullNameText.TabIndex = 1;
            // 
            // EmailText
            // 
            EmailText.Location = new Point(349, 247);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(125, 27);
            EmailText.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1533887;
            pictureBox1.Location = new Point(108, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 142);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 4;
            label1.Text = "Fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 219);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // LohInLink
            // 
            LohInLink.AutoSize = true;
            LohInLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LohInLink.ForeColor = SystemColors.ControlLight;
            LohInLink.Location = new Point(658, 208);
            LohInLink.Name = "LohInLink";
            LohInLink.Size = new Size(81, 31);
            LohInLink.TabIndex = 6;
            LohInLink.TabStop = true;
            LohInLink.Text = "Log In";
            LohInLink.LinkClicked += LogInLinkForm;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LohInLink);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(EmailText);
            Controls.Add(FullNameText);
            Controls.Add(button1);
            Name = "RegisterForm";
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox FullNameText;
        private TextBox EmailText;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private LinkLabel LohInLink;
    }
}
