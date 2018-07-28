using System;
//The sum of the squares of the first ten natural numbers is,
//12 + 22 + ... + 102 = 385
//The square of the sum of the first ten natural numbers is,
//(1 + 2 + ... + 10)2 = 552 = 3025
//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
namespace Euler_6
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = 100;
			var result = DifferenceBetweenSquares(number);
			Console.WriteLine($"The difference between the sum of the squares of the first {number} natural numbers and the square of the sum is {result}.");
			Console.ReadLine();
		}

		public static int DifferenceBetweenSquares(int n)
		{
			int sumOfSquares = 0;
			int squareOfSum = 0;

			for (int i = 0; i <= n; i++)
			{
				sumOfSquares += (int)Math.Pow(i, 2);
				squareOfSum += i;
			}
			return (int)Math.Pow(squareOfSum, 2) - sumOfSquares;
		}
	}
}
