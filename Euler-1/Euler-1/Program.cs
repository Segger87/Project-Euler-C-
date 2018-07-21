using System;

namespace Euler_1
{
	//	If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

	//Find the sum of all the multiples of 3 or 5 below 1000.
	class Program
	{
		static void Main(string[] args)
		{
			var multiples = MultiplesOf3And5(1000);
			Console.WriteLine($"The sum of all multiples of 3 and 5 up to a 1000 is {multiples}");
			Console.ReadLine();
		}

		public static int MultiplesOf3And5(int count)
		{
			int x = 0;

			for (int i = 0; i < count; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
					x += i;
			}
			
			return x;
		}
	}
}
