using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
	class Program
	{
		// params 키워드를 지정하여 개수가 가변적인 매개변수를 메소드에 전달할 수 있다.
		private static int Sum(string title, params int[] num)
		{
			int sum = 0;
			Console.WriteLine("Sum of {0}", title);

			// 데이터 들어있는 쪽이 오른쪽, 왼쪽에는 데이터 타입
			foreach (int i in num)
			{
				sum += i;
			}

			Console.WriteLine("Sum :: {0}\n", sum);
			return sum;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Sum("Test1", 1, 2));
			Console.WriteLine(Sum("Test2", 1, 2, 3));
			Console.WriteLine(Sum("Test3", 1, 2, 3, 4));
		}
	}
}
