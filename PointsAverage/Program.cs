//This program based on points average determines whether the student is admitted to the exam

using System.Diagnostics.Metrics;
using System.Reflection;

Console.WriteLine("\n\t\t\tHello my dear friend!\n\n" +
                  "\tThis program determines whether the student is admitted to the exam\n" +
                  "\tIf you want to see how it works, input the five student grades\n" +
                  "\tin sequence on the keyboard and get the result.\n" +
                  "\tIf not, just close the window.\n\n" +
                  "\tFinish entering each grade by pressing the \"Enter\" key.\n");

int grade;
int sumGrades = 0;
double pointsAverage;

//This cycle calculates the sum of the student's grades entered by the user.
for (int counter = 1; counter <= 5; counter++)
{
    Console.Write($"\t\tInput grade number {counter} from 1 to 5: ");
    grade = int.Parse(Console.ReadLine());
    sumGrades += grade;
}

pointsAverage = sumGrades / 5.0;

if (pointsAverage >= 4)
    Console.WriteLine($"\n\tThe student is admitted to the exam. Points average = {pointsAverage}");
else   
    Console.WriteLine($"\n\tStudent not allowed to take the exam. Points average = {pointsAverage}");

Console.WriteLine("\a");