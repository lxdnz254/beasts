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
        static void Main(string[] args)
        {
            String[] liveStockArray = new String[6];
            TextReader tr = new StreamReader(Livestock.liveStockData);
            Utilities.ReadFile();
            Utilities.Menu();
        }
    }
}
