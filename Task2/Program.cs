System.Console.WriteLine("Введите первое число "); //Посмотрите вторую ветку, там решение
string s = Console.ReadLine();                     //с исключением некорректного ввода
int i = int.Parse(s);

System.Console.WriteLine("Введите Второе число ");
string t = Console.ReadLine();
int j = int.Parse(t);

if (i>j)
{
    System.Console.WriteLine($"Большее число {i}");
    System.Console.WriteLine($"Меньшее число {j}");
}
else if (j>i)
{
    System.Console.WriteLine($"Большее число {j}");
    System.Console.WriteLine($"Меньшее число {i}");
}
else
{
    System.Console.WriteLine("Числа равны");
}
