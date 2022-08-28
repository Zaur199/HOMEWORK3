// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральную степень B для числа A");
int B = int.Parse(Console.ReadLine());
int count = 1;
for(int i = 1; i <= B; i++)
{
    count = count * A;
}

Console.WriteLine("Ответ: " + count);