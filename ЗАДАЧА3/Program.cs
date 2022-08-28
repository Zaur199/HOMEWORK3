// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
int sum = 0;
 while(A > 0)
 {
    sum = sum + A % 10;
    A = A / 10;
 }
 Console.WriteLine($"Сумма цифр в числе A равно: {sum}");