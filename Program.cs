Console.Write("Введите колличество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом {i}:\t");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nВывод массива:");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + "  ");
}
Console.WriteLine();



// int[] myArray = { 822, 45, 632, 14, 25, 89 };
// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write(myArray[i] + "  ");
// }
// Console.WriteLine();
// Метод разворота массива
void ReversalMassiv(int[] Arr)
{
    int length = Arr.Length;
    if (Arr.Length % 2 == 0)
    {
        length = length / 2;
    }
    else
        length = (length - 1) / 2;

    for (int i = 0; i < length; i++)
    {
        int a = Arr[i];
        Arr[i] = Arr[Arr.Length - 1 - i];
        Arr[Arr.Length - 1 - i] = a;
    }
    Console.WriteLine("\nВывод перевернутого массива:");

    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + "  ");
    }
    Console.WriteLine();
}
ReversalMassiv(myArray);

Console.WriteLine();

// Метод нахождения суммы (не)чётных элемента массива

void EvenFind(int[] Array)
{
    int summa = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            summa = summa + Array[i];
        }
    }
    Console.WriteLine($"Сумма четных элементов: {summa}");
}
EvenFind(myArray);

// Наименьшее(наибольшее) в массиве

void Less_moreMassiv(int[] Array)
{
    int max = Array[0];
    for (int i = 1; i < Array.Length; i++)
    {
        if (Array[i] > Array[0])
        {
            max = Array[i];
        }

    }
    Console.WriteLine($"Наибольший элемент массива: {max}");
}
Less_moreMassiv(myArray);
