using InterfaceHierarchy.Models;
using System;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            ISleep sleep = new Person();
            sleep.Sleep();
            ISleep AnimalSleep = new Animal();
            IEat eagle = new Eagle();
            eagle.Eat();
        }
    }
}
