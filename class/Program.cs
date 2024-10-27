using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            car myCar = new car();
            myCar.maker = "BMW";
            myCar.model = "sedan";
            myCar.year = 2022;
            myCar.color = "Red";

            Console.WriteLine("{0} {1} {2} {3}", myCar.maker, myCar.model, myCar.year, myCar.color);
            Console.WriteLine( MarkitValue(car syara));
            Console.ReadLine();
            private static decimal MarkitValue(car syara)
            {
                decimal carValue = 1000.0m;
                return carValue;
            }
            
            Console.ReadKey();
        }
    }

    class car
    {
        public string maker { get; set; }

        public string model { get; set; }

        public int year { get; set; }

        public string color { get; set; }


    }
}
