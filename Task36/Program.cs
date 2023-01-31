//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void PrintArray(int[] Array)
{
    int CountNotEvenNumber = 0;
    int Length = Array.Length;
    for (int i = 0; i < Length; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            CountNotEvenNumber = CountNotEvenNumber + Array[i];
            Console.Write($"{Array[i]}, ");
        }
    }
    Console.Write($"-> {CountNotEvenNumber}");
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