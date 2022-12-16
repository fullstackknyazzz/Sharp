/*
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

//One task
Console.WriteLine("Task1");
Console.WriteLine("Enter two numbers");
int oneNumber = Convert.ToInt32(Console.ReadLine());
int twoNumber = Convert.ToInt32(Console.ReadLine());
if (oneNumber > twoNumber) {
    Console.WriteLine($"a = {oneNumber}; b = {twoNumber} -> max = {oneNumber}, min = {twoNumber}");
} else {
    Console.WriteLine($"a = {oneNumber}; b = {twoNumber} -> max = {twoNumber}, min = {oneNumber}");
}


//Two task
Console.WriteLine("Task2");
Console.WriteLine("Enter three numbers");
oneNumber = Convert.ToInt32(Console.ReadLine());
twoNumber = Convert.ToInt32(Console.ReadLine());
int threeNumber = Convert.ToInt32(Console.ReadLine());

if ((oneNumber > twoNumber) && (oneNumber > threeNumber)) {
    Console.WriteLine($"{oneNumber},{twoNumber},{threeNumber} -> {oneNumber}");
} else if ((twoNumber > oneNumber) && (twoNumber > threeNumber)) {
    Console.WriteLine($"{oneNumber},{twoNumber},{threeNumber} -> {twoNumber}");
} else if ((threeNumber > twoNumber) && (threeNumber > twoNumber)) {
    Console.WriteLine($"{oneNumber},{twoNumber},{threeNumber} -> {threeNumber}");
}


//Three task
Console.WriteLine("Task3");
Console.WriteLine("Enter one number");
oneNumber = Convert.ToInt32(Console.ReadLine());
if (oneNumber % 2 == 0) {
    Console.WriteLine($"{oneNumber} -> yes");
} else {
    Console.WriteLine($"{oneNumber} -> no");
}

//Four task
Console.WriteLine("Task4");
Console.WriteLine("Enter one number");
oneNumber = Convert.ToInt32(Console.ReadLine());
int startValueNumber = 1;
while (startValueNumber < oneNumber) {
    if (startValueNumber % 2 == 0) {
        Console.Write($"{startValueNumber}, ");
        startValueNumber += 2;
    } else {
        startValueNumber += 1;
    }
}