using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace clipboard_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBox1.Text, TextDataFormat.UnicodeText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean b;
            b = Clipboard.ContainsText();
            if (b==true )
            {
                 this.textBox2.Text=  Clipboard.GetText(TextDataFormat.UnicodeText);
            }

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(this.pictureBox1.Image);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Boolean b;
            b = Clipboard.ContainsImage();
            if (b == true)
            {
                  this.pictureBox1.Image = Clipboard. GetImage();
                  this.BackgroundImage = this.pictureBox1.Image;
                  this.BackgroundImageLayout = ImageLayout.Stretch;
            }


          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
