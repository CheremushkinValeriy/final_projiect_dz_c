/* 
Написать программу, которая из имеющегося массива строк фомирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. 

Примеры:
["hello","2","world",":-)"] -> ["2",":-)"]
["1234","1567","-2","computer science"] -> ["-2"]
["Russia","Denmark","Kazan"] ->[]
*/

Console.Clear();
string [] array1 = new string [4] {"hello","2","world",":-)"};
string [] array2 = new string [array1.Length];

FillingArray2(array1, array2);
PrintArray(array2);

void FillingArray2 (string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray (string[] array)
{
    Console.Write("-> [");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}






