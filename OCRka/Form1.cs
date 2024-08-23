using System.Drawing;
using System.Windows.Forms;
using Tesseract;

namespace OCRka
{
    public partial class Form1 : Form
    {
        TesserReco reco;

        public Form1()
        {
            InitializeComponent();
            FilePathTextBox.Text = Path.Combine(Environment.CurrentDirectory, "tesserru.png");

        }

        private void bTry_Click(object sender, EventArgs e)
        {
            reco = new TesserReco();

            richTextBox1.Text = reco.Run(FilePathTextBox.Text);
            statusLabel1.Text = "Recognition complete at " + DateTime.Now.ToString();

        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = null;
                FilePathTextBox.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }
    }
}
