using System;


namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            getDateTimeNow.NeedTime();

            IfDemo.CreateifMethod();
            //numberPI.calculateNum(10.0);
            //CapsLockChecker.MainCheckCaps();
        }
    }

    class IfDemo
    {
        public static void CreateifMethod()
        {
            int a, b, c;
            a = 2;
            b = 3;

            if (a < b)
            {
                Console.WriteLine("a low b");
            }
            if (a == b)
            {
                Console.WriteLine("THis not inresting");
            }

            Console.WriteLine();
            c = a - b;
        } 

    }
    class numberPI
    {
        public static void calculateNum(double radius)
        {
            //Console.WriteLine(radius);
            double area;

            area = radius * radius * 3.1416;

            Console.WriteLine($"Площадь равна {area}" );
        }
    }
    class CapsLockChecker
    {
        public static void MainCheckCaps()
        {
            if (Console.CapsLock == true)
            {
                CapsLockChecker.BadDay();
            }
            else
            {
                CapsLockChecker.KeyDownEd();
            }
        }

        public static void BadDay()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string message = "CapsLock ON";
                string messageError = "ERROR";
                Console.WriteLine(message);

                try
                {

                    int InputPassword = 1111;
                    int InpuResult = Convert.ToInt32(Console.ReadLine());

                    if (InpuResult == InputPassword)
                    {
                        _ = Console.CapsLock == false;
                    CapsLockChecker.KeyDownEd();
                    }
                    else
                    {
                        for (int i = 0; i <= 10; i++)
                        {
                            Console.WriteLine(message);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine($"ошибка - Exception = {messageError}");

                }



            }
        

           public static void KeyDownEd()
            {
           //train for make move for Game Heroes
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("CapsLock OFF");


            }

    }
    class getDateTimeNow
    {
        public static void NeedTime()
        {
            var date1 = new DateTime();
            date1 = DateTime.Now;
            Console.WriteLine($"Load Date...{date1}");

        }
    }
}
