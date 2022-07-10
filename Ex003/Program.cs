// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Zadacha38()
{
int size = 5;
double[] array = new double [size];
array = FillArray(size);
PrintArray(array);
Console.WriteLine($"Максимальное значение равно {FindMax(array)}");
Console.WriteLine($"Минимальное значение равно {FindMin(array)}");
Console.WriteLine($"Разницу между max и min элементами массива равна {Math.Round(FindMax(array) - FindMin(array),2)}");
Console.WriteLine();

double[] FillArray(int size)
{
    double[] fillArray = new double [size];
    Random random = new Random();
   for (int i = 0; i < fillArray.Length; i++)
   {
        fillArray[i] = random.NextDouble() * 100;
   }
    return fillArray;
}
void PrintArray(double[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < array.Length; i++)
   {
        Console.Write(Math.Round(array[i], 2) + "\t");
   }
Console.WriteLine();
Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {   
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return (Math.Round(max, 2));
} 
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {   
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (Math.Round(min, 2));
} 
} 
Zadacha38();
