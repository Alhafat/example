int Max(int arg1, int arg2, int arg3)
{
    int result=arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}

Console.Write("Введите первое число: "); 
int number1=int.Parse(Console.ReadLine()!);

Console.Write("Введите первое число: "); 
int number2=int.Parse(Console.ReadLine()!);

Console.Write("Введите первое число: "); 
int number3=int.Parse(Console.ReadLine()!);

Console.Write("Введите первое число: "); 
int number4=int.Parse(Console.ReadLine()!);

Console.Write("Введите первое число: "); 
int number5=int.Parse(Console.ReadLine()!);

Console.Write("Введите первое число: "); 
int number6=int.Parse(Console.ReadLine()!);

Console.Write("Введите первое число: "); 
int number7=int.Parse(Console.ReadLine()!);

Console.Write("Введите первое число: "); 
int number8=int.Parse(Console.ReadLine()!);

Console.Write("Введите первое число: "); 
int number9=int.Parse(Console.ReadLine()!);

// int max1=Max(number1,number2, number3);
// int max2=Max(number4,number5,number6);
// int max3=Max(number7,number8,number9);
// int max=Max(max1,max2,max3);

int max=Max(Max(number1,number2, number3),Max(number4,number5,number6),Max(number7,number8,number9));


Console.WriteLine(max);
