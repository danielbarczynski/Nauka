using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukaaa108_decoupling_;

public class Test2
{
    public class DoingClass
    {
        public static void Do()
        {
            Console.WriteLine("class doing");
        }
    }
    public static void Do()
    {
        Console.WriteLine("doing");
    }
}
