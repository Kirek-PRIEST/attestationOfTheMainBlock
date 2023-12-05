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
        Console.WriteLine($"Введите элемент массива {i+1}");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine($"Вы ввели массив: \t[{string.Join(", ", array)}]");
    return array; 
}

Console.WriteLine("Введите '0', если хотите использовать массив по умолчанию.");
Console.WriteLine("Введите '1', если хотите задать массив самостоятельно.");
int choice = int.Parse(Console.ReadLine());
string[] defoultArray = {"Hello", "2", "world", ":-)"};
if (choice == 0){}
     // программа выполняется с defoultArray
else
{
   CreateMassive(); // выполняется генерация массива и выполняется программа с сгенерированным массивом
}
