Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int c = b * b;

if (c == a)
{
    Console.WriteLine($"первое число {a} является квадратом {b}");
}
else 
{
    Console.WriteLine($"первое число {a} не является квадратом {b}");
}

