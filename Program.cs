// Задача 1: Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.

/*
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 7 == 0 && n % 23 == 0) {
    Console.WriteLine("да");
} else {
    Console.WriteLine("нет");
}
*/

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

/* 
Console.Clear();
Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine()!);
if (x == 0 || y == 0) {
    Console.WriteLine("Координаты не должны быть равны 0");
} else {
    if (x > 0) {
        if (y > 0) {
            Console.WriteLine("1");    
        } else {
            Console.WriteLine("4");
        }
    } else {
        if (y > 0) {
            Console.WriteLine("2");    
        } else {
            Console.WriteLine("3");
        }
    }
}
*/

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

/* 
Console.Clear();
Console.Write("Введите 2-х значное число: ");
int n = int.Parse(Console.ReadLine()!);
if (n >= 10 && n <= 99) {
    int n1 = n / 10;
    int n2 = n % 10;
    if (n1 > n2) {
        Console.WriteLine(n1);
    } else if (n1 < n2) {
        Console.WriteLine(n2);
    } else {
        Console.WriteLine("Равны");
    }
} else {
    Console.WriteLine("Эй, Кожанный, введи 2-х значное число");
}
*/

// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.


/*
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while (n > 0) {
    Console.Write(n % 10);
    if (n > 9) {
        Console.Write(", ");
    }
    n = n / 10;
} 
Console.WriteLine();
*/