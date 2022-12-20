
/*
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Обязательна проверка на ввод чисел больше/меньше 3-х знаков

456 -> 5
782 -> 8
918 -> 1

Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Обязательна проверка на ввод числа <1 и >7

6 -> да
7 -> да
1 -> нет
*/

//1
Console.WriteLine("\n");
Console.WriteLine("TASK_1");
while (true) {
    Console.WriteLine("Введите трехзначное число");
    int oneNumber = Convert.ToInt32(Console.ReadLine());
    string convertOneNumberToString = Convert.ToString(oneNumber);

    int convertOneNumberToStringLength = convertOneNumberToString.Length;

    if (convertOneNumberToStringLength == 3) {
        Console.WriteLine($"{convertOneNumberToString} -> {convertOneNumberToString[1]}");
        break;
    } else {
        Console.WriteLine("Неправильное число");
    }
}

//2
Console.WriteLine("\n");
Console.WriteLine("TASK_2");
Random random = new Random();
int randomNumber = random.Next(1, 100000);
string convertRandomNumberToString = Convert.ToString(randomNumber);
int convertRandomNumberToStringLength = convertRandomNumberToString.Length;
if (convertRandomNumberToStringLength > 3) {
    Console.WriteLine($"{convertRandomNumberToString} -> {convertRandomNumberToString[2]}");
} else {
    Console.WriteLine($"{convertRandomNumberToString} -> третьей цифры нет");
}

//3
Console.WriteLine("\n");
Console.WriteLine("TASK_3");
while (true) {
    Console.WriteLine("Введите день недели");
    int oneDay = Convert.ToInt32(Console.ReadLine());

    if ((oneDay > 0) && (oneDay < 8)) {
        if (oneDay > 5) {
            Console.WriteLine($"{oneDay} -> выходной");
            break;
        } else {
            Console.WriteLine($"{oneDay} -> не выходной");
            break;
        }
    } else {
        Console.WriteLine("Неправильный день недели");
    }
}