// See https://aka.ms/new-console-template for more information
byte grade1, grade2, grade3, grade4, grade5;
float GPA;

Console.WriteLine("Enter the student's grades:");
grade1 = byte.Parse(Console.ReadLine());
grade2 = byte.Parse(Console.ReadLine());
grade3 = byte.Parse(Console.ReadLine());
grade4 = byte.Parse(Console.ReadLine());
grade5 = byte.Parse(Console.ReadLine());

GPA = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;

if (GPA >= 4)
Console.WriteLine("Student admitted to the session");

else
Console.WriteLine("The student is NOT admitted to the session");

