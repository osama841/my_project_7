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
    public partial class Form4 : Form
    {
        public static string stataicvribal = "osama";
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(string name)
        {
            InitializeComponent();
            this.Text = name;
        }
        Form5 objctf11;
        public Form4(Form5 objctvrml11)
        {
            InitializeComponent();
            textboxfo4.Text = objctvrml11.getname();

            textboxfo4.Text = objctvrml11.textBox11.Text;
            objctf11 = objctvrml11;
        }
        public Form4(ListBox mylist)
        {
            InitializeComponent();
            listBox1 = mylist;
        }
        public void setvale(string name)
        {
            textboxfo4.Text = name;
        }
        public string   getvale()
        {
            return textboxfo4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textboxfo4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objctf11.updatname(getvale());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
