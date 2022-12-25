using System;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
int a, b, c;
double desc, x, x1, x2;
Console.WriteLine("Введіть a:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть b:");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть c:");
c = int.Parse(Console.ReadLine());
Console.WriteLine("Введено рівняння: {0}x^2+{1}x+{2}=0",a,b,c);
desc = Math.Pow(b,2) - (4 * a * c);
    if (desc == 0)
        {
            x = (-b) / (2 * a);
              Console.WriteLine("Дискримінант: {0}",desc);
              Console.WriteLine("Корень рівняння: {0}", x); 
        }
        else if (desc >0 )
            {
                x1 = (-b - Math.Sqrt(desc)) / (2 * a);
                x2 = (-b + Math.Sqrt(desc)) / (2 * a);
                Console.WriteLine("Дискримінант: {0}",desc);
                Console.WriteLine("Корені рівняння: {0} ,{1}", x1,x2);
            }
            else 
                {
                 Console.WriteLine("Дискримінант: {0}",desc);
                Console.WriteLine("Рівняння не має коренів");
                }
