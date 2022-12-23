Console.WriteLine("Enter number from 0 to 9");
int num = int.Parse(Console.ReadLine());
switch (num) 
{
    case 0: Console.WriteLine("нуль"); break;
    case 1: Console.WriteLine("один");break;
    case 2: Console.WriteLine("два");break;
    case 3: Console.WriteLine("три");break;
    case 4: Console.WriteLine("чотири");break;
    case 5: Console.WriteLine("п'ять");break;
    case 6: Console.WriteLine("шість");break;
    case 7: Console.WriteLine("сім");break;
    case 8: Console.WriteLine("вісім");break;
    case 9: Console.WriteLine("дев'ять");break;
    default: Console.WriteLine("incorrect num typed"); break;
}


