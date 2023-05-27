using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3___Change_bacground_picture.Properties;

namespace Task_3___Change_bacground_picture
{
    public partial class Form1 : Form
    {

        //  Click to button Baku
        private void ClickToButtonOfBaku(object sender, EventArgs e)
        {
            Baku = true;
            //  Change time
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => 
            {
                if (Baku)
                {
                    this.Text = DateTime.Now.ToLongTimeString();
                }
             };
            timer.Start();

            //  Change wallpaper to Baku
            this.BackgroundImage = Resources.baki;
            this.BackgroundImageLayout = ImageLayout.Zoom;

        }
    }
}
