using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CowsAndGoats
{
    class Livestock
    {
        private int id;
        private String animal;
        private int yearBorn;
        private double costMonth;
        private double costVacc;
        private double amountMilk;

        private double todaysMilk;

        String liveStockData = "";
        String userSelected;
        String myline;

        public Livestock(int id, String animal, int yearBorn, double costMonth, double costVacc, double amountMilk)
        {
            this.id = id;
            this.animal = animal;
            this.yearBorn = yearBorn;
            this.costMonth = costMonth;
            this.costVacc = costVacc;
            this.amountMilk = amountMilk;
        } //end of constructor

        // Profitability = ((amountMilk * todaysMilk) * 365)  / 12) - costMonth - (costVacc / 12))

        public void displayInfo()
        {
            Console.WriteLine("ID: " + id);
        }// end of displayInfo method


		// Public getters for variables
		public int AccessID 
		{
			get { return this.id; }
		}

		public String AccessName 
		{
			get { return this.animal; }
		}

		public int AccessYear
		{
			get { return this.yearBorn;}
		}

		public double AccessCost 
		{
			get { return this.costMonth; }
		}

		public double AccessVacc 
		{
			get { return this.costVacc; }
		}

		public double AccessMilk 
		{
			get { return this.amountMilk; }
		}
    }
}
