namespace Task_1___Create_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int StartX = 0;
        private int StartY = 0;
        private int FinishX = 0;
        private int FinishY = 0;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //  Coordinats of start postion
            StartX = e.X;
            StartY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //  Coordinats of finish position
            FinishX = e.X;
            FinishY = e.Y;

            //  If StartX more than FinishX
            if (FinishX < StartX)
            {
                int temp = FinishX;
                FinishX = StartX;
                StartX = temp;
            }

            //  If StartY more than FinishY
            if (FinishY < StartY)
            {
                int temp = FinishY;
                FinishY = StartY;
                StartY = temp;
            }

            //  Create rectangle
            Label label = new Label();
            label.MinimumSize = new System.Drawing.Size(10, 10);
            label.Location = new System.Drawing.Point(StartX, StartY);
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Size = new System.Drawing.Size(FinishX - StartX, FinishY - StartY);
            label.Text = "My rectangle";
            this.Controls.Add(label);
        }
    }
}