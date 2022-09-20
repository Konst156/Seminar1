Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());


if (N > 0) {
    int b = N * (-1);
    while(b <= N)
    {
        Console.Write($"{b} ");
        b++;
    }
} else {
    int b = N * (-1);
    while(b >= N)
    {
        Console.Write($"{N} ");
        N++;
    }
}
