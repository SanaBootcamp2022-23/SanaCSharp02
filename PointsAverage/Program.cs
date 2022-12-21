double[] count=new double[10];
for(int i=0; i < 5; i++)
{
    count[i] = double.Parse(Console.ReadLine());
}
double summ = 0;
for (int i = 0; i < 5; i++)
{
    summ+=count[i];
}
if (summ / 5 < 4)
{
    Console.WriteLine($"Ти маєш не допуск до екзмену!!!\nTвоя оцiнка \"{summ/5.0}\"");

}
else
{
    Console.WriteLine("Ваш середнiй бал 4 i бiльше, маєш допуск до екзамену))");
}
