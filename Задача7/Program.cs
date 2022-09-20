Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int N = Math.Abs(int.Parse(Console.ReadLine()));

if (N < 100 || N > 999) {
    Console.Write("Вы ввели не трехзначное число");
    return;
} else {
    Console.Write(N % 10);
}