Console.WriteLine("Enter first mark ");
int FirstMark = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second mark ");
int SecondMark = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third mark ");
int ThirdMark = int.Parse(Console.ReadLine());
Console.WriteLine("Enter fourth mark ");
int FourthMark = int.Parse(Console.ReadLine());
Console.WriteLine("Enter fifth mark ");
int FifthMark = int.Parse(Console.ReadLine());

int summ = FirstMark+ SecondMark + ThirdMark + FourthMark + FifthMark;

int avarage = summ / 5;

if (avarage >= 4)
    Console.WriteLine($"Student avarage mark is {avarage} admission granted");
else
    Console.WriteLine($"Student avarage mark is {avarage} access is denied");