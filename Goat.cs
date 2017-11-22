using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CowsAndGoats
{
    class Goat: Livestock
    {
		// Each object class must have a constructor
		public Goat(int id, String animal, int yearBorn, double costMonth, double costVacc, double amountMilk)
			:base (id, animal, yearBorn, costMonth, costVacc, amountMilk)
		{
		}


        public void LeastMilk()
        {
            // display data of goat that produced least amount of milk
            double leastMilk = 0;
            for (double d = 1; d <= 20; d++)
            {
                // find lowest number in array block 5
            }

        }
    }
}
