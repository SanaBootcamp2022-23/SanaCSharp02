using System.Text;

namespace PointsAverage
{
	internal class Program
	{
		static void inputNumber(ref double value)
		{
			try
			{
				value = double.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Введіть число!");
				inputNumber( ref value);
			}
		}
		static void Main(string[] args)
		{
			/*Завдання 2 - створити проект PointsAverage: 
			 * користувач з клавіатури вводить 5 оцінок студента. 
			 * Визначити, чи допущений студент до екзамену.
			 * Студент отримує допуск, якщо його середній бал 4 і вище.*/

			Console.OutputEncoding = Encoding.Unicode; // підключаємо вивід українською мовою
			Console.InputEncoding = Encoding.Unicode; // підключаємо ввід українською мовою


			Console.WriteLine("Введіть 5 оцінок у стовпчик: ");
			int n = 5;
			double sum=0, temp=0;
			for (int i = 0; i < n; i++)
			{
				inputNumber(ref temp);
				sum += temp;
			}
			double avg = sum / n;
			Console.WriteLine($"Середній бал студента: {avg:0.00}");
			if (avg >= 4)
			{
				Console.WriteLine("До екзамену допущений!");
			}
			else
			{
				Console.WriteLine("До екзамену не допущений!");
			}
		}
	}
}