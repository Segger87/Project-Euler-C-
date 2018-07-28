using System;
//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
namespace Euler_5
{
	class Program
	{
		static void Main(string[] args)
		{
			SmallestNumberDivisibleByN(20);
			Console.ReadLine();
		}

		public static void SmallestNumberDivisibleByN(int n)
		{
			for (int i = n; i < 1000000000; i += n)
			{
				int j = n;

				while (i % j == 0 && j > 2)
				{
					j--;
					if (j == 2) //all numbers are divisible by 1 so can end on 2
					{
						Console.WriteLine($"The smallest positive number divisibile by all numbers from 1 to {n} is {i}");
						return;
					}
				}
			}
		}
	}
}
