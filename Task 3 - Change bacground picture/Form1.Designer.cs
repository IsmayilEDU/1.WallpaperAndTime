﻿namespace Task_3___Change_bacground_picture
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(218, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Baku";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ClickToButtonOfBaku);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(515, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "London";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClickToButtonOfLondon);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
    }
}