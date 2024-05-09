using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_lap2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            do
            {
                Console.WriteLine("vui long nhap n >2");
               n= Convert.ToInt32(Console.ReadLine());
                if (n > 2)
                {
                    int f1;
                    int f2;
                    f1 = 1;
                    f2 = 1;
                    Console.Write("{0} {1}",f1, f2);
                    for(int i = 3; i <= n; i++)
                    {
                        int f;
                        f = f1 + f2;
                        Console.Write(" {0}", f);
                        f1 = f2;
                        f2 = f;
                    }
                }
            }
            while (n<=2);
            Console.ReadKey();
        }
    }
}
