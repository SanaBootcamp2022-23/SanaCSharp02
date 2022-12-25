double a, b, c;

Console.WriteLine("Введiть число а: ");
while (!Double.TryParse(Console.ReadLine(),out a))
{
    Console.WriteLine("Введено невiрне значення для числа а!\n Спробуйте ще раз!");
}

Console.WriteLine("Введiть число b: ");
while (!Double.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Введено невiрне значення для числа а!\n Спробуйте ще раз!");
}

Console.WriteLine("Введiть число c: ");
while (!Double.TryParse(Console.ReadLine(), out c))
{
    Console.WriteLine("Введено невiрне значення для числа а!\n Спробуйте ще раз!");
}

double Discrim = Math.Pow(b,2) - 4 * a * c;

Console.WriteLine($"\nДискримiнант = {Discrim}\n");

if (Discrim > 0)
{
    Console.WriteLine("Два коренi рiвняння");
    double x1 = (-b + Math.Sqrt(Discrim)) / 2 * a;
    double x2 = (-b - Math.Sqrt(Discrim)) / 2 * a;
 
    Console.WriteLine($"x1 = {x1:F3}\nx2 = {x2:F3}");
}
else if(Discrim == 0)
{
    Console.WriteLine("1 корiнь рiвняння");
    double x = (-b / 2*a);

    Console.WriteLine($"x = {x:F3}");

}
else
{
    Console.WriteLine("Немає коренiв");
}

