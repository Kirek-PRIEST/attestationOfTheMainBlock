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
void PrintMassive(int temp)
{
if (temp == 1 || temp == 2)
{
    string[] defoultArray = { "Hello", "2", "world", ":-)" };
    if (temp == 1)
    {
        Console.WriteLine($"Будет использован массив по \"по умолчанию\": \t[{string.Join(", ", defoultArray)}]");
        Console.WriteLine($"Ваш новый массив: \t[{string.Join(", ", NewMassive(defoultArray))}]");
    }
    else
    {
        string[] usersArray = CreateMassive();
        Console.WriteLine($"Ваш новый массив: \t[{string.Join(", ", NewMassive(usersArray))}]");
    }
}
else{ Console.WriteLine("Сделайте ввыбор - '1', или '2'. Попробуйте снова, когда определитесь.");}
}

Console.WriteLine("Введите '1', если хотите использовать массив по умолчанию.");
Console.WriteLine("Введите '2', если хотите задать массив самостоятельно.");
string result = Console.ReadLine();
//int choice;
if (int.TryParse(result, out int choice)) { }
PrintMassive(choice);
