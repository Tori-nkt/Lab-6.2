using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР_6._2_СТО
{
    public class Diagnostics : Car
    {
        string detail = "-";
        string type;
        public int price = 0;
        public int days = 0;
        bool fix = false;
        public Diagnostics()
        {

            Type();
            if (fix)
            {
                detail = Detail();
                days = Days();
                price = Price();
            }
            else
            {
                price = Price();
            }

        }
        private void Type()
        {
            Random rand = new Random();
            int k;
            switch (choice)
            {
                case 0:
                    k = rand.Next(1, 5);
                    type = "Поверхностная диагностика";
                    if (k != 1)
                    {
                        fix = true;
                        type += " + починка";
                        Repair ca = new Repair();
                        break;
                    }
                    fix = false;
                    info();
                    break;
                case 1:
                    k = rand.Next(1, 3);
                    type = "Полная диагностика";
                    if (k != 1)
                    {
                        type += " + починка";
                        Repair c = new Repair();
                        fix = true;
                        break;
                    }
                    info();
                    break;
                default:
                    type = "Полная диагностика + починка";
                    fix = true;
                    Repair car = new Repair();
                    break;
            }

        }
        private string Detail()
        {
            Random rand = new Random();
            string[] details = {"Стекло","Шины","Наличие подтёков жидкостей и масла",
            "Давление в шинах","Свечи","Двигатель","Тормозная система","Аккамуляторная батарея","Глушитель"};
            price = rand.Next(0, details.Length - 1);
            return details[price];
        }
        private int Days()
        {
            Random rand = new Random();
            return rand.Next(1, 10);
        }
        private int Price()
        {
            Random rand = new Random();
            return rand.Next((price + 1) * 100, (price + 1) * 1000);
        }
        public override string ToString()
        {
            return ($"Вид работ: {type}" + "\n" + $"Что нужно починить: {detail}" + "\n" + $"Примерное время на починку: {days} дней"
                + "\n" + $"Цена(предварительно): {price}");
        }
        public override void info()
        {
            base.info();
            Console.WriteLine(ToString());
        }
    }
}
