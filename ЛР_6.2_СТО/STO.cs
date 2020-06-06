using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР_6._2_СТО
{
    public class STO
    {
        List<Diagnostics> allClient;

        public STO(Car[] array_cars)
        {
            allClient = new List<Diagnostics>();
            for (int i = 0; i < array_cars.Length; i++)
            {
                allClient.Add(array_cars[i].Diagnostic);
                   
            }

            all_info<Diagnostics> all = new all_info<Diagnostics>(allClient);
            

        }

    }
}
