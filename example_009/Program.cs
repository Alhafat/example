void FillArray(int[] numbers)
{
    int len=numbers.Length;
    int index=0;
    while (index<len)
    {
        numbers[index]=new Random().Next(1,10); //добавляет случайные элементы в массив
        index++;
    }
}

//  метод 2
// void PrintArray(int[] col);
// {
//     int count=col.Length;
//     int position=0;
//     while (position<count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }


int[] numbers=new int[10]; //определяет массив из 10 элементов

FillArray(numbers); //заполняет массив
PrintArray(numbers); //выводит(печатает массив)