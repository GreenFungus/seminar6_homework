// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetPositiveCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] GetArrayFromKeyboard(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.Write("Введите размер массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());

Console.Write($"Установлен размер массива, равный {arrSize}");
int[] array = GetArrayFromKeyboard(arrSize);

int positiveCount = GetPositiveCount(array);

PrintArray(array);
Console.Write($" -> {positiveCount}");
