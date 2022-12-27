double average = 0, a;
Console.WriteLine("Введіт 5 оцінок");
for (int i = 1; i <= 5; i++)
{
    Console.Write(i + " Оцінка: ");
    a = double.Parse(Console.ReadLine());
    average = a + average;
}
average /= 5;
if (average >= 4)
    Console.WriteLine("Допуск");
else
    Console.WriteLine("Не допуск");