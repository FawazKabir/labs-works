using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LR_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create.Sum();*/
            Create create = new Create();
            create.Sum(); 
            Console.ReadKey();

        }
    }
    class Create
    {

        public /*static*/ void Sum()
        {
            Console.WriteLine("Введите количество элементов: ");
            int N = Convert.ToInt32(Console.ReadLine()); //количество элементов
            int[] mas = new int[N]; //массив значений
            for (int i = 0; i<N; i++ )
            {
                Console.WriteLine("Введите все значение а: ");
                int x = Convert.ToInt32(Console.ReadLine());
               
                mas[i] = x;
            }

            int max = -10000;
            int min = 10000;
                 //max 
                for(int i = 0; i<N; i++)
                {
                    if (mas[i]>max)
                    {
                        max = mas[i];
                    }

                }

                //min 
                for(int i = 0; i<N; i++)
                {
                if (mas[i]<min)
                    {
                        min = mas[i];
                    }

                }

               Console.WriteLine($"Разность наибольшего и наименьшего = {max-min}");

           

        }
    }
}
