using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace p8
{
     
    class stdeint2 :person
    {
       private int id;
      public string name;
      static string gender;
      public static string address;
      public stdeint2()
      {
          id = 0;
          name = "";
          gender = "";
          address = "";
      }
      public stdeint2(int id, string name, string g)
      {
       this.id=id;
      this.name = name;
      gender= g;
      MessageBox.Show(id.ToString()+ " " +name +  " " + gender);    
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

      public static void setaddress(string add)
      {
          address = add;
      }
      public static String getadderes()
      {
          return address;
      }
     
    }
}
