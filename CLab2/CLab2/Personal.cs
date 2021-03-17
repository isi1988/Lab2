using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLab2
{
    class Personal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Personal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
