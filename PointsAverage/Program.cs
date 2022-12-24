float assesment=0, sum=0;
for (int i = 0; i <5; i++) {
    Console.Write($"Enter the {i + 1}: ");
    if (!float.TryParse(Console.ReadLine(), out assesment)) return;
    if (assesment < 0)
    {
        Console.WriteLine("Incorrect assesment. Try again");
        i--;
        continue;
    }
    sum += assesment;
}
Console.WriteLine($"Avarage assesment = {sum / 5}");
