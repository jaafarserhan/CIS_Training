using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_Training
{
    public class human
    {

      public human () { }
        public human(int _id , string _name , int _age) {

            id = _id;
            Name = _name;
            age = _age;
                }

        public int id { get; set; }
      public  string Name { get; set; }
      public  int age { get; set; } 


        public  int run (int age)
        {
            return age+5;
        }
    }
}
