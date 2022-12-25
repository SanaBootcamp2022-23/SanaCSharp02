using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
int grade;
int summa=0;
double avg;
Console.WriteLine("Введіть оцінки студента:");
for (int i = 0; i < 5; i++) 
{
    grade = int.Parse(Console.ReadLine());
    if (grade < 0) Console.WriteLine("Error: Grade can not be < 0");
    summa += grade;
}
avg = summa / 5.0;
if (avg < 4.0) Console.WriteLine($"Студент НЕ допущений до екзамену\nЙого/її оцінка - {avg}.");
else Console.WriteLine($"Студент допущений до екзамену\nЙого/її оцінка - {avg}.");