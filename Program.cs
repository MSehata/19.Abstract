using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Abstract
{
    abstract class vehicle
    {
        public int wheels = 4;
    }

    class Corsa : vehicle 
    {
        public int spareWheets = 1;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Corsa car2 = new Corsa();
            Console.WriteLine("Car 2 wheels: " + car2.wheels);

            Console.Read();

        }
    }
}
