using System;
using System.Runtime.InteropServices; // 마샬 사용하기 위해서
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteropServices
{
	class Program
	{
		static void Main(string[] args)
		{
			int iSize = sizeof(int); // 인트형 몇바이트냐
			Console.WriteLine("int형 바이트길이 : {0}", iSize);

			Type myType = typeof(int); // 원형
			Console.WriteLine("typeof(int) : {0}", myType);

			int i = 10;
			Type myType2 = i.GetType(); // 원형
			Console.WriteLine("i.GetType() : {0}", myType2);

			int j = 99; // 변수의 사이즈 궁금할 때,사용
			Console.WriteLine("Size of j : {0}", Marshal.SizeOf(j));
		}
	}
}
