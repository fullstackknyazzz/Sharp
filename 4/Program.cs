/* ВСЕ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

3, 5 -> 243 (3⁵)

2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)*/

//Task 1
int mathPowWithCycle (int A, int B) {
    int mathPowNumber = A;
    for (int i = 0; i < B-1; i++ ) {
        mathPowNumber = mathPowNumber * A;
    }
    return mathPowNumber;
}

Console.WriteLine("\n");
Console.WriteLine("TASK_1");
Console.WriteLine("Возводит число A в натуральную степень B");
Console.WriteLine("Введите два числа");
Console.Write("A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("B = ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(mathPowWithCycle(A, B));

//Task 2

int sumNumbers (string number) {
    int sum = 0;
    for (int i = 0; i < number.Length; i++) {
        sum = sum + Convert.ToInt32(Convert.ToString(number[i]));
    }
    return sum;
}

Console.WriteLine("\n");
Console.WriteLine("TASK_2");
Console.WriteLine("Вывод суммы цифр в числе");
Console.WriteLine("Введите число");
string number = Console.ReadLine();
Console.WriteLine(sumNumbers(number));


//Task 3
void randomArray () {
    int [] array = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = rnd.Next(0, 100);
        Console.WriteLine(array[i]);
    }
}


Console.WriteLine("\n");
Console.WriteLine("TASK_3");
Console.WriteLine("Вывод массива из восьми элементов");
randomArray();