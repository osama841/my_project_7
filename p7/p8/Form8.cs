    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p6
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int index=textBox1.Text.IndexOf(textBox4.Text);
           if (index != -1)
           {
               textBox1.Select(index, textBox4.Text.Length);
               textBox1.Focus();
           }
           else
           {
               MessageBox.Show("not fond");
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            string str = textBox1.Text;
            textBox2.Text = str.ToUpper();
            textBox3.Text = str.Length.ToString();
             char []ch =new char[str.Length];
            listBox1.Items.Clear();
            string[] arstr= str.Split(' ');
            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                    // listBox2.Items.Add(arstr[i]);
                    // textBox5.Text = arstr.Length.ToString();
                    textBox5.Text = count.ToString();
                }
            }
                for (int j = 0; j < arstr.Count(); j++)
                {
                    listBox2.Items.Add(arstr[j]);
                    //textBox5.Text = listBox2.Items.Count.ToString();
               }
                listBox1.Items.Clear();
                char[] chtext = textBox1.Text.ToCharArray();
                for (int i = 0; i < chtext.Length; i++)
                    listBox1.Items.Add(chtext[i]);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int index = textBox1.Text.IndexOf(textBox4.Text);
            if (index != -1)
            {
                textBox1.Text = textBox1.Text.Remove(index, textBox4.Text.Length);
                listBox2.Items.Remove(textBox4.Text);
            }
            for (int i = index; i < index + textBox4.Text.Length; i++)
            {
                listBox1.Items.RemoveAt(index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
                listBox2.Items.Remove(listBox2.SelectedItem);
            else
                MessageBox.Show("select word first");
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.Remove(listBox1.SelectedItem);
            else
                MessageBox.Show("select char first");
        }
        string temp;
        private void button5_Click(object sender, EventArgs e)
        {
            temp = textBox1.SelectedText;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.SelectedText = temp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = null;
        }   
    }
}
