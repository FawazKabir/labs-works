using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LR_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числитель>> ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель>> ");
            int N = Convert.ToInt32(Console.ReadLine());
            int nod;
            int a = M;
            int b = N;
            while ((b > 0) && (a > 0))
            {
                int tmp = a;
                a = b;
                b = tmp % b;
            }
            nod = a;
            if (nod > 0)
            {//сокращение
                M /= nod;
                N /= nod;
            }
            Console.WriteLine("Дробь сокращена");
            Console.WriteLine(M);
            Console.WriteLine("-");
            Console.WriteLine(N);
            Console.ReadKey();

        }
    }
}