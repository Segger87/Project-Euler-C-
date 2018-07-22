using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_4
{
	//A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

	//Find the largest palindrome made from the product of two 3-digit numbers.
	class Program
	{
		static void Main(string[] args)
		{
			var multiplesOf3 = MultiplesOfIntegers(999);
			var listOfPalindromes = new List<int>();

			foreach (var multiple in multiplesOf3.Values)
			{
				var isTheNumberApalindrome = ReverseNumber(multiple);
				foreach (var palindrome in isTheNumberApalindrome)
				{
					listOfPalindromes.Add(palindrome);
				}
			}
			listOfPalindromes.Sort();

			var largestPalindrome = listOfPalindromes.Distinct().ToList().LastOrDefault();
			var multiplicationsToAchievePalindrome = multiplesOf3.FirstOrDefault(x => x.Value == largestPalindrome).Key;

			Console.WriteLine($"The Largest Palindrome of a 3 digit number is {largestPalindrome} which is achieved by {multiplicationsToAchievePalindrome}");
			Console.ReadLine();
		}

		public static Dictionary<string, int> MultiplesOfIntegers(int numbersToMultiple)
		{
			int result = 0;
			var dictionaryOfMultiplesAndTheirResults = new Dictionary<string, int>();
			int[] arrayOfMultiplications = new int[2];

			for (int i = 1; i <= numbersToMultiple; i++)
			{
				for (int j = 2; j < numbersToMultiple; j++)
				{
					arrayOfMultiplications[0] = i;
					arrayOfMultiplications[1] = j;
					result = i * j;
					dictionaryOfMultiplesAndTheirResults.Add($"{i.ToString()} * {j.ToString()}", result);
				}

			}

			return dictionaryOfMultiplesAndTheirResults;
		}

		public static List<int> ReverseNumber(int number)
		{
			int reverse = 0;
			int tempNumber = number;
			var listOfPalindromes = new List<int>();

			for (int i = 0; i <= number; i++)
			{
				while (number > 0)
				{
					reverse = (reverse * 10) + (number % 10);
					number = number / 10;
				}
				if (tempNumber == reverse && tempNumber > 10)
					listOfPalindromes.Add(tempNumber);
			}

			return listOfPalindromes;
		}
	}
}
