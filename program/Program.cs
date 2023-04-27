int longArray () // Длинна массива
{
    System.Console.Write($"Введите длинну массива > ");
    return int.Parse(Console.ReadLine());
}

void fillingArray (string[] array) // Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите строку {i+1} > ");
        array[i] = Console.ReadLine();
    }
}

string[] arrayWithThreeElement(string[] array) // Массив с 3 символами
{
    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        
        if (array[j].Length <= 3)
        {
            i=i+1;
        }
        
    }
    string[] arrayThreeElement = new string [i];
    int k = 0;
    for (int j = 0; j < array.Length; j++)
    {
        
        if (array[j].Length <= 3)
        {
            arrayThreeElement[k] = array[j];
            k++;
        }
        
    }
    return arrayThreeElement;
}

void printArray (string[] array) // Печать массива
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"\"{array[i]}\" ");
    }
    System.Console.Write("]");
}


string[] array = new string [longArray()];
fillingArray (array);
string[] arrayWithThreeEl = arrayWithThreeElement(array);
printArray(arrayWithThreeEl);