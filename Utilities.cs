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
		// static classes do not have constructors



		public static void ReadFile()
        {
			// A permanent pointer to Data object
			Data data = new Data();
			
			data.AccessLivestockArray = new Livestock[20]; // size of lines in txt file
            try
            {
                String myLine;
                String[] words; // change here
				int counter = 0; // counter to iterate through array
                TextReader tr = new StreamReader("livestock.txt");
                while ((myLine = tr.ReadLine())!=null)
                {
                    words = myLine.Split(',');
					int id = int.Parse(words[0]);
                    int num = int.Parse(words[1]);
					int yearBorn = int.Parse(words[2]);
					double costMonth = double.Parse(words[3]);
					double costVacc = double.Parse(words[4]);
					double amountMilk = double.Parse(words[5]);


					if (num == 1) 
					{
						String animal = "COW";
						//Console.WriteLine("its a Cow"); // I dont know what the criteria is
						data.AccessLivestockArray[counter] = new Cow(id, animal,yearBorn, costMonth, costVacc, amountMilk); // create a cow object with the correct values
					} 
					else if (num == 2)
					{
						String animal = "GOAT";
						//Console.WriteLine("its a Goat");
						data.AccessLivestockArray[counter] = new Goat(id, animal, yearBorn, costMonth, costVacc, amountMilk); // create a goat object with correct values
					}

                    //Console.ReadKey(); // press a key for next line
					counter++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static void Menu()
        {
			// A permanent pointer to Data object
			Data data = new Data();
			// Initialise the user inputs
            String userInput;
			String userSelected;
			// Output to the menu to display
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
					DisplayLiveStock(data.AccessLivestockArray, userSelected);
                    break;
                case "2": // most milk
                    Console.WriteLine("The cow that produced the most milk:");
                    userSelected = Console.ReadLine();
					MostMilk(data.AccessLivestockArray, userSelected);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3": // least milk
                    Console.WriteLine("The goat that produced the least milk:");
					userSelected = Console.ReadLine();
					LeastMilk(data.AccessLivestockArray, userSelected);
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

		static void DisplayLiveStock(Livestock[] liveStockArray, String userSelected)
        {
			bool match = false;

			for (int i = 0; i < liveStockArray.Length; i++) {
				if (liveStockArray [i].AccessID == int.Parse(userSelected)) {
					Console.WriteLine ("");
					Console.WriteLine (liveStockArray [i].AccessName);
					Console.WriteLine ("ID:                 " + liveStockArray [i].AccessID);
					Console.WriteLine ("Year Born:          " + liveStockArray [i].AccessYear);
					Console.WriteLine ("Maintenance Cost:  $" + liveStockArray [i].AccessCost);
					Console.WriteLine ("Vaccination Cost:  $" + liveStockArray [i].AccessVacc);
					Console.WriteLine ("Milk per day:       " + liveStockArray [i].AccessMilk + " litres");
					Console.WriteLine ("");
					match = true;
					Console.WriteLine ("Press any key to return to the menu...");
					Console.ReadKey ();
					break;
				}
			}
            
			if(!match)
            {
                Console.Write("there is no match");
                Console.ReadKey();
            }
        }

		static void MostMilk(Livestock[] liveStockArray, String userSelected)
        {
			bool match = false;
			for (int i = 0; i < liveStockArray.Length; i++) {
				if (liveStockArray [i].AccessID == int.Parse(userSelected)) {
					Console.WriteLine ("");
					Console.WriteLine (liveStockArray [i].AccessName);
					Console.WriteLine ("ID:                 " + liveStockArray [i].AccessID);
					Console.WriteLine ("Year Born:          " + liveStockArray [i].AccessYear);
					Console.WriteLine ("Maintenance Cost:  $" + liveStockArray [i].AccessCost);
					Console.WriteLine ("Vaccination Cost:  $" + liveStockArray [i].AccessVacc);
					Console.WriteLine ("Milk per day:       " + liveStockArray [i].AccessMilk + " litres");
					Console.WriteLine ("");
					match = true;
					Console.WriteLine ("Press any key to return to the menu...");
					Console.ReadKey ();
					break;
				}
			}
            
			if (!match)
            {
                Console.Write("there is no match");
                Console.ReadKey();
            }
        }

        static void LeastMilk(Livestock[] liveStockArray, String userSelected)
        {
			bool match = false;
			for (int i = 0; i < liveStockArray.Length; i++) {
				if (liveStockArray [i].AccessID == int.Parse(userSelected)) {
					Console.WriteLine ("");
					Console.WriteLine (liveStockArray [i].AccessName);
					Console.WriteLine ("ID:                 " + liveStockArray [i].AccessID);
					Console.WriteLine ("Year Born:          " + liveStockArray [i].AccessYear);
					Console.WriteLine ("Maintenance Cost:  $" + liveStockArray [i].AccessCost);
					Console.WriteLine ("Vaccination Cost:  $" + liveStockArray [i].AccessVacc);
					Console.WriteLine ("Milk per day:       " + liveStockArray [i].AccessMilk + " litres");
					Console.WriteLine ("");
					match = true;
					Console.WriteLine ("Press any key to return to the menu...");
					Console.ReadKey ();
				}
			}
			if (!match)
            {
                Console.Write("there is no match");
                Console.ReadKey();
            }
        }
    }
}
