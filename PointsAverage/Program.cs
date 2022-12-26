using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Введіть оцінки студента:");
int[] arr = new int[5];
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    int a = int.Parse(Console.ReadLine());
    if (a > 5 || a < 0)
    {
        Console.WriteLine("Значення може бути в діапазоні 1-5!");
        i--;
    }
    else
    {
        arr[i] = a;
    } }
if (Math.Round(arr.Average()) >= 4)
  {
     Console.WriteLine($"Студента допущено до екзамену. Бал: {Math.Round(arr.Average())}");
  }
else
  {
    Console.WriteLine($"Студента не допущено до екзамену. Бал: {Math.Round(arr.Average())}");
  }


