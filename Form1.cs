using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanchenkoFilm
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox1 = new PictureBox();
        PictureBox pictureBox2 = new PictureBox();
        PictureBox pictureBox3 = new PictureBox();
        PictureBox pictureBox4 = new PictureBox();
        PictureBox pictureBox5 = new PictureBox();
        public Form1()
        {
            this.BackgroundImage = Properties.Resources.fon2;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            pictureBox1.Size = new Size(150, 150);
            pictureBox2.Size = new Size(150, 150);
            pictureBox3.Size = new Size(150, 150);
            pictureBox4.Size = new Size(150, 150);
            pictureBox5.Size = new Size(150, 150);


            pictureBox1.Image = Properties.Resources.avengers;
            pictureBox2.Image = Properties.Resources.sherlock;
            pictureBox3.Image = Properties.Resources.spiderman;
            pictureBox4.Image = Properties.Resources.terminator;
            pictureBox5.Image = Properties.Resources.thor;

            pictureBox1.Location = new Point(173, 57);
            pictureBox2.Location = new Point(323, 57);
            pictureBox3.Location = new Point(473, 57);
            pictureBox4.Location = new Point(623, 57);
            pictureBox5.Location = new Point(773, 57);


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;


            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(pictureBox4);
            this.Controls.Add(pictureBox5);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.fon;
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //Form Start = new Form();
            //Start.Show();
            MessageBox.Show("1");
        }
        //private void pictureBox1_On(object sender, EventArgs e)
        //{ 
        //}
        private void pictureBox2_Clicked(object sender, EventArgs e)
        {
            //Form Start = new Form();
            //Start.Show();
            MessageBox.Show("2");
        }
        private void pictureBox3_Clicked(object sender, EventArgs e)
        {
            //Form Start = new Form();
            //Start.Show();
            MessageBox.Show("3");
        }
        private void pictureBox4_Clicked(object sender, EventArgs e)
        {
            //Form Start = new Form();
            //Start.Show();
            MessageBox.Show("4");
        }
        private void pictureBox5_Clicked(object sender, EventArgs e)
        {
            //Form Start = new Form();
            //Start.Show();
            MessageBox.Show("5");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
