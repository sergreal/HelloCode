﻿/*

Console.WriteLine ("Введи имя: ");
string name = Console.ReadLine();
Console.Write ("Салют, "+name);


Console.WriteLine("Hello, World!");
Console.ReadLine();
int
string
new Random().Next()

if Console.WriteLine()


// ------------------------------------------


int x = new Random().Next(10,100);
    int x1 = x/10;
    int x2 = x%10;
    Console.WriteLine($"Сгенерировано случайное число {x} ");
    if (x1>x2) Console.WriteLine("Первая цифра больше");
    else if (x2>x1) Console.WriteLine("Вторая цифра больше");
    else Console.WriteLine("Это паллиндром!");


int num1 = new Random().Next();



void NewTask ()
{
int num = new Random().Next (100, 1000);

int res =  num/100;
int res1 = num%10;

Console.WriteLine(num);
Console.WriteLine($"{res}{res1}");
}

NewTask ();


*/



/*
void First ()
{

Console.WriteLine("Введите ваше имя: ");
string name = Console.ReadLine();

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int num = new Random().Next(1,100); 


if (num > 50) Console.WriteLine($"{name} -рандомное {num}, ввели первое {num1}");
else if (num < 50) Console.WriteLine($"{name} -рандомное - {num}, ввели второе {num2}");
else Console.WriteLine($"И получается что {name}, рандомное {num}, а оба ввели {num1} и {num2}");
}

First ();

*/










//-----------------------------------------------
/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
void Task_2()
{
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 
if (num1>num2) Console.WriteLine($"Из двух введенных чисел {num1} и {num2}, число {num1} большее, а число {num2} меньшее.");
else Console.WriteLine($"Из двух введенных чисел {num1} и {num2}, число {num2} большее, а число {num1} меньшее.");
}
Task_2();
*/


//-----------------------------------------------
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
void Task_4()
{
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine()); 

if (num1>num2 & num1>num3) Console.WriteLine($"Из трех введенных чисел {num1}, {num2} и {num3}, максимальное число - {num1}");
else if (num2>num3 & num2>num1) Console.WriteLine($"Из трех введенных чисел {num1}, {num2} и {num3}, максимальное число - {num2}");
else Console.WriteLine($"Из трех введенных чисел {num1}, {num2} и {num3}, максимальное число - {num3}");
}
Task_4();
*/


//-----------------------------------------------
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
void Task_6()
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) Console.WriteLine($"Число {num} - является четным числом.");
else Console.WriteLine($"Число {num} - является нечетным числом.");
}
Task_6();
*/


//-----------------------------------------------
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
void Task_8()
{
    int num = 1;
    Console.Write("Введите число: ");
    int num0 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Список четных чисел: ");
    while (num < num0)
    {
        if (num%2 == 0) Console.Write($"{num}, ");
        num = num + 1;
    }
    Console.Write("End.");

}
Task_8();
*/


