Console.Clear();

string[] FillArray(string text)
{
    string[] arr = text.Split(new char[] { ' ' , ',' }, StringSplitOptions.RemoveEmptyEntries);
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i< arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int CountStringsWithLength(string[] arr, int length)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= length) count++;
    }
    return count;
}

string[] ArrayDeleteLongWords(string[] arr, int length)
{
    int countWords = CountStringsWithLength(arr, length);
    string[] arrNew = new string[countWords];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= length) arrNew[index++] = arr[i];
    }
    return arrNew;
}

Console.Write("Введите строки для массива через пробел или запятую: ");
string line = Console.ReadLine();
Console.Write("Введите максимальное количество символов для строки: ");
int len = Convert.ToInt32(Console.ReadLine());
string[] textArray = FillArray(line);
Console.WriteLine("Исходный массив:");
PrintArray(textArray);
string[] newTextArray = ArrayDeleteLongWords(textArray, len);
Console.WriteLine($"Массив со строками, длина которых меньше или равна {len} символам:");
PrintArray(newTextArray);
