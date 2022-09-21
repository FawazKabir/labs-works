using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Налоговая налоговая = Налоговая.Инициализация();
            Console.WriteLine("working...");
            Console.WriteLine("identify...");
            Console.WriteLine("Enter your name>> ");
            String фиоП = Console.ReadLine();
            Console.WriteLine("Enter your ticket>> ");
            String билетП = Console.ReadLine();

            Плательщик клиент = new Плательщик(фиоП, билетП);
            int операция = 0;

            do
            {
                Console.WriteLine(клиент.фио + " выбери действие 1 - список налогов 2 - запрос оплаты" +
                    " 0 - выход");
                операция = Convert.ToInt32(Console.ReadLine());

                switch (операция)
                {
                    case 1:
                        налоговая.Каталог(); break;
                    case 2:
                        Console.WriteLine("Код налога >>");
                        String код = Console.ReadLine();
                        налоговая.ВыдачаКниги(код, клиент);
                        break;
                    default: break;

                }
            } 
            while (операция != 0);

            Console.WriteLine("конец работы");
            Console.ReadKey();


        }
    }

    public class Платеж
    {
        public float сумма; //имя
        public String название_налога;
        public String код;
        public Состояние состояние;
    }

    public enum Состояние
    {
        Оплачен,
        НеОплачен
    }

    public enum ВидЛица
    {
        Физическое,
        Юридическое
    }

    public class Плательщик
    {
        public String фио;
        public String номер;

        public Плательщик(String фиоНовый, String номерНовый)
        {
            фио = фиоНовый;
            номер = номерНовый;
        }
    }



    public class Налоговая
    {
        private readonly Dictionary<Платеж, List<Плательщик>> платежи =
            new Dictionary<Платеж, List<Плательщик>>();

        private Налоговая()
        {

        }

        public static Налоговая Инициализация()
        {
            Налоговая res = new Налоговая();
            Платеж новый = new Платеж {
                 сумма= 1000,
                название_налога = "НДФЛ код для оплаты - 001",
                код = "001",
                состояние = Состояние.НеОплачен
            };

            res.платежи.Add(
                новый,
                new List<Плательщик>());

            новый = new Платеж
            {
                сумма = 1000,
                название_налога = "ПФрф код для оплаты - 002",
                код = "002",
                состояние = Состояние.НеОплачен
            };
            res.платежи.Add(
                новый,
                new List<Плательщик>());

            return res;
        }


        public void ВыдачаКниги(String кодПлатежа, Плательщик плательщик)
        {
            var res = (from ob in платежи where ob.Key.код == кодПлатежа select ob).ToList();

            if (res.Count > 0 )
            {
                if (res[0].Key.состояние == Состояние.НеОплачен)
                {
                    res[0].Key.состояние = Состояние.Оплачен;
                    res[0].Value.Add(плательщик);
                    Console.WriteLine("Оплата успешно произведена");
                }
                else
                {
                    Console.WriteLine("Налог уже оплачен");
                }
            }
            else
            {
                Console.WriteLine("Налог уже оплачен");
            }
        }

        public void Каталог()
        {
            foreach (var plt in платежи.Keys)
            {
                Console.WriteLine(plt.название_налога);

            }
        }
    }
}
