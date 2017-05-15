using System;
using static System.Console;

namespace csKata {

    class csKata {
        static void Main() {
            string input;
            bool quit = false;

            help();

            while(quit == false){
                Write("CS :> ");
                input = ReadLine();

                switch (input) {
                    case "fizzbuzz":
                        FizzBuzz.Run();
                        break;
                    case "gcd":
                        GCD.Run();
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
            WriteLine(" - gcd        | find greatest common denominator");
            //WriteLine(" - clock      | word clock");
            WriteLine(" - help       | list of commands");
            WriteLine(" - quit       | exit this application");
            }
    }

    class FizzBuzz {
        public static void Run() {
            string text;

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

    class GCD {
        public static void Run() {
            int high, low, first, second, gcdenom;
            int counter = 0;
            bool exit = false;
            bool reduced = false;

            first = getInput("First");
            second = getInput("Second");

            // get it in right order
            if (first > second) {
                high = first;
                low = second;
            } else {
                high = second;
                low = first;
            }

            // reduce the set if both are divisible by 2
            while (exit == false) {
                if (high % 2 == 0 && low % 2 == 0) {
                    high /= 2;
                    low /= 2;
                    WriteLine($"{high} - {low}");
                    counter++;
                } else {
                    exit = true;
                }
                if (counter > 99) {
                    exit = true;
                }
            }
            while (high != low) {
                reduced = false;
                // reduce one or the other
                if (high % 2 == 0) {
                    high /= 2;
                    reduced = true;
                } else if (low % 2 == 0) {
                    low /= 2;
                }
                // see if swap high/low
                if (high > low) {
                    high = (high - low) / 2;
                } else {
                    low = (low - high) / 2;
                }                
                WriteLine($"Current high: {high}");
            }
            WriteLine();
            gcdenom = Convert.ToInt32(high * Math.Pow(counter, 2));
            WriteLine($"c: {counter} || h: {high}");
            WriteLine($"Greatest common denominator is: {gcdenom}");
        }

        static int getInput(string s) {
            bool ok = false;
            int ret = 0;

            while (ok == false) {
                try {
                    WriteLine($"{s} (1..999)");
                    ret = int.Parse(ReadLine());
                }
                catch (FormatException) {
                    WriteLine("Must be a number!");
                    ok = false;
                }
                if (ret < 1 || ret > 999) {
                    WriteLine("Must be between 1 and 999");
                    ok = false;
                } else {
                    ok = true;
                }
            }
            return ret;
        }
    }
} // end namespace