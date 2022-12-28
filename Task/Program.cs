/* Задача: Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами. */

string[] array = { "Hello", "world", "New", "Year", "23", ":-)", "!" };
string[] array1 = new string[array.Length];

SelectionElements(array, array1);
PrintArray(array1);

void SelectionElements(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
