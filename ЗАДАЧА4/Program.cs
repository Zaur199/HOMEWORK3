// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите длину");
int N = int.Parse(Console.ReadLine());
int count = 1;
int i = 1;
while(i <= N)
{
    count = (count*i);
    i++;
}
 Console.WriteLine("Произведение чисел в длине равно: " + count);