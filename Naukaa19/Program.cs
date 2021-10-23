using System;
using System.Collections.Generic;

namespace Naukaa19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Address> lst = new List<Address>();
            for (i = 1; i <= 10; i++)
            {
                lst.Add(new Address());
                
            }
        }
        
    }   
    public class Address
    {
        public string name { get; set; }
    }
}