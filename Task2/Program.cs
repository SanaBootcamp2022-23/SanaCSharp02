

double avarage, mark, sum=0;
for(int i=0; i<5; i++)
{
    Console.Write($"{i+1} mark: ");
    mark = int.Parse(Console.ReadLine());
    sum += mark;
}
avarage = sum / 5;

if (avarage >= 4) 
    Console.WriteLine("\nAllowed to take the exam");
else
    Console.WriteLine("\nAre not allowed to take the exam");
