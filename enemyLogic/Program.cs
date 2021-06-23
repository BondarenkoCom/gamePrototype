using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Text;

namespace enemyLogic
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //TestsDatas.IsNougatTooHot();
            //TestsDatas.GetDatas();
            //TestsDatas.GetInfoOrc();
            //TestsDatas.GetStack(5);
            GenerateSandwich.GetGeneratorSandwich();
            //TestSizeEar.SenderEleph();
            //Console.ReadKey();
        
        }
        
    }


    public class TestsDatas
    {
        public static void GetStack(int t)
        {
            object x = 6;
            int y = 7;
            int z = y + t;
        }

        public static bool IsNougatTooHot()
        {
            //int temp = Maker.CheckNougaTemperature();
            Console.WriteLine("Input Nouga Tempreture");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp > 160)
            {

                Person Tom = new Person();
                Tom.name = "Tom";
                Tom.age = 34;
                Tom.specialty = "Mechanic";
                //Tom.tools[1];
                Tom.GetInfo();
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < Tom.tools.Length; i++)

                    Console.WriteLine($"Message:\n  {temp} - is Hot,{Tom.name}  you need fix problem , USE {Tom.tools[i]}");
                Console.WriteLine($"Message:\n Lenght =  {Tom.tools.Length}");
                Console.WriteLine($"Message:\n Rank =  {Tom.tools.Rank}");

                Console.ReadKey();
                return true;
            }
            else
            {

                Person John = new Person();
                John.name = "John";
                John.age = 27;
                John.specialty = "Chief";
                John.GetInfo();

                Console.WriteLine($"{temp} - is Normal,{John.name} you need change resourse");
                return false;
            }
        }


        public static void GetInfoOrc()
        {
            Console.WriteLine("Wait Loading...");
            using (NpcDatasDBContext db = new NpcDatasDBContext())
            {

                var NpcData = db.NpcDatas.ToList();
                string InfoOrc = "information";

                foreach (NpcData u in NpcData)
                {
                    Console.WriteLine($" {InfoOrc} - \n {u.Health}  \n {u.Armor} \n {u.MessageInBattle} \n ");
                }
            }
        }

    }

    //метод конструктор 
    public class Person
    {
        public string name;
        public int age;
        public string specialty;
        public string[] tools = { "Drill", "plasma cutter" };
        
        public void GetInfo()
        {
            Console.WriteLine($"Worker: {name} Age: {age} Specialty: {specialty} ");
        }
    }


    public class GenerateSandwich
    {

        public static void GetGeneratorSandwich()
        {
            GenerateSandwich sandwichMaker = new GenerateSandwich();
            var sandResult = sandwichMaker.GenerateSandwiches(3);

            foreach (var item in sandResult)
            {
                Console.WriteLine(item);
            }

        }




        public List<string> GenerateSandwiches(int sandNumber)
        {
            var sandwiches = new List<string>();

            for(int i = 0;i <= sandNumber -1;i++)
            {
                var sandwich = GetMenuItem();
                sandwiches.Add(sandwich);
            }
            
            return sandwiches;
        }

        public string GetMenuItem()
        {
            Random Randomizer = new Random();
            //сделать Randomizer 
            string[] Meats = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami" };
            string[] Condiments = { "Yellow mustard", "Brown mustard", "Honey mustard", "mayo", "relish", "french dressing" };
            string[] Breads = { "Rye", "white", "wheat", "pumprenickel", "italian bread", "a roll" };

            int MeatIndex = Randomizer.Next(Meats.Length);
            int CondimentsIndex = Randomizer.Next(Condiments.Length);
            int BreadsIndex = Randomizer.Next(Breads.Length);

            // for сделать генерацию  5 бутербродов

            return $"Generate Sandwich:" +
                $"\nUse Bread {Meats[MeatIndex]} " +
                $"use Condiments {Condiments[CondimentsIndex]} " +
                $"use Breads {Breads[BreadsIndex]} ";
        }

    }

    //вывести данный функционал в отдельное приложение MVC
   
   

}



