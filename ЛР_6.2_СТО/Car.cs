using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР_6._2_СТО
{
    public class Car
    {
        public string Client_name;
        static public string Model;
        static public int choice;
        private Diagnostics diag;
        public Car()
        {
            Random rand = new Random();
            choice = rand.Next(0, 5);
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int j = 1; j <= 4; j++)
            {
                int letter_num = rand.Next(0, letters.Length - 1);

                Client_name += letters[letter_num];
            }
            Model = model();
        }
        public Diagnostics Diagnostic
        {
            get { return diag = new Diagnostics(); }
        }
        private string model()
        {
            Random rand = new Random();
            string[] models = { "Audi", "Jeep", "Tavriia", "Volvo", "Suzuki", "Mercedes", "Skoda" };
            return models[rand.Next(0, 5)];
        }
        public virtual void info()
        {
            Console.WriteLine($"______________________________________________");
            Console.WriteLine($"Клиент: {Client_name}" + "\n" + $"Модель машины: {Model}");
        }
    }
}
