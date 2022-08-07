//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19       [-4, -6, 89, 6] -> 0
int[] ArrayCreationAndPrint()
{
    Console.WriteLine("Введите число задающее размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 21);
        Console.Write(array[i] + " ");
    }
    return array;
}
void SumOddIndex(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(i % 2 != 0) sum = sum + array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел стоящих на нечетных позициях в сгенерированном массиве: {sum}");
}
SumOddIndex(ArrayCreationAndPrint());