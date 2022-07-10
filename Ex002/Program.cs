// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Zadacha34()
{
int size = 6;
int[] array = new int [size];
FillArray(array, -10, 10);
PrintArray(array);
FindSum(array);

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

void FindSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2)
    {   
        sum = sum + array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
} 
}
Zadacha34();
