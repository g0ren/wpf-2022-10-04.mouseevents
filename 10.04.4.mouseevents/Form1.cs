namespace _10._04._4.mouseevents
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
               this.Text = String.Format("Ширина = {0} Высота = {1}", this.Width, this.Height);
            }
            else if (Form.ModifierKeys == Keys.Control)
            {
                this.Close();
            }
            else 
            { 
                var position = this.PointToClient(Cursor.Position);
                if (position.X > 10 &&
                    position.X < this.Width - 10 &&
                    position.Y > 10 &&
                    position.Y < this.Height - 10)
                {
                    MessageBox.Show("Внутри квадрата");
                }
                else if (position.X == 10 ||
                    position.X == this.Width - 10 ||
                    position.Y == 10 ||
                    position.Y == this.Height - 10)
                {
                    MessageBox.Show("На границе квадрата");
                }
                else
                {
                    MessageBox.Show("Вне квадрата");
                }
            }
        }
    }
}