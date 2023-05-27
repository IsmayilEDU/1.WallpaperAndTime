using Task_3___Change_bacground_picture.Properties;

namespace Task_3___Change_bacground_picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Baku;

        private void Form1_Load(object sender, EventArgs e)
        {
            ClickToButtonOfBaku(sender, e);
        }
    }
}