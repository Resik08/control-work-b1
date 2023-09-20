string[] LeadArray(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine()!.Split();
}
void PrintArray(string[] array, string text) {
    Console.WriteLine($"{text}: [{string.Join(", ", array)}]");
}

int Counter(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}
string[] NewArray(string[] arr, int count)
{
    string[] resultArray = new string[count];
    int index = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resultArray[index] = arr[i];
            index++;
        }
    }
    return resultArray;
}

string[] array = LeadArray("Введите несколько слов, цифр или символов, разделяя их пробелами");
PrintArray(array, "Исходный массив");
string[] result = NewArray(array, Counter(array));
PrintArray(result, "Получившийся массив");