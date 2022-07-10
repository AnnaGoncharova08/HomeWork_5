// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Zadacha34()
{
int size = 5;
int[] array = new int [size];
FillArray(array, 100, 999);
PrintArray(array);
FindEvenNumber(array);

void FillArray(int[] array, int start = 0, int finish = 0)
{
    finish++;
    Random random = new Random();
   
   for (int i = 0; i < array.Length; i++)
   {
        array[i] = random.Next(start, finish);
   }
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < array.Length; i++)
   {
        Console.Write(array[i] + "\t");
   }
   Console.WriteLine();
}

void FindEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i]%2 == 0)
        {
            count +=1;
        }
    }
    Console.WriteLine($"Количество четных чисел в заданном массиве равно {count}");
} 
}
Zadacha34();