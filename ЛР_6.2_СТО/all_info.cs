using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР_6._2_СТО
{
    class all_info<T>
    {
        private int allRepairs;
        private int Diag;
        private int FullDiag;

        public all_info(List<T> array)
        {
            FullDiag = 0;
            allRepairs = 0;
            Diag = 0;
            for (int i = 0; i < array.Count; i++)
            {
                string s = array[i].ToString().Split(':', '\n')[1];
                if (s.Equals(" Поверхностная диагностика"))
                {
                    Diag++;
                }
                else if (s.Equals(" Полная диагностика + починка"))
                {
                    allRepairs++;
                    FullDiag++;
                }
                else if (s.Equals(" Поверхностная диагностика + починка"))
                {
                    allRepairs++;
                    Diag++;
                }
                else if (s.Equals(" Полная диагностика"))
                {
                    FullDiag++;
                }
            }
            Console.WriteLine("Выполнено работ:");
            Console.WriteLine($"Поверхностная диагностика: {Diag}" + 
                "\n" + $"Полная диагностика: {FullDiag}" + "\n" + $"Починка: {allRepairs}");
        }

    }
}
