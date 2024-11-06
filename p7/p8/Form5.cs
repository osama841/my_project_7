using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p8
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string getname()
        {
           
            return textBox11.Text;
        }
        public void updatname(string name)
        {
            textBox11.Text = name;
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4("التعامل مع الوجهات المتعدده ");
            f2.ShowDialog();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Form4 f2 = new Form4();
            f2.setvale(textBox11.Text);
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.textboxfo4.Text = textBox11.Text;
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            Form4.stataicvribal = textBox11.Text;
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form4(textBox11.Text).Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4(listBox1);
            f2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4(this);
            f2.Show();
        }
        Form4 formns = new Form4();
        private void button9_Click(object sender, EventArgs e)
        {
            formns.Show();
        }
        Form4 formaobjct;
        private void button10_Click(object sender, EventArgs e)
        {
            if (formaobjct == null || formaobjct.IsDisposed)
            {
                formaobjct = new Form4();
                formaobjct.textboxfo4.Text = textBox11.Text;
                formaobjct.Show();
            }
                else
                {
                    formaobjct.Show();
                }
            }
        
        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
