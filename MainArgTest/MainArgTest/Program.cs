using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainArgTest
{
	class Program
	{
		// CLR이 Main을 호출할 때 인자를 넣어주는 테스트
		static void Main(string[] args)
		{
			Console.WriteLine(args[0]);
			Console.WriteLine(args[1]);
		}
	}
}
