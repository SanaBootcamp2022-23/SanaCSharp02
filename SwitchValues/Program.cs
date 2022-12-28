//This program displays a text version of the number entered by the user

using System.Diagnostics.Metrics;
using System.Reflection;

Console.WriteLine("\n\t\t\tHello my dear friend!\n\n" +
                  "\tThis program displays the text version of the number\n" +
                  "\tyou entered on the keyboard.\n" +
                  "\tIf you want to see how it works, input a number\n" +
                  "\tfrom 0 to 9 on the keyboard and get the result.\n" +
                  "\tIf not, just close the window.\n\n" +
                  "\tFinish entering number by pressing the \"Enter\" key.\n");

Console.Write("\t\tInput number from 0 to 9: ");
int number = int.Parse(Console.ReadLine());


//This condition check displays a text version of the number entered by the user
switch (number)
{
    case 0: 
           Console.Write($"\t\tThe number you entered {number} in words -  zero.\n");
           break;
    case 1: 
           Console.Write($"\t\tThe number you entered {number} in words -  one.\n");
           break;
    case 2: 
           Console.Write($"\t\tThe number you entered {number} in words -  two.\n");
           break;
    case 3: 
           Console.Write($"\t\tThe number you entered {number} in words -  three.\n");
           break;
    case 4: 
           Console.Write($"\t\tThe number you entered {number} in words -  four.\n");
           break;
    case 5: 
           Console.Write($"\t\tThe number you entered {number} in words -  five.\n");
           break;
    case 6: 
           Console.Write($"\t\tThe number you entered {number} in words -  six.\n");
           break;
    case 7: 
           Console.Write($"\t\tThe number you entered {number} in words -  seven.\n");
           break;
    case 8: 
           Console.Write($"\t\tThe number you entered {number} in words -  eight.\n");
           break;
    case 9: 
           Console.Write($"\t\tThe number you entered {number} in words -  nine.\n");
           break;
    default:
           Console.Write($"\t\tThe number you entered {number} is not in the range 0 to 9.");
           break;
}

Console.WriteLine("\a");