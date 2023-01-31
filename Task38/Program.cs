//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void PrintArray(int[] Array)
{
    int MaxNumber = Array[0];
    int MinNumber = Array[0];
    int Length = Array.Length;
    for (int i = 0; i < Length; i++)
    {
        if (MaxNumber == Array[i] & MinNumber == Array[i])
        {
            Console.Write($"{Array[i]}, ");
        }
        if (MaxNumber > Array[i] & MinNumber < Array[i])
        {
            Console.Write($"{Array[i]}, ");
        }
        if (MaxNumber < Array[i] & MinNumber < Array[i])
        {
            MaxNumber = Array[i];
            Console.Write($"{Array[i]}, ");
        }
        if (MaxNumber > Array[i] & MinNumber > Array[i])
        {
            MinNumber = Array[i];
            Console.Write($"{Array[i]}, ");
        }
        if (MaxNumber < Array[i] & MinNumber > Array[i])
        {
            MaxNumber = Array[i];
            MinNumber = Array[i];
            Console.Write($"{Array[i]}, ");
        }
    }
    Console.Write($"-> {MaxNumber - MinNumber}");
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int Number = int.Parse(Console.ReadLine());
    return (Number);
}

int Number = GetNum("Введите количество элементов в массиве: ");

int[] Arr = new int[Number];

for (int i = 0; i < Number; i++)
{
    Arr[i] = new Random().Next(-100, 101);
}

PrintArray(Arr);