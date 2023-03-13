using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    internal class Library
    {
        public Library(string name, string adress, int openAge) 
        {
            Name = name;
            Adress = adress;
            OpenAge = openAge;
        }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int OpenAge { get; set; }
    }
}
