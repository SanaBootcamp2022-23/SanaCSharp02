Console.WriteLine("Введіть 5 оцінок одного з студентів:");

double[] array = new double[5];
double avarage = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = double.Parse(Console.ReadLine());
    avarage += array[i];
}
avarage /= array.Length;

Console.WriteLine("Його середній бал = {0}", avarage);
Console.WriteLine("{0}", avarage > 4 ? "Студент допущений до екзамену" : "Студент не допущений до екзамену");