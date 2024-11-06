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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Formadd add;
        private void button1_Click(object sender, EventArgs e)
        {
            if (add == null || add.IsDisposed)
            {
                add = new Formadd();
                add.Show();
            }
           else
            {
                add.Show();
            }
        }
        Formsub sub;
        private void button2_Click(object sender, EventArgs e)
        {
            if (sub == null || sub.IsDisposed)
            {
                sub = new Formsub();
                sub.Show();
            }
            else
            {
                sub.Show();
            }
        }
        Formmul mul;
        private void button3_Click(object sender, EventArgs e)
        {

            if (mul == null || mul.IsDisposed)
            {
                mul = new Formmul();
                mul.Show();
            }
            else
            {
                mul.Show();
            }
        }
        Formdiv div;
        private void button4_Click(object sender, EventArgs e)
        {
                if (div == null || div.IsDisposed)
            {
                div = new Formdiv();
                div.Show();
            }
            else
            {
                div.Show();
            }
        }

        private void طرحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add == null || add.IsDisposed)
            {
                add = new Formadd();
                add.Show();
            }
            else
            {
                add.Show();
            }
        }

        private void ضربToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sub == null || sub.IsDisposed)
            {
                sub = new Formsub();
                sub.Show();
            }
            else
            {
                sub.Show();
            }
        }

        private void قسمةToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (mul == null || mul.IsDisposed)
            {
                mul = new Formmul();
                mul.Show();
            }
            else
            {
                mul.Show();
            }
        }

        private void قسمةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (div == null || div.IsDisposed)
            {
                div = new Formdiv();
                div.Show();
            }
            else
            {
                div.Show();
            }
        }
    }
}
