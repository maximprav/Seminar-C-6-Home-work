// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int[] FillArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число №{i+1}");
        int num = int.Parse(Console.ReadLine()!)!;
        newArray[i] = num;
    }
    return newArray;
}
void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i=0; i<size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SumPositiveInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество положительных чисел, введенных пользователем равно {count}");
}

Console.Clear();
Console.WriteLine("Введите количество чисел, которые вы хотите ввести:");
int size = int.Parse(Console.ReadLine()!)!;
int[] array88 = new int[size];
int[] array89 = FillArray(array88);
PrintArray(array89);
SumPositiveInArray(array89);