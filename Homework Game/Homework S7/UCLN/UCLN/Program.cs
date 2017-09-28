using System;

namespace UCLN
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int j; 
			int smallest, largest; 
			int num; 

			num = 100; 

			largest = 1; 

			for(j=num/2;(j >= 2); j--) { 

				if((largest == 1) & ((num % j) == 0))  
					largest = j; 

			} 

			Console.WriteLine("Uoc So Lon Nhat: " + largest); 
		}
	}
}
