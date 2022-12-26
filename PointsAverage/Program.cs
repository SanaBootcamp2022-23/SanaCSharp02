double firstMark, secondMark, thirdMark, fourthMark, fifthMark;
double averageMark = 0;

Console.Write("Input first mark = ");
firstMark = double.Parse(Console.ReadLine());

Console.Write("Input second mark = ");
secondMark = double.Parse(Console.ReadLine());

Console.Write("Input third mark = ");
thirdMark = double.Parse(Console.ReadLine());

Console.Write("Input fourth mark = ");
fourthMark = double.Parse(Console.ReadLine());

Console.Write("Input fifth mark = ");
fifthMark = double.Parse(Console.ReadLine());

averageMark = (firstMark + secondMark + thirdMark + fourthMark + fifthMark) / 5.0;

Console.WriteLine("Student`s average mark is =" + averageMark);

if (averageMark >= 4)
{
	Console.WriteLine("Student is allowed to take an exam");
}
else
{
	Console.WriteLine("Student is not allowed to take an exam");
}

