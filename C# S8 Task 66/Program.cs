// Task 66

int GetSum(int a, int b)
{
    if (a == b)
    {
        return a;
    }
    if (a > b)
    {
        return b + GetSum(a, b + 1);
    }
    return a + GetSum(a + 1, b);
}
Console.Clear();
Console.Write("Введите первое число:");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(n, m));