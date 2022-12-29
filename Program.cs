

/* ДОМАШНЕЕ ЗАДАНИЕ */

/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.*/
/*
void ShowNums(int num) //Выводит цифры от N до 1
{
    Console.Write(num + " ");
    if(num > 1) 
    {
        ShowNums(num - 1);
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/




/* Задача 66:Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.*/
/*

int SumMetod(int m, int n)
{
    int sum = 0;
    if (m <= n) return SumMetod(m + 1, n) + sum + m;
    return 0;   
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = SumMetod(m, n);
Console.Write(res);
*/


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

int AkkMetod(int m, int n)
{
    if(m == 0 && n != 0) return  n + 1;
    else
        if(n == 0 && m != 0) return AkkMetod(m - 1, 1);  
    else
        return AkkMetod(m - 1, AkkMetod(m, n - 1));          
}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = AkkMetod(m, n);
Console.Write(res);
