int[] list={1,3,2,5,4};

void PrintArray(int[] list)
{
    int count=list.Length;

    for (int i=0; i<count; i++)
    {
        Console.Write($"{list[i]}");
    }
    Console.WriteLine();
}
PrintArray(list);

void SelectionSort(int[] list)
{
    for (int i=0; i<list.Length-1; i++)
    {
        int minPosition=i;
        for (int j=i+1; j<list.Length; j++)
        {
            if (list[j]<list[minPosition]) 
            {
                minPosition=j;
            }
        }
        int temporary=list[i];
        list[i]=list[minPosition];
        list[minPosition]=temporary;

    }
}
PrintArray(list);
SelectionSort(list);
PrintArray(list);
