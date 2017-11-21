using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CowsAndGoats
{
    public static class Utilities
    {
        static void ReadFile()
        {
            try
            {
                String myLine;
                String[] liveStockArray;
                TextReader tr = new StreamReader("livestock.txt");
                while ((myLine = tr.ReadLine())!=null)
                {
                    liveStockArray = myLine.Split(',');
                    int num = int.Parse(words[2]);
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        static void Menu()
        {
            String userInput;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("----------- BOVINE & CAPRINE FARM MENU -----------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1) Display livestock information by ID");
            Console.WriteLine("2) Display cow that produced the most milk");
            Console.WriteLine("3) Display goat that produced least amount of milk");
            Console.WriteLine("4) Calculate farm profit");
            Console.WriteLine("5) Display unprofitable livestock");
            Console.WriteLine("0) Exit");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Enter an Option: ");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Write("Enter Livestock ID: ");
                    userSelected = Console.ReadLine();
                    DisplayLiveStock(liveStockData, userSelected);
                    break;
                case "2": // most milk
                    Console.WriteLine("The cow that produced the most milk:");
                    userSelected = Console.ReadLine();
                    MostMilk(liveStockData, userSelected);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3": // least milk
                    Console.WriteLine("The goat that produced the least milk:");
                    userSelected = Console.ReadLine();
                    LeastMilk(liveStockData, userSelected);
                    Console.Clear();
                    Console.ReadKey();
                    break;
                case "4": // profit
                    Console.WriteLine("Selection 4");
                    userSelected = Console.ReadLine();
                    Console.Clear();
                    Console.ReadKey();
                    break;
                case "5": // unprofitable
                    Console.WriteLine("Selection 5");
                    userSelected = Console.ReadLine();
                    Console.Clear();
                    Console.ReadKey();
                    break;
                case "0": // Exit
                    Console.WriteLine("Selection 0");
                    userSelected = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        static void DisplayLiveStock(String liveStockData, String userSelected)
        {
            while ((myline = true.ReadLine()) != null)
                liveStockArray = myline.Split(',');
            if (liveStockArray[0].Contains(userSelected))

            {
                Console.WriteLine("");
                Console.WriteLine(liveStockArray[1]);
                Console.WriteLine("ID:                 " + liveStockArray[0]);
                Console.WriteLine("Year Born:          " + liveStockArray[2]);
                Console.WriteLine("Maintenance Cost:  $" + liveStockArray[3]);
                Console.WriteLine("Vaccination Cost:  $" + liveStockArray[4]);
                Console.WriteLine("Milk per day:       " + liveStockArray[5] + " litres");
                Console.WriteLine("");
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
            else
            {
                Console.Write("there is no match");
                Console.ReadKey();
            }
        }

        static void MostMilk(String liveStockData, String userSelected)
        {
            while ((myline = true.ReadLine()) != null)
                liveStockArray = myline.Split(',');
            if (liveStockArray[0].Contains(userSelected))

            {
                Console.WriteLine("");
                Console.WriteLine(liveStockArray[1]);
                Console.WriteLine("ID:                 " + liveStockArray[0]);
                Console.WriteLine("Year Born:          " + liveStockArray[2]);
                Console.WriteLine("Maintenance Cost:  $" + liveStockArray[3]);
                Console.WriteLine("Vaccination Cost:  $" + liveStockArray[4]);
                Console.WriteLine("Milk per day:       " + liveStockArray[5] + " litres");
                Console.WriteLine("");
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
            else
            {
                Console.Write("there is no match");
                Console.ReadKey();
            }
        }

        static void LeastMilk(String liveStockData, String userSelected)
        {
            while ((myline = true.ReadLine()) != null)
                liveStockArray = myline.Split(',');
            if (liveStockArray[0].Contains(userSelected))

            {
                Console.WriteLine("");
                Console.WriteLine(liveStockArray[1]);
                Console.WriteLine("ID:                 " + liveStockArray[0]);
                Console.WriteLine("Year Born:          " + liveStockArray[2]);
                Console.WriteLine("Maintenance Cost:  $" + liveStockArray[3]);
                Console.WriteLine("Vaccination Cost:  $" + liveStockArray[4]);
                Console.WriteLine("Milk per day:       " + liveStockArray[5] + " litres");
                Console.WriteLine("");
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
            else
            {
                Console.Write("there is no match");
                Console.ReadKey();
            }
        }
    }
}
