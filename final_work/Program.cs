/*
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум
этапы 2, 3, и 4 должны быть расположены в разных коммитах)
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

int a = 3;
int size_array = 5;

string[] array = new string[size_array];
FillArray(array);
PrintArray(array);
Console.WriteLine();
if (NextArray(array) == 0){Console.WriteLine("Элементы массива ни найдены");}
else
{
    string[] arr1 = MovingElements(array);
    PrintArray(arr1);
}
void FillArray (string[] arr)
{
    for (int i = 0; i < size_array; i++)
    {
       Console.WriteLine("Введите элемент массива: ");
       arr[i] = Console.ReadLine();
    }
}

void PrintArray(string[] arr)
{
    int arraysize = arr.Length;
    Console.Write ('[');
 for (int i = 0; i < arraysize; i++)
    {
        Console.Write(' ');
        Console.Write(arr[i]);
    }
    Console.Write(']');
}

int NextArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < size_array; i++)
    {
       if (arr[i].Length<=a) {
        count++;
       }
    }
    return count;
}

string[] MovingElements(string[] arr)
{
    string[] arr1 = new string[NextArray(array)];
    for (int i = 0, j = 0; i < size_array; i++)
    {
       if (arr[i].Length<=3) {
        arr1[j] = arr[i];
        j++;
       }
    }
    return arr1;
}
