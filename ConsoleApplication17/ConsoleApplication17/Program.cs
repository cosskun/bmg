using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
           int a, b ,i; string ad; 
            Console.Write("İsminizi Giriniz=");
            ad = Console.ReadLine();
            a = ad.Length;
            for (i=0; i < a; i++)
            {
                b = (int)ad[i] + 10;
                Console.Write((char)b);
            }
            Console.ReadKey();
            
        }
    }
}
