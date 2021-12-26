using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukaa13_getSet_
{
    internal class Student
    {
        //int id = 0;
        //public int Id  { get => id; private set => id = value; }    
        public int Id { get; private set; } = 0;
        public string Name { get; set; } = "JSON";
        public int Age { get; set; } = 20;
        int _iq;
        public int Iq 
        { 
            get
            {
                return _iq;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("fuck you");
                }
                _iq = value;
            }
        }

        public string Surname { get => _surname; set => _surname = value; } // created by "encapsulate"

        string _surname;
    }
}
