double sum = 0;
for (int i = 0; i < 5; i++)
    sum += int.Parse(Console.ReadLine());
sum /= 5;
if (sum >= 4) Console.WriteLine($"Допущений. {sum}");
else Console.WriteLine($"Не допущений. {sum}");