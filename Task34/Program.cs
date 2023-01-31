//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void PrintArray(int[] Array)
{
    int CountEvenNumber = 0;
    int Length = Array.Length;
    for (int i = 0; i < Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            CountEvenNumber++;
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            Console.Write($"{Array[i]}, ");
        }
    }
    Console.Write($"-> {CountEvenNumber}");
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
    Arr[i] = new Random().Next(100, 1000);
}

PrintArray(Arr);