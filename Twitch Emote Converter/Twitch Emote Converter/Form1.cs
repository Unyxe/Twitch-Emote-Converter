using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.Design;

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
            {
                //Puts file location in label
                textBox1.Text = opf.FileName;
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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            System.IO.FileStream fs =
           (System.IO.FileStream)saveFileDialog1.OpenFile();

            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    this.pictureBox1.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                case 2:
                    this.pictureBox1.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Bmp);
                    break;

                case 3:
                    this.pictureBox1.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Downloads the image 36x36
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            System.IO.FileStream fs =
           (System.IO.FileStream)saveFileDialog1.OpenFile();

            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    this.pictureBox1.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                case 2:
                    this.pictureBox1.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Bmp);
                    break;

                case 3:
                    this.pictureBox1.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Downloads the image 72x72
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            System.IO.FileStream fs =
           (System.IO.FileStream)saveFileDialog1.OpenFile();

            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    this.pictureBox1.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                case 2:
                    this.pictureBox1.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Bmp);
                    break;

                case 3:
                    this.pictureBox1.Image.Save(fs,
                      System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}