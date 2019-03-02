using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	class Program
	{
		static void Main(string[] args)
		{
			object a = null;
			object b = "abc";

			// Null-Coalesce Opertor, a, b,중 null이 아닌 것을 c에 대입
			// 둘다 null이 아니면 앞에 있는 걸 밀어 넣어준다.
			object c = a ?? b;
			Console.WriteLine(c);


			object d;

			if (a != null)
			{
				d = a;
			}
			else
			{
				d = b;
			}

			object e;
			e = (a != null) ? a : d; // 삼항 연상자, ternary operator
			Console.WriteLine(e);
		}
	}
}
