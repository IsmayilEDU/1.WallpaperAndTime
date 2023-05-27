using System;

namespace Task_2___Gezen_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                int RandomX = Random.Shared.Next(0, 1000);
                int RandomY = Random.Shared.Next(0, 1000);
                label.Location = new System.Drawing.Point(RandomX, RandomY);

            }
        }
    }
}