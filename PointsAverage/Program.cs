using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Введіть оцінки студента(5):");
int[] arr = new int[5];
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    sum += arr[i];
}
double average = sum / arr.Length;
if (average >= 4)
{
    Console.WriteLine($"Студент допущений(Середній бал: {average})");
}
else
{
    Console.WriteLine($"Студент не допущений(Середній бал: {average})");
}