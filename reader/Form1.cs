using System.IO;

namespace reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor= Color.Gray;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string PATH = @"C:\Users\USER26\source\repos\reader\reader\source.txt";
            StreamReader stream = new StreamReader(PATH);
            string data = stream.ReadToEnd();
            list1.Text = data;
        }
    }
}