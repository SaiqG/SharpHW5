//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateArray(int num)
{
    int[] array = new int[num];
    Console.WriteLine($"Наш массив из {num} случайных чисел:");
    return array;
}

void FillArray(int[] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(0, 1000);
    }
}

void PrintArray(int[] array)
{

    foreach (int elem in array)
    {
        Console.Write($"{elem} ");
    }
    Console.WriteLine();
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FindSome(int[] array)
{
    int count1 = 0;
    int count2 = 0;
    foreach (int elem in array)
    {
        if (elem % 2 == 0)
        {
            count1++;
        }
        else count2++;
    }
    Console.WriteLine();
    Console.WriteLine($"В массиве {count1} четных и {count2} нечетных чисел");
}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int FindSumEach2nd(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
        Console.Write($"{array[i]} ");
    }
    return sum;
}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

string FindMinMaxDiff(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }

    string sum = $"{max} - {min} = {max - min}";
    return sum;
}

while (true)
{
    Console.Write("Введите размер массива. "); // в задаче 8, но это не интересно, вы говорили избавляться от волшебных чисел)

    bool numBool = false;
    int num = 0;

    while (!numBool)
    {
        Console.WriteLine("Число должно быть целым.");
        numBool = int.TryParse(Console.ReadLine()!, out num);
    }


    int[] array = CreateArray(num);
    FillArray(array);
    PrintArray(array);
    FindSome(array);
    Console.WriteLine();
    Console.Write($"Массив из чисел на нечетных позициях [1,3,5...]  -> ");
    Console.WriteLine($"их сумма = {FindSumEach2nd(array)}");
    Console.WriteLine();
    Console.WriteLine($"Разница между максимумом и минимумом -> {FindMinMaxDiff(array)} ");

    Console.WriteLine();
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q' || quite.KeyChar == 'й') break;
    Console.Clear();
}