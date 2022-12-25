// See https://aka.ms/new-console-template for more information
Console.WriteLine("Калькулятор середнього балу");
Console.WriteLine("Введіть 5 оцінок студента:");

double score1 = Convert.ToDouble(Console.ReadLine());
double score2 = Convert.ToDouble(Console.ReadLine());
double score3 = Convert.ToDouble(Console.ReadLine());
double score4 = Convert.ToDouble(Console.ReadLine());
double score5 = Convert.ToDouble(Console.ReadLine());

double averageScore = (score1 + score2 + score3 + score4 + score5) / 5;

if (averageScore >= 4)
{
    Console.WriteLine("Студенту дозволено брати участь у екзамені.");
}
else
{
    Console.WriteLine("Студенту не дозволено брати участь у екзамені.");
}
Console.ReadLine();