using System;

namespace BMI_Calculator_C
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Your Weight In Kg? ");

			float kg = float.Parse(Console.ReadLine ());

			Console.Write ("Your Height In CM? ");

			float m = float.Parse(Console.ReadLine ());

			float BMI = kg / ((m / 100) * (m / 100));

			Console.WriteLine ("Your BMI number is " + BMI);

			if (BMI < 16)
			{
				Console.WriteLine ("You're Severely Underweight,Go Eat Something.");
			}
			if (BMI <= 20 && BMI < 18.5)
			{
				Console.WriteLine("You're a bit underweight"); 
			}
			if (BMI >= 18.5 && BMI <= 25)
			{
				Console.WriteLine("You're Perfect The Way You Are ε>"); 
			}
			if (BMI > 25 & BMI < 30)
			{
				Console.WriteLine("You're A Bit Overweight,Lose Some And You'll Be In Good Shape"); 
			}
			if (BMI > 30)
			{
				Console.WriteLine("You're Obese,Keep This Up And You Might Die Soon.");
			}

			Console.ReadLine();
		}
	}
}
