using System; // 클래스의 분류이름
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Emp
{
	int i; // 구조체는 Stack에 올라감
}
namespace HelloWorld
{


	// CLR(Commen Language Runtime) : 닷넷의 실행환경
	// 시샵 컴파일러(CSC) > 중간언어(IL) 어셈블리(중간언어) : 실행 또는 배포의 단위(EXE 또는 DLL)이 생성됨.EXE는 바이트코드로 만들어짐
	// CLR은 이 중간언어를 인터프리터(대화형) 방식으로 번역한다. (한문장씩 2진수로 한라인씩 변경하면서 실행됨)
	// 윈도우는 2진수만 실행함

	// 메인 메소드용 스택이 만들어짐 (Method Area) IL이 올라감 > 스택 > 힙
	// 인스턴스 생성할 때마다 메모리힙에 만들어지고
	// 스택에서 주소로 인스턴스를 참조한다.

	// 메소드에어리어에 바이트코드로 번역되어서 올라감
	



	// 메인스레드가 Main을 실행하며 램의 스택에 할당을 해줌
	// Main에 있는 변수는 스택에 올라감


	class Emp
	{
		static public string DeptName;
		public int Empno; // 필드, 인스턴스 변수(상태)

		int i; // Heap 이놈은 자동초기화 되어서 new할때 0으로 초기화됨

		public void GotoOffice() // 인스턴스 메소드(행동)
		{
			int i = 0; // 지역변수 (Stack) Heap보다 속도가 빠르지만 자동초기화가 안됨
		}
	}

	class Program
	{	
		// CLR이 new 안하고 Main메소드(객체 생성안하고)로 직접 호출한다.
		// static 안붙으면 new 없이 호출가능
		static void Main(string[] args)
		{
			Emp.DeptName = "영업부";
			Emp e1 = new Emp(); e1.Empno = 999; // e 객체 참조변수 (객체참조변수)
			Emp e2 = new Emp(); e1.Empno = 1004; // e 객체 참조변수 (객체참조변수)
			Console.WriteLine(Emp.DeptName);

		}
	}
}
