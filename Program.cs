    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество
    // чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2

// Задаем размер массива, 4 элемента
int arraySize = 4;

// Создаем массив
int[] numbers = new int[arraySize];

// Заполняем массив случайными трехзначными числами
Random random = new Random();
for (int i = 0; i < arraySize; i++)
{
    numbers[i] = random.Next(100, 1000);
}

// Подсчитываем количество четных чисел
int evenCount = 0;
for (int i = 0; i < arraySize; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenCount++;
    }
}

// Выводим результат
Console.WriteLine($"Массив: [{string.Join(", ", numbers)}]");
Console.WriteLine($"Количество четных чисел: {evenCount}");


    // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0


// Задаем размер массива
int arraySize = 4; // Например, 4 элемента

// Создаем массив
int[] numbers = new int[arraySize];

// Заполняем массив случайными числами
Random random = new Random();
for (int i = 0; i < arraySize; i++)
{
    numbers[i] = random.Next(-100, 101);
}

// Находим сумму элементов на нечетных позициях
int sum = 0;
for (int i = 1; i < arraySize; i += 2)
{
    sum += numbers[i];
}

// Выводим результат
Console.WriteLine($"Массив: [{string.Join(", ", numbers)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");


    // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
    // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// Создаем массив вещественных чисел
double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };

// Находим максимальный и минимальный элементы
double max = numbers[0];
double min = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

// Вычисляем разницу между максимальным и минимальным элементами
double difference = max - min;

// Выводим результат
Console.WriteLine($"Массив: [{string.Join(", ", numbers)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");