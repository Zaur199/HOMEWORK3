// Показать кубы чисел, заканчивающихся на четную цифру от 1 до N
Console.WriteLine("Введите длину");
int N = int.Parse(Console.ReadLine());

for(int i = 1; i <= N; i++)
    if(i*i*i % 2 == 0)
{
    Console.WriteLine("Кубы чисел, заканчивающихся на четную цифру: " + i*i*i);
}