using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{

	class Triangle1
	{
		// 멤버 변수 선언 할때는 언더바를 넣어주는게 관례이다.
		private int width;
		private int height;
		private int area;

		// 멤버 변수를 다룰 속성을 선언한다.
		public int Width { get { return width; } set { width = value; } }
		public int Height { get { return height; } set { height = value; } }
		public int Area { get { return width * height / 2; } }
	}

	class Triangle2
	{
		// 자동 구현 속성
		public int Width { get; set; }
		public int Height { get; set; }
		public int Area { get { return Width * Height / 2; } }
	}

	public class Test
	{
		static void Main()
		{
			Triangle1 t1 = new Triangle1();
			t1.Width = 6;
			t1.Height = 6;

			Console.WriteLine("밑변은 {0}", t1.Width);
			Console.WriteLine("높이은 {0}", t1.Height);
			Console.WriteLine("면적은 {0}", t1.Area);

			Triangle2 t2 = new Triangle2();
			t2.Width = 8;
			t2.Height = 8;

			Console.WriteLine("밑변은 {0}", t2.Width);
			Console.WriteLine("높이은 {0}", t2.Height);
			Console.WriteLine("면적은 {0}", t2.Area);

		}
	}

	
	//class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		Emp e = new Emp();
	//		e.Empno = 999; // LValue일 때는 SET이 호출
	//		int i = e.Empno; // RValue일 때는 GET이 호출			
	//	}
	//}

	//class Emp
	//{
	//	// 속성은 private 변수를 다루기 위한 것이다.
	//	// 속성은 채널을 가지고 있다. 
	//	// 변수앞에 접근 제어자를 안쓰면 private가 default이다.
	//	private int _Empno; // 외부에서 못들어오게 private로 막아라. (캡슐화)

	//	public int Empno // 일반 속성
	//	{
	//		get
	//		{
	//			return _Empno;
	//		}
	//		set
	//		{
	//			this._Empno = value;
	//		}
	//	}

	//	//// 자동 구현 프로퍼티
	//	//public int Empno
	//	//{
	//	//	get;
	//	//	set;
	//	//} = 999 <- 자동 구현일때만 가능
	//}
}
