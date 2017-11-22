using System;

namespace CowsAndGoats
{
	public class Data
	{
		private static Livestock[] livestockArray;

		public Data ()
		{
		}

		internal Livestock[] AccessLivestockArray
		{
			get { return livestockArray; }
			set { livestockArray = value;}
		}

	}
}

