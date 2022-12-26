double point1, point2, point3, point4, point5, average;

Console.WriteLine("Please, input first point");
point1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input second point");
point2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input third point");
point3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input forth point");
point4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input fifth point");
point5 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Is student admitted to the exam? Let's find out\n");

average = (point1 + point2 + point3 + point4 + point5) / 5;

if (average >= 4.0)
    Console.WriteLine($"Congratulations, you passed the Ohio state bar. You have {average} points");
else
{
    Console.WriteLine($"I'm sorry but you go on retake, because you have {average} points ");
}