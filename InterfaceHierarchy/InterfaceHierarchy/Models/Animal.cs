using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHierarchy
{
    class Animal : ISleep
    {
        public void Sleep()
        {
            Console.WriteLine("Animal Sleep");
        }
    }
}
