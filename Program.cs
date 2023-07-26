/* 
Урок 1. Контрольная работа
Необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной 
содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно 
быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть 
расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый 
массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] 
*/

string[] CreateArray()
{
    int length;
    Console.Write($"Введите количество строк в массиве: ");
    bool success = int.TryParse(Console.ReadLine()!, out length);
    if (length < 1)
    {
        Console.WriteLine($"Вы ввели не натуральное число, пожалуйста перезапустите программу");
        Environment.Exit(0);
    }
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1}-ю строку массива: ", i + 1);
        array[i] = Console.ReadLine()!;
        if (!string.IsNullOrWhiteSpace(array[i]))
        {

        }
        else
        {
            Console.WriteLine($"Вы должны заполнить строки массива, пожалуйста перезапустите программу");
            Environment.Exit(0);
        }
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int CountLessThan4StringLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewLessThan4StringArray(string[] array, int lengthResultArray)
{
    int index = 0;

    string[] resultArray = new string[lengthResultArray];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[index] = array[i];
            index++;
        }
    }
    return resultArray;
}

string[] array = CreateArray();
PrintArray(array);
int lengthResultArray = CountLessThan4StringLength(array);
string[] resultArray = NewLessThan4StringArray(array, lengthResultArray);
Console.Write(" -> ");
PrintArray(resultArray);