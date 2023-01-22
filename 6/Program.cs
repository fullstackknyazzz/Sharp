/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)(пользователь вводит в консоли числа через пробел и они формируют строку)

Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
*/


Console.WriteLine("\n");
Console.WriteLine("TASK_1");
Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользовател");

int countNumsMoreZero (string stringArray1) {
    
    string[] numS = stringArray1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int countNumsMoreZero = 0;
    for (int i = 0; i < numS.Length; i++) {
        if (Convert.ToInt32(numS[i]) > 0) {
            countNumsMoreZero++;
        }
    }
    return countNumsMoreZero;
}

string stringArray1 = Console.ReadLine();
Console.WriteLine($"{stringArray1} -> {countNumsMoreZero(stringArray1)}");





Console.WriteLine("\n");
Console.WriteLine("TASK_2");
Console.WriteLine("Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, \nа на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему)");


bool checkLength (string[] numS) {
     if (numS.Length < 6) {
        Console.WriteLine("Введите больше цифр");
        return true;
    } else {
        return false;
    }
}

bool checkNumbers (string[] numS, int[] numSInt) {
    for (int i = 0; i < numS.Length; i++) {
        numSInt[i] = Convert.ToInt32(numS[i]);
        if (numSInt[i] < 0 || numSInt[i] > 100) {
            Console.WriteLine("Цифры должны быть от 0 до 100");
            return true;
        }
    }
    return false;
}

bool arraySort (int[] numSInt) {
    Array.Sort(numSInt);
    foreach (int num in numSInt)
    {
        Console.Write($"{num} ");
    }
    Console.WriteLine("\n");
    return true;
}

while (true) {
    Console.WriteLine("Введите массив чисел не менее 6 и от 0 до 100:");
    string stringArray = Console.ReadLine();
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (checkLength(numS)) {
        continue;
    }

    int [] numSInt = new int[numS.Length];

    if (checkNumbers(numS, numSInt)) {
        continue;
    }

    if (arraySort(numSInt)) {
        break;
    }
    
}