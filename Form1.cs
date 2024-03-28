using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox;
        public Form1()
        {
            InitializeComponent();


            pictureBox = new PictureBox();
            pictureBox.Size = this.ClientSize;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox);
            pictureBox.SendToBack();
        }

        public void btn1Pec()
        {
            pictureBox.Image = Image.FromFile(@"C:\Users\Stepguest\source\repos\WinFormsApp4\WinFormsApp4\gyd.jpg.png");
        }

        public void btn2Pec()
        {
            pictureBox.Image = Image.FromFile(@"C:\Users\Stepguest\source\repos\WinFormsApp4\WinFormsApp4\London_Skyline__125508655_.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            MessageBox.Show("Baku'un hal hazirki saati: " + currentTime);
            btn1Pec();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime londonTime = DateTime.Now.AddHours(4);
            MessageBox.Show("London'un hal hazirki saati: " + londonTime.ToString("HH:mm:ss"));
            btn2Pec();
        }



        private void MoveButtonRandomly()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, this.ClientSize.Width - button3.Width);
            int y = rnd.Next(0, this.ClientSize.Height - button3.Height);
            button3.Location = new Point(x, y);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MoveButtonRandomly();
        }
    }
}