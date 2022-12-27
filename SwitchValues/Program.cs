using System;

namespace SwitchValues {
    public class Program {
        public static void Main(string[] args) {
            int number = GetNumberInRange("Enter number in range [0, 9]: ", 0, 9);
            string numberInUkrainian = number switch {
                0 => "нуль",
                1 => "один",
                2 => "два",
                3 => "три",
                4 => "чотири",
                5 => "п'ять",
                6 => "шість",
                7 => "сім",
                8 => "вісім",
                9 => "дев'ять",
                _ => "невідоме число"
            };

            Console.WriteLine(numberInUkrainian);
        }

        public static int GetNumberInRange(string message, int min, int max) {
            int number;

            Console.Write(message);
            while (true) {
                if (!int.TryParse(Console.ReadLine(), out number)) {
                    Console.Write("Error! Not a number. Try again: ");
                    continue;
                }
                if (number < min || number > max) {
                    Console.Write($"Error! Enter number in range [{min}, {max}]. Try again: ");
                    continue;
                }
                return number;
            }
        }
    }
}
