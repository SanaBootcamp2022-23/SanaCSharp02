int digit;
do
    Console.WriteLine($"Input digit [0, 9] = ");
while (!(int.TryParse(Console.ReadLine(), out digit) && digit >= 0 && digit <= 9));
string writtenDigit=String.Empty;
switch (digit)
{
    case 0:
        writtenDigit = "zero";
        break;
    case 1:
        writtenDigit = "one";
        break;
    case 2:
        writtenDigit = "two";
        break;
    case 3:
        writtenDigit = "three";
        break;
    case 4:
        writtenDigit = "four";
        break;
    case 5:
        writtenDigit = "five";
        break;
    case 6:
        writtenDigit = "six";
        break;
    case 7:
        writtenDigit = "seven";
        break; 
    case 8:
        writtenDigit = "eight";
        break; 
    case 9:
        writtenDigit = "nine";
        break;
    default:
        Console.WriteLine("Error");
        break;
}
Console.WriteLine(writtenDigit);