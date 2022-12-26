
Console.WriteLine("Введiть 5 оцiнок студента:");
int mark; double sum=0, avg;
for(int i = 1; i <= 5; i++)
{
    Console.Write($"{i})"); mark = int.Parse(Console.ReadLine());
    sum=sum+mark;
}
avg = sum / 5;
if (avg >= 4) Console.WriteLine("Допуск до екзамена");
else Console.WriteLine("Недопуск до екзамена");