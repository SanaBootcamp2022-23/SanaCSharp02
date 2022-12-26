double average = 0;
for(int i = 0; i < 5; i++)
{
    Console.Write("Enter mark " + (i + 1) + ": ");
    double degree = Convert.ToInt32(Console.ReadLine());
    average += degree;
}
average /= 5;
Console.WriteLine("Average is " + average);
if (average >= 4)
{
    Console.WriteLine("Student passed");
}
else
{
    Console.WriteLine("Student didn`t pass");

}