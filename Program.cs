//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//  длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] CreateMassive()
{
    Console.WriteLine("Введите длину массива:");
    int length = int.Parse(Console.ReadLine());
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива {i + 1}");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine($"Вы ввели массив: \t[{string.Join(", ", array)}]");
    return array;
}
string[] NewMassive(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) { count++; }
    }
    string[] newArray = new string[count];
    int posinionNewArray = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length < 4)
        {
            newArray[posinionNewArray] = array[j];
            posinionNewArray++;
        }
    }
    return newArray;
}


Console.WriteLine("Введите '0', если хотите использовать массив по умолчанию.");
Console.WriteLine("Введите '1', если хотите задать массив самостоятельно.");
int choice = int.Parse(Console.ReadLine());
string[] defoultArray = { "Hello", "2", "world", ":-)" };
if (choice == 0)
{
    Console.WriteLine($"Будет использован массив по \"по умолчанию\": \t[{string.Join(", ", defoultArray)}]");
    Console.WriteLine($"Ваш новый массив: \t[{string.Join(", ", NewMassive(defoultArray))}]");
}
else
{
    string[] usersArray = CreateMassive();
    Console.WriteLine($"Ваш новый массив: \t[{string.Join(", ", NewMassive(usersArray))}]");
}
