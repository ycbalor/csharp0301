using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	//// Value Type
	//class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		int a = 1;
	//		int b = a;

	//		Console.WriteLine(a);
	//		Console.WriteLine(b);

	//		b = 2;
	//		Console.WriteLine(a);
	//		Console.WriteLine(b);
	//	}
	//}

	// Reference Type
	class RType
	{
		public object value;
	}

	class Program
	{
		static void Main(string[] args)
		{
			RType a = new RType();
			RType b = new RType();

			a.value = 1;
			b = a; // a가 참조하는 것을 b도 참조한다.

			Console.WriteLine(a.value);
			Console.WriteLine(b.value);

			a.value = 2;
			Console.WriteLine(a.value);
			Console.WriteLine(b.value);
		}
	}
}
