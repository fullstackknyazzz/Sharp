/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

-------------------Задачи повышенной сложности---------------------
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

//Task_1
Console.WriteLine("\n");
Console.WriteLine("TASK_1");
Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");


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

int [,] sortTwoDimensionalArray (int [,] intTwoDimensionalArray) {
    for(int i = 0; i < intTwoDimensionalArray.GetLength(0); i++) {
        for(int j = 0; j < intTwoDimensionalArray.GetLength(1); j++) {
            for (int m = 0; m < intTwoDimensionalArray.GetLength(1) - 1 - j; m++) {
                if (intTwoDimensionalArray[i, m] < intTwoDimensionalArray[i, m + 1]) {
                    int temp = intTwoDimensionalArray[i, m];
                    intTwoDimensionalArray[i, m] = intTwoDimensionalArray[i, m + 1];
                    intTwoDimensionalArray[i, m + 1] = temp;
                }
            }
        }
    }
    return intTwoDimensionalArray;
}

int [,] intTwoDimensionalArray = getArrayInt(4,4);
printArrayInt(intTwoDimensionalArray);
Console.WriteLine("\n");
int [,] sortIntTwoDimensionalArray = sortTwoDimensionalArray(intTwoDimensionalArray);
printArrayInt(intTwoDimensionalArray);



//Task_2
Console.WriteLine("\n");
Console.WriteLine("TASK_2");
Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

int [] makeSumOfArrayRows (int [,] intTwoDimensionalArray) {

    int [] sumOfArrayRows = new int [intTwoDimensionalArray.GetLength(0)];
    int countElementSumOfArrayRows = 0;

    for(int i = 0; i < intTwoDimensionalArray.GetLength(0); i++) {
        int sumStringArray = 0;
        for(int j = 0; j < intTwoDimensionalArray.GetLength(1); j++) {
            sumStringArray =+ sumStringArray + intTwoDimensionalArray[i, j];
            if (j == intTwoDimensionalArray.GetLength(1) - 1) {
                sumOfArrayRows[countElementSumOfArrayRows] = sumStringArray;
                countElementSumOfArrayRows++;
            }
        }
    }
    return sumOfArrayRows;
}

void printArrayOneInt(int[] array) {
     for(int i = 0; i < array.GetLength(0); i++) {
             Console.Write($"{array[i]} ");
    }
}

void getMinIndexArraySum (int [] array) {
    int minElement = array.Min();
    for (int i = 0; i < array.GetLength(0);i++) {
        if (array[i] == minElement) {
            Console.Write(i+1);
        }
    }
}

int [,] intTwoDimensionalArray2 = getArrayInt(4,4);
printArrayInt(intTwoDimensionalArray2);
getMinIndexArraySum(makeSumOfArrayRows(intTwoDimensionalArray2));



//Task_3
Console.WriteLine("\n");
Console.WriteLine("TASK_3");
Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
int [,] oneMatrix = getArrayInt(3,3);
int [,] twoMatrix = getArrayInt(3,3);

int[,] multipleMatix(int[,] oneMatrix, int[,] twoMatrix) {
    if (oneMatrix.GetUpperBound(1) + 1 != twoMatrix.GetUpperBound(0) + 1) {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    int [,] threeMatrix = new int[oneMatrix.GetUpperBound(0) + 1, twoMatrix.GetUpperBound(1) + 1];

    for (int i = 0; i < oneMatrix.GetUpperBound(0) + 1; i++) {
        for (int j = 0; j < twoMatrix.GetUpperBound(1) + 1; j++) {
            threeMatrix[i, j] = 0;
            for (int k = 0; k < oneMatrix.GetUpperBound(1) + 1; k++) {
                    threeMatrix[i, j] += oneMatrix[i, k] * twoMatrix[k, j];
            }
        }
    }

    return threeMatrix;
}

printArrayInt(oneMatrix);
Console.WriteLine("\n");
printArrayInt(twoMatrix);
Console.WriteLine("\n");
int [,] ThreeMatrix = multipleMatix(oneMatrix, twoMatrix);
printArrayInt(ThreeMatrix);



//Task_4
Console.WriteLine("\n");
Console.WriteLine("TASK_4");
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

int[,,] getArrayInt3D(int m, int n, int c) {
    int[,,] result = new int[m,n,c];
    for(int i = 0; i < m; i++){
         for(int j = 0; j < n; j++){
                for(int k = 0; k < c; k++){
                    result[i,j,k] = new Random().Next(10,100);
                }
        }
    }
    return result;
}

void printArrayInt3D(int[,,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int [,,] array3D = getArrayInt3D(2,2,2);
printArrayInt3D(array3D);

//Task_5
Console.WriteLine("\n");
Console.WriteLine("TASK_5");
Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4.");

int [,] getSpiralArray4By4 () {
    int[,] sqareMatrix = new int[4, 4];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1)) {
        sqareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return sqareMatrix;
}

printArrayInt(getSpiralArray4By4());