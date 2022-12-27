// See https://aka.ms/new-console-template for more information


Console.WriteLine("Input five marks");
float sum = 0;
const int TotalMarks = 5;

for (int i = 1; i < TotalMarks + 1; i++)
{
    Console.Write($"{i})-"); sum += float.Parse(Console.ReadLine());
}

float average = sum / TotalMarks;

if (average > 3.5)
{
    Console.WriteLine("The student is admitted to the exam");
}
else
{
    Console.WriteLine("The student is not admitted to the exam");
}