using System;

namespace Naukaa37_getSet_
{

    class Program37
    {
        static void Main()
        {
            Students student1 = new();
            Students student2 = new("smart");
            Students student3 = new();

            student1.status = "stupid";
            student3.status = "jhjdsfhsdueh";

            Console.WriteLine($"status studenta: {student1.status}");
            Console.WriteLine($"status studenta: {student2.status}");
            Console.WriteLine($"status studenta: {student3.status}");
        }
    }

    class Students
    {
        public Students()
        {

        }
        public Students(string _status)
        {
            this._status = _status;
        }

        string _status;

        public string status 
        {
            
            get // snippet: propfull
            {
                return _status;
            }
            set
            {
                if (value == "stupid" || value == "smart")
                {
                    _status = value;
                }
                else
                {
                    _status = "not classified";
                }
            }
        }
    }

}


