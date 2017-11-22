using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CowsAndGoats
{
    class Cow: Livestock
    {
		// each object class must have a constructor
		public Cow(int id, String animal, int yearBorn, double costMonth, double costVacc, double amountMilk)
			:base (id, animal, yearBorn, costMonth, costVacc, amountMilk)
		{
		}

        public void MostMilk()
        {
            // display data of cow that produced highest amount of milk
            double mostMilk = 0;
            for (double d = 1; d >= 20; d++)
            {
                // find highest number in array block 5
            }

        }

    }
}
