﻿System.Console.WriteLine("Введите первое число "); //не делал проверку на "число или не число",
string s = Console.ReadLine();                     // решение есть в задаче №2
int i = int.Parse(s);

System.Console.WriteLine("Введите второе число "); 
string t = Console.ReadLine();
int j = int.Parse(t);

System.Console.WriteLine("Введите третье число "); 
string e = Console.ReadLine();
int k = int.Parse(e);

int max = 0;

if (max < i)
{
    max = i;
}

if (max < j)
{
    max = j;
}

if (max < k)
{
    max = k;
}

System.Console.WriteLine($"Максимальное число : {max}");