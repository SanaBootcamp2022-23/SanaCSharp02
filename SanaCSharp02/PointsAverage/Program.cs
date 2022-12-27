double[] arrayRating = new double[5];
double rating;
double sumRating = 0;
double averageRating;

for (int i = 0; i < 5; i++)
{
    do
    {
        do
        {
            try
            {
                Console.WriteLine($"Enter rating {i + 1}; min rating = 1 max rating 5");
                rating = double.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input Error");
                Console.ForegroundColor = ConsoleColor.White;
            }

        } while (true);
        if (rating >= 1 && rating <= 5)
        {
            arrayRating[i] = rating;
            break;

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input Error");
            Console.ForegroundColor = ConsoleColor.White;
        }

    } while (true);

}
string str = "";
for (int i = 0; i < arrayRating.Length; i++)
{
    sumRating += arrayRating[i];
    str+= arrayRating[i].ToString();
    if(i < arrayRating.Length-1) str += " + ";
}
str+= " = " + sumRating.ToString();
averageRating = Math.Round(sumRating / arrayRating.Length);
if (averageRating >= 4)
{
    Console.WriteLine(str);
    Console.WriteLine($"{sumRating} / 5 = {sumRating / 5 }  ===> {averageRating}");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Аdmitted to the exam");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.WriteLine(str);
    Console.WriteLine($"{sumRating} / 5 = {sumRating / 5}  ===> {averageRating}  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Not allowed to take the exam");
    Console.ForegroundColor = ConsoleColor.White;
}
