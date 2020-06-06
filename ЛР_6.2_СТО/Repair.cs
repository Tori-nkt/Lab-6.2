using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР_6._2_СТО
{

    public class Repair : Diagnostics
    {
        bool available = true;
        int guarantie = 0;
        int new_days;
        public Repair()
        {
            for (int i = 0; i < 30; i++)
            {

                Random rand = new Random();
                int k = rand.Next(0, 4);
                if (k == 0)
                {
                    available = false;
                    new_days = days + rand.Next(1, 3);
                }
                else if (k == 1)
                {
                    int d = rand.Next(1, 2);
                    if (days - d >= 0)
                    {
                        available = true;
                        new_days = days - d;
                    }
                    else
                    {
                        new_days = days;
                    }
                }
                guarantie = rand.Next(1, 3);
            }
            info();


        }
        public override void info()
        {
            base.info();
            Console.WriteLine($"Деталь в наличии: {available}" + "\n" + $"Время на починку(по факту): {new_days} дней" + "\n" + $"Цена(по факту): {price}"
                + "\n" + $"Гарантия: {guarantie} месяцев");
        }

    }
}
