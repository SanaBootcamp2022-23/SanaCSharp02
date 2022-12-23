// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int main ()
{
    int number;
    printf("Введіть число від 0 до 9:\n");
    printf("0\n");
    printf("1\n");
    printf("2\n");
    printf("3\n");
    printf("4\n");
    printf("5\n");
    printf("6\n");
    printf("7\n");
    printf("8\n");
    printf("9\n");
    scanf("%d", &number);

    switch (number)
    {
        case 0:
            Console.WriteLine("нуль");
            break;
        case 1:
            Console.WriteLine("один");
            break;
        case 2:
            Console.WriteLine("два");
            break;
        case 3:
            Console.WriteLine("три");
            break;
        case 4:
            Console.WriteLine("чотири");
            break;
        case 5:
            Console.WriteLine("п'ять");
            break;
        case 6:
            Console.WriteLine("шість");
            break;
        case 7:
            Console.WriteLine("сім");
            break;
        case 8:
            Console.WriteLine("вісім");
            break;
        case 9:
            Console.WriteLine("дев'ять");
            break;
    }
    return 0;
}

unsafe void scanf(string v1, int* v2)
{
    throw new NotImplementedException();
}

void printf(string v)
{
    throw new NotImplementedException();
}

main();

