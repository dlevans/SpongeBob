using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpongeBob
{
    //test
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputText.Text = reverse(inputText.Text);
            pictureBox1.Image = SpongeBob.Properties.Resources.reverse;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputText.Text = manipulate(inputText.Text);

            pictureBox1.Image = SpongeBob.Properties.Resources.manipulate;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            outputText.Text = minout(inputText.Text);

            pictureBox1.Image = SpongeBob.Properties.Resources.minoy;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        string reverse(string input)
        {
            string newstring = "";
            for (int i = input.Length - 1; i > -1; i--)
            {
                newstring += input[i].ToString();
            }
            input = newstring;
            return input;
        }

        string manipulate(string input)
        {
            string newstring = "";
            for (int i = 0; i < input.Length; i++)
            {
                if(i%2 == 0)
                {
                    newstring += input[i].ToString().ToUpper();
                }
                else
                {
                    newstring += input[i].ToString().ToLower();
                }
            }
            input = newstring;
            return input;
        }

        string minout(string input)
        {
            string newstring = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    newstring += input[i-1].ToString() + "oy ";
                }
                else
                {
                    newstring += input[i].ToString();
                }
            }
            input = newstring + "oy";
            return input;
        }
    }
}
