/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает число, проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//Task_1
double[,] getArrayDouble(int m, int n) {
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
         for(int j = 0; j < n; j++){
             result[i,j] = new Random().NextDouble() * 10;
        }
    }
    return result;
}

void printArrayDouble(double[,] array) {
     for(int i = 0; i < array.GetLength(0); i++) {
         for(int j = 0; j < array.GetLength(1); j++) {
             Console.Write($"{array[i,j]} ");
        }
         Console.WriteLine();
    }
}

Console.WriteLine("\n");
Console.WriteLine("TASK_1");
Console.WriteLine("Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] arrayDouble = getArrayDouble(rows, columns);
printArrayDouble(arrayDouble);


//Task_2

int[,] getArrayInt(int m, int n) {
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
         for(int j = 0; j < n; j++){
             result[i,j] = new Random().Next(1,10);
        }
    }
    return result;
}

void printArrayInt(int[,] array) {
     for(int i = 0; i < array.GetLength(0); i++) {
         for(int j = 0; j < array.GetLength(1); j++) {
             Console.Write($"{array[i,j]} ");
        }
         Console.WriteLine();
    }
}

bool checkNumberWithArrayInt (int[,] array, int number) {
    for(int i = 0; i < array.GetLength(0); i++) {
         for(int j = 0; j < array.GetLength(1); j++) {
             if (array[i,j] == number) {
                return true;
             }
        }
    }
    return false;
}

Console.WriteLine("\n");
Console.WriteLine("TASK_2");
Console.WriteLine("Напишите программу, которая на вход принимает число, проверяя есть ли такое число\nв двумерном массиве и возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int[,] arrayInt = getArrayInt(5, 5);
printArrayInt(arrayInt);

if (checkNumberWithArrayInt(arrayInt, number)) {
    Console.WriteLine($"{number} -> такое число есть в массиве");
} else {
    Console.WriteLine($"{number} -> такого числа нет в массиве");
}


//Task_3

void averageArrayInt (int[,] array) {
    for(int i = 0; i < array.GetLength(1); i++) {
        double averageNumber = 0;
        for(int j = 0; j < array.GetLength(0); j++) {
            averageNumber += array[j,i];
        }
        Console.Write($"{averageNumber/array.GetLength(0)} ");
    }
}

Console.WriteLine("\n");
Console.WriteLine("TASK_3");
Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце");

printArrayInt(arrayInt);
averageArrayInt(arrayInt);