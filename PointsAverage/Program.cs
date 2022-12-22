int gradesum = 0, grade;
float averagegrades;
for(int i = 0; i <5; i++)
{
    Console.Write("Students grade is: ");
    grade = int.Parse(Console.ReadLine());
    gradesum += grade;
}
averagegrades = gradesum / 5;
if (averagegrades >= 4)
    Console.WriteLine("Student is permitted to write the exam");
else Console.WriteLine("Student is not permitted to write the exam");
