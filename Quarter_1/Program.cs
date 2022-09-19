// Дан одномерный массив строк. Программа формирует из имеющегося массива, массив из строк,
// длина которых меньше или равна 3 символам. 
void Print(string[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($" {arr[i]} ");
    }
    Console.WriteLine();
}

string[] MassStr (int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {size} string: ");
        arr[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return arr;
        
}

string[] MassShortLines (string[] arr)
{
    
}



string[] arr_1 = MassStr(5);
Print(arr_1);