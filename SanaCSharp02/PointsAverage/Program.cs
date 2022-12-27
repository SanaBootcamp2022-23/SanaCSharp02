// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter 5 student grades");

Console.WriteLine("Grade1");
var Grade1 = double.Parse(Console.ReadLine());
Console.WriteLine("Grade2");
var Grade2 = double.Parse(Console.ReadLine());
Console.WriteLine("Grade3");
var Grade3 = double.Parse(Console.ReadLine());
Console.WriteLine("Grade4");
var Grade4 = double.Parse(Console.ReadLine());
Console.WriteLine("Grade5");
var Grade5 = double.Parse(Console.ReadLine());


var Result = (Grade1 + Grade2 + Grade3 + Grade4 + Grade5) / 5;
if (Result < 4)

{
   Console.WriteLine("Student not admitted");
}
    if (Result > 4)

{
     Console.WriteLine("The student is admitted");
}
Console.WriteLine("PointsAverage");
Console.WriteLine(Result);

