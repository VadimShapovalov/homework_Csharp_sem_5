//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.  [3 7 22 2 78] -> 76
Console.WriteLine("Введите число задающее размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] ArrayCreationAndPrint(int n)
{
    int[] array = new int[n];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 21);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}
void DiffMinMax(int[] array)
{
    int max = array[0];
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    int diff = max - min;
    Console.WriteLine($"Разница между максимальным числом {max} и минимальным числом {min} равна: {diff}");
}
DiffMinMax(ArrayCreationAndPrint(n));