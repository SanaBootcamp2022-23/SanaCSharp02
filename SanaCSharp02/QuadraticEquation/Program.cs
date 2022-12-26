using System.Runtime.CompilerServices;
using System.Text;

namespace QuadraticEquation
{

	internal class Program
	{

		static void inputNumber(string variableName, ref double value)
		{
			Console.Write($"Введіть значення змінної {variableName}: ");
			try
			{
				value = double.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Введіть число!");
				inputNumber(variableName, ref value);
			}
		}

		static void Main(string[] args)
		{
			/*Завдання 1 - створити проект QuadraticEquation та написати програму 
			розв’язання квадратного рівняння.З клавіатури вводяться три числа a, b, c. 
			Вивести на екран значення дискримінанту та коренів рівняння. Якщо розв’язків два, 
			то вивести два числа x1, x2. Якщо розв’язок один -то вивести одне число.
			Якщо розв’язків немає, то вивести відповідне повідомлення. :*/

			Console.OutputEncoding = Encoding.Unicode; // підключаємо вивід українською мовою
			Console.InputEncoding = Encoding.Unicode; // підключаємо ввід українською мовою

			double a = 0, b = 0, c = 0;

			Console.WriteLine("Введіть значення а, b, c у стовпчик:");
			inputNumber("a", ref a);
			inputNumber("b", ref b);
			inputNumber("c", ref c);

			double discriminant = b * b - 4 * a * c;
			double x1=0,x2=0;

			if(discriminant < 0) {
				Console.WriteLine("Дискримінант менше за нуль - розв'язків рівняння не існує");
				Environment.Exit(1);
			}
			else if(discriminant == 0)
			{
				x1 = -b / (2 * a);
				Console.WriteLine($"x1 = {x1}");
                Environment.Exit(1);
            }
			else
			{
				x1 = (-b + Math.Sqrt(discriminant))/(2*a);
				x2 = (-b - Math.Sqrt(discriminant))/(2*a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                Environment.Exit(1);
            }

			
		}
	}
}