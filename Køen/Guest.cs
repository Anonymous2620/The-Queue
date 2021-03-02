using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    //Here is my method for creating the guest name as seens bellow.
    class Guest
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //Here is my method for creating the guest age as seens bellow.
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Guest()
        {
            Name = name;
            Age = age;
        }
    }
}
