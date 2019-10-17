using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gghh
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, temp,rz, rev = 0;
            int sum = 0;
            Console.WriteLine("Reqem daxil edin:");
            n = int.Parse(Console.ReadLine());

            // reverse any number

            while (n != 0)
            {
                rev = (rev * 10) + (n % 10);
                n = n / 10;
            }
            n = rev;

            // split any number
            Console.WriteLine("\n");


            while (n != 0)
            {
                temp = n % 10;
                n = n / 10;
                for (rz = 1; rz > temp; rz++) ;
                if (temp%2==0)
                {
                    sum += temp;
                }
                Console.WriteLine(temp);
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
