namespace Wvote
{
    partial class LogIn
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
            LohInLink = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            EmailText = new TextBox();
            FullNameText = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LohInLink
            // 
            LohInLink.AutoSize = true;
            LohInLink.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LohInLink.ForeColor = SystemColors.ControlLight;
            LohInLink.Location = new Point(507, 208);
            LohInLink.Name = "LohInLink";
            LohInLink.Size = new Size(101, 31);
            LohInLink.TabIndex = 13;
            LohInLink.TabStop = true;
            LohInLink.Text = "Register";
            LohInLink.LinkClicked += RegisterLinkOpenForm;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(350, 218);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 12;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 141);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 11;
            label1.Text = "Fullname";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1533887;
            pictureBox1.Location = new Point(109, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // EmailText
            // 
            EmailText.Location = new Point(350, 246);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(125, 27);
            EmailText.TabIndex = 9;
            // 
            // FullNameText
            // 
            FullNameText.Location = new Point(350, 169);
            FullNameText.Name = "FullNameText";
            FullNameText.Size = new Size(125, 27);
            FullNameText.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(614, 203);
            button1.Name = "button1";
            button1.Size = new Size(115, 41);
            button1.TabIndex = 7;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += LogInBttn;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(LohInLink);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(EmailText);
            Controls.Add(FullNameText);
            Controls.Add(button1);
            Name = "LogIn";
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel LohInLink;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox EmailText;
        private TextBox FullNameText;
        private Button button1;
    }
}