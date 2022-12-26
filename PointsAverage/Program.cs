double sum = 0, avarage = 0, var = 0;

Console.WriteLine("Input numbers from 1 to 5:");

for (int i = 1; i <= 5; i++) 
{
    Console.WriteLine($"Input {i} number");
    var = double.Parse(Console.ReadLine());
    if (var > 5)
    {
        Console.WriteLine($"Incorect number");
    }
    else if (var <= 0)
    {
        Console.WriteLine($"Incorect number");
    }
    else 
    {
        
        sum += var;
    }
    
}

avarage = sum / 5;

if (avarage < 4) 
{
    Console.WriteLine($"You are not allowed 0_0, your avarage mark is {avarage}");
}else 
{
    Console.WriteLine($"Congratulations, your avarage mark is {avarage}");
}