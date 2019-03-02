using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastExample1
{
	class Program
	{
		static void Main(string[] args)
		{
			short a = 10;
			int b = a; // short은 int형에 묵시적으로 변경된다.
			int c = 50000;  // 이진수로 0000 0000 0000 0000 1100 0011 0101 0000이며
							// Short형으로 변환하면 부호비트가 0에서 1로, 음수가 된다.

			short d = (short)c; // 명시적으로 형 변환 하지않으면 오류
			Console.WriteLine("Short:{0}", d);
		}
	}
}
