// Дан одномерный массив строк. Программа формирует из имеющегося массива, массив из строк,
// длина которых меньше или равна 3 символам. 
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($" {arr[i]} ");
    }
    Console.WriteLine();
}

