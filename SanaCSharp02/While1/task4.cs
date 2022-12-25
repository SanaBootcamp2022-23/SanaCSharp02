int n,temp_n;

Console.WriteLine("Введiть число n:");
while (!Int32.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Введено невiрне значення для числа!\n Спробуйте ще раз!");
}

// a
double a = 0;
temp_n = n;
while (temp_n >= 1)
{
    a += Math.Pow(-1, temp_n) / (2 * temp_n + 1);
    temp_n--;
}

Console.WriteLine($"a = {a}");
// a

// b
double b = 0;
temp_n = n;
while (temp_n >= 1)
{
    b += 1 + (1.0/Math.Pow(temp_n,2));
    temp_n--;
}

Console.WriteLine($"b = {b}");
// b

// c
double c = 0;
temp_n = n;
while (temp_n >= 1)
{
    int temp2_n = temp_n;
    int fact = 1;
    while (temp2_n >= 1)
    {
        fact *= temp2_n;
        temp2_n--;
    }
    c += fact;
    temp_n--;
}

Console.WriteLine($"c = {c}");
// c