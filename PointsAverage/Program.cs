// See https://aka.ms/new-console-template for more information
int count;
Console.Write("Введите количество полученных оценок = ");
count = int.Parse(Console.ReadLine());
double summa = 0;
int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    Console.Write($"Введите текущую оценку от 1 до 5 баллов {i + 1}-  ");
    array[i] = int.Parse(Console.ReadLine());
    while (array[i] > 5)
    {
        Console.WriteLine($"Оценка введена не верно");
        Console.Write($"Введите текущую оценку от 1 до 5 баллов {i + 1}-  ");
        array[i] = int.Parse(Console.ReadLine());
    }
    while (array[i] <= 0)
    {
        Console.WriteLine($"Оценка введена не верно");
        Console.Write($"Введите текущую оценку от 1 до 5 баллов {i + 1}-  ");
        array[i] = int.Parse(Console.ReadLine());
    }
    summa += array[i];
}
double avarage = summa / count;
Console.WriteLine($"avarage = {avarage}");
if (avarage >= 4)
    Console.Write("К экзамену допущен");
else
    Console.Write("К экзамену не допущен");