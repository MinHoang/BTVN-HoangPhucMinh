using System;

namespace Convert
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int original_number = 123456789;
			int converted_number;
			int devided_number;
			while (true) 

			{
				converted_number = (original_number % 2);
				devided_number = (original_number / 2);
				Console.Write (converted_number);
				original_number = devided_number;
				if (devided_number == 0) 
				{
					Console.WriteLine ();
					break;
				}
			}
		}
	}
}
