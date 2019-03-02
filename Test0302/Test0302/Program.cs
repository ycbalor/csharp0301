using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Test0302
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			Console.WriteLine("숫자 입력(구분값 ,):");
//			string str = Console.ReadLine();
//			str.Trim();
//			string[] strarr = str.Split(',');

//			for (int i = 0; i < strarr.Length; i++)
//			{
//				Console.Write(strarr[i] + " ");
//			}
//		}
//	}
//}
//namespace Test0302
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			Console.WriteLine("입력숫자:");
//			string str = Console.ReadLine();

//			int num = Convert.ToInt32(str);
//			int sum = 0;


//			Console.WriteLine("{0}까지의 숫자: ", num);

//			for(int i = 1; i <= num; i++)
//			{
//				sum += i;
//				Console.Write(i + " ");
//			}
//			Console.WriteLine();

//			Console.WriteLine("{0}까지 숫자의 합은: {1}", num, sum);
//		}
//	}
//}

//namespace Test0302
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			int[] num = new int[10];
//			int sum = 0;
//			double average = 0;
//			for (int i = 0; i < 10; i++)
//			{
//				num[i] = Convert.ToInt32(Console.ReadLine());
//				Console.WriteLine("숫자-{0}: {1}", i + 1, num[i]);
//				sum += num[i];
//				average = sum / 10.0;
//			}
//			Console.WriteLine("합: {0}", sum);
//			Console.WriteLine("평균: {0}", average);
//		}
//	}
//}


namespace Test0302
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("출력을 원하는 구구단 단수:");
			string str = Console.ReadLine();
			int num = Convert.ToInt32(str);

			for (int i = 1; i <= num; i++)
			{
				for (int j = 1; j <= 9; j++)
				{
					Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
				}
			}
		}
	}
}
