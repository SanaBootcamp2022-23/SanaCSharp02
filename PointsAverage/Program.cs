Console.Write("Enter first subject: ");
int ballOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second subject: ");
int ballTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third subject: ");
int ballThree = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fourth subject: ");
int ballFour = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fifth subject: ");
int ballFive = Convert.ToInt32(Console.ReadLine());
int summ = ballOne + ballTwo + ballThree + ballFour + ballFive;

int averageBall = summ / 5;
if (averageBall >= 4)
{
    Console.WriteLine("Student is passed his ball is {0}", averageBall);
}
else if(averageBall <= 3)
{
    Console.WriteLine("Ball is so small but minimum ball is 4 and you ball is {0} try again", averageBall);
}