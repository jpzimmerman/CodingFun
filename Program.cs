using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingFun
{
    class Program
    {
        static void Main(string[] args)
        {
            from DayOfWeek s in typeof(DayOfWeek).GetEnumValues().AsQueryable()
            where (int)s == 7
            select 

            foreach (DayOfWeek s in typeof(DayOfWeek).GetEnumValues())
            {
                
                typeof(DayOfWeek).GetEnumValues().AsQueryable()
                Console.WriteLine(s);
            }

            while (true) { }

        }
    }
}
