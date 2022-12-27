Console.WriteLine("Input five marks");
float sum = 0;
const int marksCount = 5;

for (int i = 0; i < marksCount; i++)
{
    sum += float.Parse(Console.ReadLine());
}

float average = sum / marksCount;

if (average >= 4)
    Console.WriteLine("The student is admitted to the exam");
else
    Console.WriteLine("The student is not admitted to the exam");
