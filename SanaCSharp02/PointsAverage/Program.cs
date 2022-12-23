// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введіть ваші оцінки: ");
var marks = new int[5];
for (int i = 0; i < marks.Length; i++)
{
    marks[i] = int.Parse(Console.ReadLine());

}
int sum = 0;
for (int i = 0; i < marks.Length; i++)
{
    sum = sum + marks[i];
}
double average = sum / marks.Length;
Console.WriteLine("Середній бал = {0}", average);
if (average >= 4)
{
    Console.WriteLine("Допущений");
}
else
{
    Console.WriteLine("Не допущений");
}


