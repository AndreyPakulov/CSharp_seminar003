// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер четверти плоскости, в которой находится эта точка.

// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());

// if(x > 0 && y > 0)
// {
//      Console.WriteLine("1");
// }
// else if(x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// else if(x < 0 && y < 0)
// { 
//      Console.WriteLine("3");
// }
// else
// {
//      Console.WriteLine("4");
// }

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetKvadrat(num1, num2));

int GetKvadrat(int x, int y)
{
    int sqr = 0;
    if(x > 0 && y > 0)
    {
        sqr = 1;
    }
    else if(x < 0 && y > 0)
    {
        sqr = 2;
    }
    else if(x < 0 && y < 0)
    {
        sqr = 3;
    }
    else
    {
        sqr = 4;
    }
    return sqr;
}