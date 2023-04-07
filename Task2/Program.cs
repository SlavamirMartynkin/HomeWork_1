int i,j;

System.Console.WriteLine("Введите первое число ");
string s = Console.ReadLine();

if(int.TryParse(s, out i)) 
{                                                 
}
else
{
    while (i==0)
    {
        Console.WriteLine("Введите ЧИСЛО!");
        string s1 = Console.ReadLine();
        int.TryParse(s1, out i);
    }
    
}

System.Console.WriteLine("Введите Второе число ");
string t = Console.ReadLine();

if(int.TryParse(t, out j)) 
{                                                 
}
else
{
    while (j==0)
    {
        Console.WriteLine("Введите ЧИСЛО!");
        string t1 = Console.ReadLine();
        int.TryParse(t1, out j);
    }
}

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