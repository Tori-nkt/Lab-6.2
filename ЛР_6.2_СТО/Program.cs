using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ЛР_6._2_СТО
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car[] array_of_cars = new Car[30];
            for (int i = 0; i < 30; i++)
            {
                array_of_cars[i] = new Car();
            }
            STO Sto = new STO(array_of_cars);
        }
    }
}
