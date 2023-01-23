using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int fontSize;
        public string font;
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
             fontSize = Convert.ToInt32(textBox1.Text);
            
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        public String Font()
        {
            if (font == "")
            {
                font = "Consolas";

                return font;
            }
            else
            {
                return font;
            }
        }
        public int size() {
            if (fontSize == 0)
            {
                fontSize = 11;

                return fontSize;
            }
            else { 
                return fontSize;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            font = textBox2.Text;
        }
    }
}
