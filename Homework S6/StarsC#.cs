using System;

namespace StarsC
{
	class MainClass
	{
		public static void Main (string[] args)
		{ 
			for (int h = 0; h < 40; h++) 
			{
				Console.Write ("*");
			}

			Console.WriteLine ();
			for (int v = 0; v < 25; v++) 
			{
				Console.Write ("X*");
			}		
			Console.WriteLine (" ");
			Console.WriteLine ();
			for (int d = 0; d < 10; d++) 
			{
				for (int t = 0; t < 10; t++) 
				{
					Console.Write ("X*");	
				}
				Console.WriteLine ();
			}
		}
	}
}
