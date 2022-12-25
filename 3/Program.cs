/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Проверка на пятизначность обязательна
14212 -> нет
12821 -> да
23432 -> да

Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

//Task1
Console.WriteLine("\n");
Console.WriteLine("TASK_1");
while (true) {
    Console.WriteLine("Введите пятизначное число");
    int oneNumber = Convert.ToInt32(Console.ReadLine());
    string convertOneNumberToString = Convert.ToString(oneNumber);

    int convertOneNumberToStringLength = convertOneNumberToString.Length;

    if (convertOneNumberToStringLength == 5) {
        if ((convertOneNumberToString[0] == convertOneNumberToString[4]) && (convertOneNumberToString[1] == convertOneNumberToString[3])) {
            Console.WriteLine($"{convertOneNumberToString} -> да");
            break;
        } else {
            Console.WriteLine($"{convertOneNumberToString} -> нет");
            break;
        }
    } else {
        Console.WriteLine("Неправильное число");
    }
}

//Task2
Console.WriteLine("\n");
Console.WriteLine("TASK_2");
Console.WriteLine("Введите первую координату точки через пробел");
string firstDot = Console.ReadLine();
string[] coordinatesFirstDot = (firstDot).Split(' ');
Console.WriteLine("Введите вторую координату точки через пробел");
string secondDot = Console.ReadLine();
string[] coordinatesSecondDot = (secondDot).Split(' ');

double oneExpression = Math.Pow((Convert.ToInt32(coordinatesSecondDot[0]) - Convert.ToInt32(coordinatesFirstDot[0])), 2);
double twoExpression = Math.Pow((Convert.ToInt32(coordinatesSecondDot[1]) - Convert.ToInt32(coordinatesFirstDot[1])), 2);
double threeExpression = Math.Pow((Convert.ToInt32(coordinatesSecondDot[2]) - Convert.ToInt32(coordinatesFirstDot[2])), 2);
double distanceDots = Math.Sqrt(oneExpression + twoExpression + threeExpression);

Console.WriteLine($"A ({coordinatesFirstDot[0]},{coordinatesFirstDot[1]},{coordinatesFirstDot[2]}); B ({coordinatesSecondDot[0]},{coordinatesSecondDot[1]},{coordinatesSecondDot[2]}) -> {Math.Round(distanceDots,2)}");

//Task3
Console.WriteLine("\n");
Console.WriteLine("TASK_3");

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"{N} -> ");
for (int i = 1; i <= N; i++) {
    Console.Write($"{Math.Pow(i, 3)},");
}
