// Создать массив и отсортировать его по убыванию

int[] arr = {2, 32, 25, 4, 45, 2, 13};

void PrintArray(int[] array)                   // made array printing method
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

void SelSortToMin (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosInd = i;
        for (int j = i+1; j < array.Length; j++)
       
            {
                if (array[j] > array[maxPosInd]) maxPosInd = j;
            }    
        int temporary = array[i];
        array[i] = array[maxPosInd];
        array[maxPosInd] = temporary;
            
    }
}

PrintArray(arr);
SelSortToMin(arr);

Console.WriteLine();
PrintArray(arr);