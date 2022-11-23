using SportsTeam;
using System;
using Naukaaa108_decoupling_;
//using static Naukaaa108_decoupling_.Test2; 
//namespace Naukaaa108_decoupling_ // then no need to "using" 
namespace MyNamespace
{
    class Test
    {
        public void Doing()
        {
            Test2.Do();
            Test2.DoingClass.Do();
            // same as:
            System.Console.WriteLine();
        }
    }
}