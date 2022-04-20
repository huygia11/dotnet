using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
	internal class Program
	{
		
		class Horn
		{
			int level = 0;
			public Horn(int level) => this.level = level;
			public void Beep() => Console.WriteLine($"beep level {level}");
		}

		class Car
		{
			Horn horn { set; get; }

			// Bơm (inject) bằng phương thức khởi tạo
			public Car(Horn _horn) => horn = _horn;
			public void Beep()
			{
				horn.Beep();
			}
		}
		
		// Nếu viết code như này thì khi các dependency thay đổi thì các đối tượng dùng dependency đó muốn sử dụng được cũng phải thay đổi theo

		// Vậy để linh hoạt hơn thì các dependency ko được tạo trực tiếp trong các lớp mà nó sẽ được bơm từ bên ngoài vào (injection)




		static void Main(string[] args)
		{
			// Khi sử dụng ta sẽ tạo một lớp horn, lớp horn sẽ được đưa vào (inject) vào lớp Car thông qua phương thức khởi tạo

			// Khi đó nếu các dependency có sự thay đổi thì lớp dùng các dependency sẽ không cần thay đổi gì, bên ngoài chỉ cần thay đổi các khai báo giá trị mới...và nó bơm (inject) vào lớp đó

			/*
				CÁC CÁCH INJECT
					- C1: Inject thông qua phương thức khởi tạo (như trên)
					- C2: Inject thông qua các setter (object.dependency = obj;) cụ thể (car.horn = horn;)
					- C3: Inject thông qua các Interface
			*/


			/*
				THƯ VIỆN DEPENDENCY INJECTION

				Hỗ trợ tính năng, đối tượng gọi là DI Container
				- Cho phép đăng ký các dịch vụ (lớp)
				- Get Service, lấy ra các dịch vụ đó để sử dụng
			*/


			Horn horn = new Horn(22);
			Car car = new Car(horn);
			car.Beep();
			
		}
	}
}
