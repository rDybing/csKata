using System;
using static System.Console;

namespace csKata {
	class csKata {
		static void Main(string[] args) {
			FizzBuzz.Run();
		}
	}

	class FizzBuzz {
		public static void Run() {
			string text = "";

			for(int i = 1; i <= 100; i++) {
				if (i % 15 == 0) {
					text = "FizzBuzz";
				} else if (i % 5 == 0) {
					text = "Fizz";
				} else if (i % 3 == 0) {
					text = "Buzz";
				} else { 
					text = i.ToString();
				}
				WriteLine("{0:D3} : {1}", i, text);
			}
		}
	}
}