//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве. //[345, 897, 568, 234] -> 2
int[] ArrayCreationAndPrint()
{
    Console.WriteLine("Введите число задающее размер массива трехзначных чисел: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    return array;
}
void СountEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в сгенерированном массиве: {count}");
}
СountEvenNumbers(ArrayCreationAndPrint());