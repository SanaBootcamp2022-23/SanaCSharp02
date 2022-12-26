using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8;
byte number;
Console.WriteLine("Будь-ласка введіть цифру у диапазоні від [0-9]");

number = Convert.ToByte(Console.ReadLine());
switch (number)
{
	case 0:
		Console.WriteLine("нуль");
		break;
	case 1:
		Console.WriteLine("один");
		break;
	case 2:
		Console.WriteLine("два");
		break;
	case 3:
		Console.WriteLine("три");
		break;
	case 4:
		Console.WriteLine("чотири");
		break;
	case 5:
		Console.WriteLine("п'ять");
		break;
	case 6:
		Console.WriteLine("шість");
		break;
	case 7:
		Console.WriteLine("сім");
		break;
	case 8:
		Console.WriteLine("вісім");
		break;
	case 9:
		Console.WriteLine("дев'ять");
		break;
}