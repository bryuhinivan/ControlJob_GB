// Задача. Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Clear();
string[] massif = new string[4] {"Hello", "2", "world", ":-)"};
Console.Write($"[{string.Join(" | ", massif)}]");
Console.WriteLine("\n");
PrintArray(massif);

void PrintArray(string[] arr)
{
    string[] newarray = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newarray[i] = arr[i]; 
        }
    }
    Console.WriteLine("Конечный массив: ");
    Console.Write($"[{string.Join(" ", newarray)}]");
}
