void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
}
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}
string [] Search(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    string[] arr2 = new string [count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr2[j] = arr[i];
            j++;
        }
    }
    return arr2;
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
Console.WriteLine("Введите элементы массива через Enter");
FillArray(array);
PrintArray(array);
Search(array);
Console.WriteLine($"Массив из элементов длиной 3 и меньше ");
PrintArray(Search(array));