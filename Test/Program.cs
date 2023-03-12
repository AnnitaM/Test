/*
Написать программу, которая из имеющегося массива строк 
формирует массив строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.
*/ 

Console.Clear();

Console.WriteLine("Enter array of strings separeted with space: ");
string inputString = Console.ReadLine();
int maxElemLength = 3;

string[] inputArray = GetArray(inputString);

Console.WriteLine();
PrintArray(SortArray(inputArray));
Console.WriteLine();

string[] GetArray(string inputString)
{
    string[] LocInputArray = inputString.Split(' ');
    return LocInputArray;
}

string[] SortArray(string[] array)
{
    int count = 0;

    string[] finalArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxElemLength)
        {
            finalArray[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref finalArray, count);
    return finalArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{String.Join(" ", array[i])} ");
    }
}


