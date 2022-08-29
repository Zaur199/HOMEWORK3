// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[]array = {0, 9, 9, 0, 0, 0, 9, 9, 0, 9, 0, 9};
int sum = 0;
int sum1 = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        sum = sum + array[i]; 
          
    }
 
    else if(array[i] < 0)
    {
        sum1 = sum1 + array[i]; 
        
    }

    else
        Console.WriteLine();

} 
Console.WriteLine("Сумма положительных чисел в массиве равна: " + sum); 
Console.WriteLine("Сумма отрицательных чисел в массиве равна: " + sum1);   
