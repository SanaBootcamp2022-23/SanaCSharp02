using System;

namespace SwitchValues {
    public class Program {
        public static void Main(string[] args) {
            int n = GetNaturalNumber("Enter natural number: ");

            double a = 0, b = 0, c = 0;
            double currentFactorial = 1;

            for (int i = 1; i <= n; ++i) {
                a += Math.Pow(-1, i) / (2.0 * i + 1);
                b += 1 + 1.0 / Math.Pow(i, 2);

                currentFactorial *= i;
                c += currentFactorial;
            }

            Console.WriteLine("a: {0:0.000}", a);
            Console.WriteLine("b: {0:0.000}", b);
            Console.WriteLine("c: {0:0}", c);
        }

        public static int GetNaturalNumber(string message) {
            int naturalNumber;

            Console.Write(message);
            while (true) {
                if (!int.TryParse(Console.ReadLine(), out naturalNumber)) {
                    Console.Write("Error! Not a number. Try again: ");
                    continue;
                }
                if (naturalNumber <= 0) {
                    Console.Write($"Error! Enter natural number. Try again: ");
                    continue;
                }
                return naturalNumber;
            }
        }
    }
}
