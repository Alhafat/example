// int Max(int arg1, int arg2, int arg3) //функция   
// {                                       //нахождения
//     int result=arg1;                     //максимального
//     if (arg2>result) result=arg2;        //  числа
//     if (arg3>result) result=arg3;        // вся
//     return result;                       //как
// }                                        //есть

// Console.Write("Введите первое число: "); 
// int number1=int.Parse(Console.ReadLine()!);

// Console.Write("Введите первое число: "); 
// int number2=int.Parse(Console.ReadLine()!);

// Console.Write("Введите первое число: "); 
// int number3=int.Parse(Console.ReadLine()!);

// Console.Write("Введите первое число: "); 
// int number4=int.Parse(Console.ReadLine()!);

// Console.Write("Введите первое число: "); 
// int number5=int.Parse(Console.ReadLine()!);

// Console.Write("Введите первое число: "); 
// int number6=int.Parse(Console.ReadLine()!);

// Console.Write("Введите первое число: "); 
// int number7=int.Parse(Console.ReadLine()!);

// Console.Write("Введите первое число: "); 
// int number8=int.Parse(Console.ReadLine()!);

// Console.Write("Введите первое число: "); 
// int number9=int.Parse(Console.ReadLine()!);

// int max1=Max(number1,number2, number3); //находит максимальное из трех значений
// int max2=Max(number4,number5,number6);
// int max3=Max(number7,number8,number9);
// int result=Max(max1,max2,max3); //максимальное из максимальных

// int result=Max(Max(number1,number2, number3),Max(number4,number5,number6),Max(number7,number8,number9)); //тоже что выше, только в строку

// int[] numbers={number1,number2,number3,number4,number5,number6,number7,number8,number9}; //объеденяет в массив

// int n=numbers.Length; //длинна массива
// Console.Write("Введите искомое число: "); 
// int find=int.Parse(Console.ReadLine()!);

// int index=0;
// while (index<n)
// {
//     if (numbers[index]==find)
//     {
//         Console.WriteLine($"Искомое число находится в массиве под индексом: {index}");
//         break;
//     }
//     else
//     {
//         index++; //index=index+1
//     }
// }
// Console.WriteLine("Данное число в массиве отсутствует! Введите другое число!");  //выводит неверно!!!

// int max1=Max(numbers[0],numbers[1], numbers[2]); //находит максимальное из трех значений
// int max2=Max(numbers[3],numbers[4],numbers[5]);
// int max3=Max(numbers[6],numbers[7],numbers[8]);

// int result=Max(max1,max2,max3); //максимальное из максимальных

// Console.WriteLine(numbers[2]); // показывает позицию из массива

// Console.WriteLine(result); // выводит на экран
