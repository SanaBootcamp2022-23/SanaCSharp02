Console.WriteLine("Enter 5 student`s grades");
double sum = double.Parse(Console.ReadLine());
sum += double.Parse(Console.ReadLine());
sum += double.Parse(Console.ReadLine());
sum += double.Parse(Console.ReadLine());
sum += double.Parse(Console.ReadLine());

if(sum/5 >= 4)
{
    Console.WriteLine("Allowed taikng exam");
}else
{
    Console.WriteLine("Not allowed taking exam");
}

