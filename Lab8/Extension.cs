using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public static class Extension
    {
        public static void FullName(this int deyishen2, int Custom)
        {
            Console.WriteLine(Custom);
        }
        public static void GetValue(this string Name,string Surname)
        {
            Console.WriteLine(Name+ "\n " + Surname);
        }
    }
}
