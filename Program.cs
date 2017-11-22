using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CowsAndGoats
{
    class Program
    {
        public static void Main(string[] args)
        {
			// Creates the Livestock Array from file
            Utilities.ReadFile();
			// Launch the Menu
            Utilities.Menu();
			// end of program
			Console.WriteLine ("Press Any Key to exit;");
			Console.ReadKey ();
        }
    }
}
