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

 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studen s = new studen(1, "ali ", "male");
            int id = s.getid();
            MessageBox.Show(id.ToString());

            s.setname("yasser");
            string name = s.getname();
            MessageBox.Show(name);
            MessageBox.Show(new studen(1, "fatma", "female").getid().ToString());

            studen s2 = new studen(1000, "ali", "animal");
            MessageBox.Show(s2.getid().ToString());
            MessageBox.Show(s.getid().ToString());
            MessageBox.Show(s2.getid().ToString());


            studen.setaddress("ibb");
            MessageBox.Show(studen.adderss);
            studen.setaddress("tize");
            MessageBox.Show(studen.adderss);

            studen s3 = new studen(1000, "ali", "animal");
            // MessageBox.Show(s3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
             person p= new person();
            p.lastname= "kkk";
            p.setfirstname("aaa");
        // MessageBox.Show(p. +  "  "  + p.lastname);
  
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stdeint2 s4 = new stdeint2();
            s4.lastname = "ibb";
            MessageBox.Show(s4.lastname);
            s4.setfirstname("all");
            MessageBox.Show(s4.getname());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3("add" ,"ensert elemint");
            MessageBox.Show(f1.getbtmtext());
            f1.visual();
            f1.desing();
            f1.Show();
            Form3 f2 = new Form3();
            f2.set("اضافه ", "ادحل العنصر");
            f2.visual();
            f2.desing();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double number1 = 10;
            double number2 = 5;
            string operation = "+";

            // استدعاء الدالة الثابتة من كلاس Utility
            double result = person.PerformCalculation(number1, number2, operation);

            MessageBox.Show("النتيجة هي: " + result.ToString());
        }
  
    }
}
