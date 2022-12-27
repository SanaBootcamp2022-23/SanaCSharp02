//This program calculates the roots of a quadratic equation
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("\n\t\t\tHello my dear friend!\n\n" +
                  "\tThis program calculates the roots of a quadratic equation:\n" +
                  "\t\t\t     ax²+bx+c=0.\n" +
                  "\tIf you want to see how it works, input the type Double\n" +
                  "\tcoefficients \"a\", \"b\" and free element \"c\" in sequence on the\n" +
                  "\tkeyboard and get the solutions of the quadratic equation.\n" +
                  "\tIf not, just close the window.\n\n" +
                  "\t    Finish entering each coefficient and free element\n" +
                  "\t\t     by pressing the \"Enter\" key.\n");

double coefficientA, // Coefficient A entered by the user
       coefficientB, // Coefficient B entered by the user
       freeElementC; // Free element C entered by the user

//This cycle does not allow to convert a quadratic equation into a linear equation
do
{
    Console.Write("\t\t\tInput coefficient \"a\": ");
        coefficientA = double.Parse(Console.ReadLine());
    if (coefficientA == 0)
        Console.WriteLine("\n\tCoefficient \"a\" cannot be equal to zero! Please re-enter.");
}
while (coefficientA == 0);

    Console.Write("\t\t\tInput coefficient \"b\": ");
        coefficientB = double.Parse(Console.ReadLine());
    Console.Write("\t\t\tInput free element \"c\": ");
        freeElementC = double.Parse(Console.ReadLine());

double discriminant, 
       rootX,        
       rootX1,       
       rootX2;       

    discriminant = Math.Pow(coefficientB, 2) - 4 * coefficientA * freeElementC;
    Console.WriteLine($"\n\t\t\tDiscriminant D=b²-4ac: D = {discriminant}.");

//This cycle sets the behavior of the program depending on the value of the discriminant
if (discriminant < 0)
    Console.WriteLine("\n\t\tThis quadratic equation has no roots.");
else if (discriminant == 0)
{
    rootX = -coefficientB / (2 * coefficientA);
    Console.WriteLine("\n\t\tThis quadratic equation has only one root:" +
                     $"\n\t\t\tX = {rootX}.");
}
else
{
    rootX1 = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
    rootX2 = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
    Console.WriteLine("\n\t\tThis quadratic equation has two roots:" +
                     $"\n\t\t\tX1 = {rootX1};\n\t\t\tX2 = {rootX2}.");
}

Console.WriteLine("\a");