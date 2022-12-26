using System.Text;

namespace While1
{
	internal class Program
	{
		static void inputNumber(ref int value)
		{
			try
			{
				value = int.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Введіть число!");
				inputNumber(ref value);
			}
		}
		static void Main(string[] args)
		{
			/*Завдання 4 - створити проект While1:  
			 * дано натуральне число n. Порахувати:*/

			Console.OutputEncoding = Encoding.Unicode; // підключаємо вивід українською мовою
            Console.InputEncoding = Encoding.Unicode; // підключаємо ввід українською мовою

			int n = 0,i=1;
			Console.Write("Введіть значення n: ");
			inputNumber(ref n);

			double a=0,b=0,c=0, temp=1;
			while (i <= n)
			{
				a += (Math.Pow(-1, i)) / (double)(2 * i + 1);
				b += (1 + 1 / (double)(i * i));
				temp *= i;
				c += temp;
				i++;
			}
			Console.WriteLine($"a = {a}");
			Console.WriteLine($"b = {b}");
			Console.WriteLine($"c = {c}");
		}
	}
}