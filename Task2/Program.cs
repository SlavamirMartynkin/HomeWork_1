System.Console.WriteLine("Введите первое число ");
string s = Console.ReadLine();
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