namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chase_but_MouseEnter(object sender, EventArgs e)
        {
            Random rd = new Random();

            int X_max = ClientSize.Width;
            int Y_max = ClientSize.Height;

            int next_X = rd.Next(0, X_max - chase_but.Width);
            int next_Y = rd.Next(0, Y_max - chase_but.Height);

            chase_but.Location = new Point(next_X, next_Y);
            this.Text = $"버튼 위치 : ({next_X},{next_Y})";
        }

        private void chase_but_Click(object sender, EventArgs e)
        {

        }
    }
}