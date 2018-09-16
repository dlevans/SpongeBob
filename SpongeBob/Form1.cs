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
            char[] text = input.ToCharArray();
            string newstring = "";
            for (int i = text.Length - 1; i > -1; i--)
            {
                newstring += text[i].ToString();
            }
            input = newstring;
            return input;
        }

        string manipulate(string input)
        {
            char[] text = input.ToCharArray();
            string newstring = "";
            for (int i = 0; i < text.Length; i++)
            {
                if(i%2 == 0)
                {
                    newstring += text[i].ToString().ToUpper();
                }
                else
                {
                    newstring += text[i].ToString().ToLower();
                }
            }
            input = newstring;
            return input;
        }

        string minout(string input)
        {
            char[] text = input.ToCharArray();
            string newstring = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    newstring += text[i-1].ToString() + "oy ";
                }
                else
                {
                    newstring += text[i].ToString();
                }
            }
            input = newstring + "oy";
            return input;
        }
    }
}
