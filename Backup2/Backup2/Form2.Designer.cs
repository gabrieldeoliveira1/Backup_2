﻿namespace Backup2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 217, 223);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 828);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(302, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(604, 692);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(948, 560);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 28);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1099, 413);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1282, 828);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
    }
}