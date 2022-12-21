int mark1, mark2, mark3, mark4, mark5;
Console.WriteLine("Enter 5 marks: ");
Console.Write("Mark 1 = ");
mark1 = int.Parse(Console.ReadLine());
Console.Write("Mark 2 = ");
mark2 = int.Parse(Console.ReadLine());
Console.Write("Mark 3 = ");
mark3 = int.Parse(Console.ReadLine());
Console.Write("Mark 4 = ");
mark4 = int.Parse(Console.ReadLine());
Console.Write("Mark 5 = ");
mark5 = int.Parse(Console.ReadLine());
double avg;
avg = (mark1 + mark2 + mark3 + mark4 + mark5) / 5.0;
   if (avg >= 4)
    Console.WriteLine("You can pass the exam!");
   if (avg < 4)
    Console.WriteLine("You can't pass the exam!");