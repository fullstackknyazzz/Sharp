/*
Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


//Task_1
Console.WriteLine("\n");
Console.WriteLine("TASK_1");
Console.WriteLine("Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");

int recursionNaturalNumber (int n) {
    if (n == 1) {
        Console.Write($"{1}, ");
        return 1;
    } else {
        Console.Write($"{n}, ");
        return recursionNaturalNumber(n - 1);
    }
}

recursionNaturalNumber(10);
//Task_2
Console.WriteLine("\n");
Console.WriteLine("TASK_2");
Console.WriteLine("Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");


int recursionSumNaturalNumber (int M, int N) {
    if (M == N) {
        return M;
    } else {
        return M + recursionSumNaturalNumber(M + 1 , N);
    }
}

Console.WriteLine(recursionSumNaturalNumber(1, 10));

//Task_3
Console.WriteLine("\n");
Console.WriteLine("TASK_3");
Console.WriteLine("Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

int akkermanFunction(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return akkermanFunction(n - 1, 1);
    else
      return akkermanFunction(n - 1, akkermanFunction(n, m - 1));
}

Console.WriteLine(akkermanFunction(2, 3));