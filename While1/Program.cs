/*This program calculates the values ​​a, b and c as the results of these expressions
  depending on the variable n entered by the user*/

using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

Console.WriteLine("\n\t\t\tHello my dear friend!\n\n" +
                  "\tThis program calculates the values a, b and c as the results of\n" +
                  "\tsecret expressions, depending on the variable n entered by the user.\n" +
                  "\tIf you want to see how it works, input a natural\n" +
                  "\tnumber n on the keyboard and get the result.\n" +
                  "\tIf not, just close the window.\n\n" +
                  "\tFinish entering natural number n by pressing the \"Enter\" key.\n");

double valueA = 0,   // The value obtained from the results of the calculation of the first expression
       valueB = 0,   // The value obtained from the results of the calculation of the second expression
       valueC = 0;   // The value obtained from the results of the calculation of the third expression
int counter = 1,
    counterf = 1,
    factorial = 1;

//Natural number n entered by the user
Console.Write($"\t\tInput a natural namber n: ");
uint naturalN = uint.Parse(Console.ReadLine());

//Calculation of the values ​​of a, b and c
while (counter <= naturalN)
{
    double elementA = Math.Pow(-1, counter) / (2 * counter + 1);
    valueA += elementA;

    double elementB = 1 + 1 / Math.Pow(counter, 2);
    valueB += elementB;
 
    while (counterf <= counter)
    {
        factorial *= counterf;
        counterf++;
    }   
    valueC += factorial;
    counterf = 1;
    factorial = 1;

    counter++;
}
Console.WriteLine("\n\t\tAccording to the results of the calculations:\n" +
                 $"\t\t\ta = {valueA};\n\t\t\tb = {valueB};\n\t\t\tc = {valueC}.");

Console.WriteLine("\a");