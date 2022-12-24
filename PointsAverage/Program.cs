double Mark1, Mark2, Mark3, Mark4, Mark5, averageMark;

Console.Write("Введiть першу оцiнку студента: ");
Mark1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введiть другу оцiнку студента: ");
Mark2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введiть третю оцiнку студента: ");
Mark3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введiть четверту оцiнку студента: ");
Mark4 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введiть п'яту оцiнку студента: ");
Mark5 = Convert.ToDouble(Console.ReadLine());

averageMark = (Mark1 + Mark2 + Mark3 + Mark4 + Mark5) / 5;

if(averageMark >= 4)
{
    Console.WriteLine("Студент допущений до екзамену");
}
else Console.WriteLine("Студент не допущений до екзамену");

Console.WriteLine($"Середня оцiнка: {averageMark}");

Console.ReadLine(); //щоб консоль не закривалася відразу