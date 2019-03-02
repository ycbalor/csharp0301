using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test30
{
	class Program
	{
		static void Main(string[] args)
		{
			// 명명된 인수
			Sum(j:1, i:2);

			// 선택적 인수
			SayHello(age:20);
		}

		static int Sum(int i, int j)
		{
			int result = i + j;
			Console.WriteLine(result);
			return result;
		}

		// 파라미터로 아무것도 안넘어오면 name은 ""로 age는 0으로 초기화
		static void SayHello(string name = "", int age = 0)
		{
			Console.WriteLine("안녕, name = {0}, age = {1}", name, age);
		}
	}
}
