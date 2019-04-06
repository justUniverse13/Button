using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AddElements();
        }

        private void ColorComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void FormComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonForm();
            ButtonColor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void ButtonColor()
        {
            switch (ColorComboBox1.SelectedIndex)
            {
                case 0:
                    button1.BackColor = Color.Blue; break;
                case 1:
                    button1.BackColor = Color.Red; break;
                case 2:
                    button1.BackColor = Color.Yellow; break;
                case 3:
                    button1.BackColor = Color.Green; break;
                case 4:
                    button1.BackColor = Color.White; break;
                case 5:
                    button1.BackColor = Color.Black; break;
            }
        }
        private void ButtonForm()
        {
            if (FormComboBox2.SelectedIndex == 0)
            {
                button1.Width = 200;
                button1.Height = 1500;
            }
            else if (FormComboBox2.SelectedIndex == 1)
            {
                button1.Width = 200;
                button1.Height = 200;
            }
            else if (FormComboBox2.SelectedIndex == 2)
            {
                System.Drawing.Drawing2D.GraphicsPath myPath =
     new System.Drawing.Drawing2D.GraphicsPath();
                myPath.AddEllipse(0, 0, button1.Width, button1.Height);

                Region myRegion = new Region(myPath);
                button1.Region = myRegion;
            }
        }
        private void AddElements()
        {
            ColorComboBox1.Items.Add("Blue");
            ColorComboBox1.Items.Add("Red");
            ColorComboBox1.Items.Add("Yellow");
            ColorComboBox1.Items.Add("Green");
            ColorComboBox1.Items.Add("White");
            ColorComboBox1.Items.Add("Black");

            FormComboBox2.Items.Add("Rectangle");
            FormComboBox2.Items.Add("Square");
            FormComboBox2.Items.Add("Elipsse");
        }
    }
}