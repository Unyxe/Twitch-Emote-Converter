using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Twitch_Emote_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open's the emote image file location
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Select Image";
            opf.Filter = "Image File (*.jpg|*.jpeg|*.bmp|*.png|*.gif) |*.jpg|*.jpeg|*.bmp|*.png|*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(opf.FileName);
                pictureBox1.Image = image;
                pictureBox2.Image = image;
                pictureBox3.Image = image;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;


                double percentage = 0.7;
                int width = control.Size.Width;
                //width = (int)Math.Round(test*perc); imagewidth 70% of form width
                int heigth = control.Size.Width;

                pictureBox1.Size = new Size(width, height);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clear 18x18 Emote from Image box
            pictureBox1.CancelAsync();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;

            //Clear 36x36 Emote from Image box
            pictureBox2.CancelAsync();
            pictureBox2.Image.Dispose();
            pictureBox2.Image = null;

            //Clear 72x72 Emote from Image box
            pictureBox3.CancelAsync();
            pictureBox3.Image.Dispose();
            pictureBox3.Image = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Downloads the image 18x18
            var filePath = @"D:\Twitch Emote Converter\Emotes\";
            Directory.CreateDirectory(filePath);
            pictureBox2.Image.Save(Path.Combine(filePath, $"'{pictureBox2.Image}'"), System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}