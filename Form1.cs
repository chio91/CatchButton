namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 250;

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
            score -= 10;
            this.Text = $"버튼 위치 : ({next_X},{next_Y}) / 점수 : {score}";
        }

        private void chase_but_Click(object sender, EventArgs e)
        {
            MessageBox.Show("축하합니다~!");
            score += 100;
            chase_but.Width = (int)(chase_but.Width * 0.9);
            chase_but.Height = (int)(chase_but.Height * 0.9);
            this.Text = $"버튼 위치 : ({chase_but.Location.X},{chase_but.Location.Y}) / 점수 : {score}";
        }
    }
}