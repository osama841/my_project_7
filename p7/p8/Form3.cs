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
    public partial class Form3 : Form
    {
        Button b;
        TextBox t;
        Label l;
        ListBox les;
        public Form3()
        {
            b = new Button();
            t = new TextBox();
            l = new Label();
            les = new ListBox();
            b.Click += bclick;
            //InitializeComponent();
        }
        public Form3(string btntext,string lbltext)
        {
            InitializeComponent();
            b = new Button();
            t = new TextBox();
            l = new Label();
            les = new ListBox();
            b.Text = btntext;
            t.Text = lbltext;
            b.Click += bclick;
        }
        public void set(string btntext, string lbltext)
        {
            b.Text = btntext;
            t.Text = lbltext;
        }
        public void bclick(object s, EventArgs e)
        {
            les.Items.Add(t.Text);
        }
        public void desing()
        {
            b.Top = 30; b.Left = 25; les.Top = 60; t.Top = 10; l.Left = 110;
            l.Top = 10; l.Left = les.Left = 10;
        }
     public   void visual()
        {
            this.Controls.Add(b);
            this.Controls.Add(t);
            this.Controls.Add(l);
            this.Controls.Add(les);

        }
        public string getbtmtext()
        {
            return b.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 g = new Form3();
            g.desing();
            g.visual();
            g.Show();   
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

    }
}
