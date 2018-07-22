using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler_3
{
	//The prime factors of 13195 are 5, 7, 13 and 29.

	//What is the largest prime factor of the number 600851475143 ?
	class Program
	{
		static void Main(string[] args)
		{
			var primeFactors = PrimeFactors(600851475143);
			var largestPrimeFactors = primeFactors.LastOrDefault();

			Console.WriteLine($"The Largest Prime Factor of 600851475143 is {largestPrimeFactors}");
			Console.ReadLine();
		}

		public static List<int> PrimeFactors(long number)
		{
			var listOfPrimes = new List<int>();

			for (int i = 2; i <= number; i++)
			{
				while (number % i == 0)
				{
					listOfPrimes.Add(i);
					number = number / i;
				}
			}

			return listOfPrimes;
		}
	}
}
