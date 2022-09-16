// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] firstArray = new string[] {"Hello", "my", "first", "control", "work", "new", "res"};
Console.WriteLine($"Заданный массив:");
Console.WriteLine($"[{String.Join(", ", firstArray)}]");

int maxLength = 3;
int newLength = SortedArray(firstArray, maxLength);
string[] resultArray = new string[newLength];

FillResultArray(firstArray, resultArray, maxLength);
Console.WriteLine($"Полученный массив:");
PrintResultArray(resultArray);

void FillResultArray(string[] array1, string[] array2, int maxLength)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= maxLength)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
int SortedArray(string[] array, int maxLength)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength) result++;
    }
    return result;
}
void PrintResultArray (string[] array)
{
    string result = string.Empty;
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $"{array[i],1}";
        if (i < array.Length - 1)
        {
            result = result + ", ";
        }
    }
    Console.Write(result);
    Console.WriteLine(" ]");
}
