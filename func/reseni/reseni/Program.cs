using System;

namespace reseni
{
	class Program
	{
		// Zakladni ulohy
		
		public static int SeriesSum(int n)
		{
			int sum = 0;
			for (int i = 1; i <= n; i++)
				sum += i;
			return sum;
		}
		
		public static int DivisorsCount(int n)
		{
			int count = 0;
			for (int divisor = 1; divisor <= n; divisor++)
				if (n % divisor == 0) // pokud je cislo 'n' delitelne cislem 'divisor'
					count++;
			return count;
		}
		
		public static bool IsPrime(int number)
		{
			return (DivisorsCount(number) == 2);
		}
		
		public static int DigitSum(int n)
		{
			int sum = 0;
			while (n > 0)
			{
				sum += n % 10;
				n = n / 10;
			}
			
			return sum;
		}
		
		// Bonusove ulohy
		
		public static int KthPrime(int k)
		{
			int count = 0, num = 0;
			while (count < k)
			{
				num++;
				if (IsPrime(num))
					count++;
			}
			return num;
		}
		
		public static void Primes(int k)
		{
			int count = 0, num = 0;
			while (count < k)
			{
				num++;
				if (IsPrime(num))
				{
					Console.Write(num + " ");
					count++;
				}
			}
			Console.WriteLine();
		}
		
		// Testy
		
		public static void Main(string[] args)
		{
			Console.WriteLine(SeriesSum(1));
			Console.WriteLine(SeriesSum(2));
			Console.WriteLine(SeriesSum(5));
			Console.WriteLine(SeriesSum(1000));
			
			Console.WriteLine("------------------");
			
			Console.WriteLine(DivisorsCount(1));
			Console.WriteLine(DivisorsCount(5));
			Console.WriteLine(DivisorsCount(10));
			Console.WriteLine(DivisorsCount(42));
			
			Console.WriteLine("------------------");
			
			Console.WriteLine(IsPrime(1));
			Console.WriteLine(IsPrime(2));
			Console.WriteLine(IsPrime(3));
			Console.WriteLine(IsPrime(42));
			
			Console.WriteLine("------------------");
			
			Console.WriteLine(DigitSum(0));
			Console.WriteLine(DigitSum(274));
			Console.WriteLine(DigitSum(123456789));
			
			Console.WriteLine("------------------");
			
			Console.WriteLine(KthPrime(1));
			Console.WriteLine(KthPrime(2));
			Console.WriteLine(KthPrime(10));
			Console.WriteLine(KthPrime(100));
			
			Console.WriteLine("------------------");
			
			Primes(2);
			Primes(5);
			
			Console.ReadKey(true);
		}
	}
}