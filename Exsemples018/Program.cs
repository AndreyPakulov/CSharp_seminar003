// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetDiaposon(num));

string GetDiaposon(int quater)
{
    string result;
    if(quater == 1)
    {
        result = "x > 0 и y > 0";
    }
    else if(quater ==2)
    {
         result = "x < 0 и y > 0";
    }
    else if(quater == 3)
     {
         result = "x < 0 и y < 0";
    }
    else
    {
         result = "x > 0 и y < 0";
    }
    return result;
}