//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//  длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] CreateMassive() //Создание массива строк выбранной длинны
{
    Console.WriteLine("Введите длину массива (целое число больше 0):");
    string result = Console.ReadLine();
    if (int.TryParse(result, out int length)) { }
    if (length > 0)
    {
        string[] array = new string[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Введите элемент массива {i + 1}");
            array[i] = Console.ReadLine();
        }
        Console.WriteLine($"Вы ввели массив: \t[{string.Join(", ", array)}]");
        return array;
    }
    else { return CreateMassive(); }
}
string[] NewMassive(string[] array) // Создание массива со строками длинной не более 3
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) // счётчик количества элементов массива с длинной мене 4-х символов
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
void PrintMassive(int temp) // печать нового массива
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
    else { Console.WriteLine("Сделайте ввыбор - '1', или '2'. Запустите программу снова, когда определитесь."); }
}

Console.WriteLine("Введите '1', если хотите использовать массив по умолчанию.");
Console.WriteLine("Введите '2', если хотите задать массив самостоятельно.");
string result = Console.ReadLine();
if (int.TryParse(result, out int choice)) { }
PrintMassive(choice);
