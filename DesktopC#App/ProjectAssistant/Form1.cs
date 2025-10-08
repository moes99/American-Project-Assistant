namespace ProjectAssistant
{
    public partial class Form1 : Form
    {

        private readonly Random _rand = new Random();
        int r, g, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(r = _rand.Next(256), g = _rand.Next(256), b = _rand.Next(256));
        }
    }
}
