using System;
using System.Collections.Generic;

namespace Euler_7
{
	class Program
	{
		static void Main(string[] args)
		{
			var p = new Program();
			var listOfPrimes = p.PrimeNumbers();
			p.PrintResult(listOfPrimes[10000]);
		}

		public List<int> PrimeNumbers()
		{
			var listOfPrimes = new List<int>();
			for (int i = 0; i < 1000000; i++)
			{
				var prime = IsItAPrime(i);
				if (prime)
				{
					listOfPrimes.Add(i);
				}
			}
			return listOfPrimes;
		}
		public static bool IsItAPrime(int n)
		{
			if (n <= 1) return false;
			if (n == 2) return true;
			if (n % 2 == 0) return false;

			var limit = (int)Math.Floor(Math.Sqrt(n));

			for (int i = 3; i <= limit; i += 2)
			{
				if (n % i == 0) return false;
			}
			return true;
		}

		public void PrintResult(int result)
		{
			Console.WriteLine($"The 10,001 Prime number is {result}");
			Console.ReadLine();
		}
	}
}

