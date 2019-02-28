using ASLPhraseDictionary.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASLPhraseDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 


      
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {


           /* if (comboBox2.SelectedIndex == 0)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                areyouok.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                bestfriend.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                borrow.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                fallinlove.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                gm.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                gn.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                hyd.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 7)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                lost.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 8)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                notmyproblem.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 9)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                helpme.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 10)
            {
                foreach (var pb in Controls.OfType<PictureBox>())
                    pb.Hide();
                seeu.Visible = true;
            }
          */

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                pictureBox1.Image = Properties.Resources.areuok;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.bestfriends;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.borrow;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.fallinlove;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                pictureBox1.Image = Properties.Resources.gm;
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                pictureBox1.Image = Properties.Resources.gn;
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.hyd;
            }
            else if (comboBox2.SelectedIndex == 7)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.lost;
            }
            else if (comboBox2.SelectedIndex == 8)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.notmyproblem;
            }
            else if (comboBox2.SelectedIndex == 9)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.helpme;
            }
            else if (comboBox2.SelectedIndex == 10)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                pictureBox1.Image = Properties.Resources.seeu;
            }
            else if (comboBox2.SelectedIndex == 11)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.thetruth;
            }
            else if (comboBox2.SelectedIndex == 12)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.wyd;
            }
            else if (comboBox2.SelectedIndex == 13)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.weather;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
        }
    }
}
