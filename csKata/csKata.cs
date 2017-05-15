using System;
using static System.Console;

namespace csKata {
	class csKata {
		static void Main(string[] args) {
			string input = "";
			bool quit = false;

			help();

			while(quit == false){
				Write("CS :> ");
				input = ReadLine();

				switch (input) {
					case "fizzbuzz":
						FizzBuzz.Run();
						break;
					case "help":
						help();
						break;
					case "quit":
						quit = true;
						break;
				}
			}
		}



		static void help() {
			WriteLine("Available Commands");
			WriteLine(" - fizzbuzz   | the drinking game");
			//WriteLine(" - gcd        | find greatest common denominator");
			//WriteLine(" - clock      | word clock");
			WriteLine(" - help       | list of commands");
			WriteLine(" - quit       | exit this application");
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