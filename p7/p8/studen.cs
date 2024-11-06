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
    class studen
    {
        private int id;
        public string name;
        static string gender;
        public static string adderss;

        studen()
        {
            id =0 ;
            name = "";
            gender = "";
            adderss = "";
        }
        public studen (int id,string name, string  g)
    {
        this.id = id;
        this.name = name;
        gender = g;
        MessageBox.Show(id.ToString() + " " + name + " " + gender);

    }
        private void setid(int id)
        {
            this.id = id;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public int getid()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }
       public static void   setaddress(string add)
       {
           adderss=add;
       }
       public static String getadderes()
       {
           return adderss;
       }
         
       
    }
   
}
