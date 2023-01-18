/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных индексах.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

//Task_1

int countEven(int arrayNumbers) {
    int[] nums = new int[arrayNumbers];
    int count = 0;
    for (int i = 0; i < arrayNumbers; i++) {
        Random rand = new Random();
        nums[i] = rand.Next(1, 1000);
        if (nums[i] % 2 == 0) {
            count+=1;
        }
    }
    printArray(nums);
    return count;
}

void printArray(int [] arrayNumbers) {
    Console.WriteLine("{0}", String.Join(",", arrayNumbers));
}

Console.WriteLine("\n");
Console.WriteLine("TASK_1");
Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. \nНапишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine($"Количество четных элементов массива: {countEven(10)}");


//Task_2

int sumOdd (int arrayNumbers) {
    int[] nums = new int[arrayNumbers];
    int sum = 0;
    for (int i = 0; i < arrayNumbers; i++) {
        Random rand = new Random();
        nums[i] = rand.Next(100, 999);
        if (i % 2 != 0) {
            sum+=nums[i];
        }
    }
    printArray(nums);
    return sum;
}

Console.WriteLine("\n");
Console.WriteLine("TASK_2");
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. \nНайдите сумму элементов, стоящих на нечётных индексах.");
Console.WriteLine($"Сумма нечетных индексов массива: {sumOdd(10)}");



//Task_3

void printList(List<int> numbers) {
    for (int i = 0; i < numbers.Count; i++)
    {
        Console.Write($"{numbers[i]},");
    }
}

void multiplicationParsNumbers (int arrayNumbers) {
    int[] nums = new int[arrayNumbers];
    int sum = 0;

    for (int i = 0; i < arrayNumbers; i++) {
        Random rand = new Random();
        nums[i] = rand.Next(1, 10);
    }

    List<int> numbers = new List<int> {};

    for (int i = 0; i < arrayNumbers - 1; i++) {

        if (i == ((arrayNumbers-1) - i)) {
            numbers.Add(nums[i]);
            break;
        }

        if (i == arrayNumbers / 2) {
           break;
        }
        numbers.Add(nums[i] * nums[(arrayNumbers-1) - i]);
    }
    printArray(nums);
    printList(numbers);
}





Console.WriteLine("\n");
Console.WriteLine("TASK_3");
Console.WriteLine("Найдите произведение пар чисел в одномерном массиве. \nПарой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");

multiplicationParsNumbers(10);