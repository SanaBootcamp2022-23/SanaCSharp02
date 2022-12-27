Console.WriteLine("Enter 5 stedent grades:");
int[] arr = new int[5];
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    sum += arr[i];
}
double average = sum / arr.Length;
if (average >= 4)
{
    Console.WriteLine($"Студент допущений до екзамену!(Середній балл: {average})");
}
else
{
    Console.WriteLine($"Студент не допущений до екзамену!(Середній балл: {average})");
}