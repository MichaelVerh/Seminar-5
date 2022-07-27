// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
Random random=new Random();
double[] array =new double[10];

for (int i=0; i<array.Length; i++)
{
    array[i]=Math.Round(random.NextDouble()*10-5, 2);
}
Console.WriteLine();
for (int i=0; i<array.Length; i++)
{
    Console.Write(array[i]+"\t");
}
Console.WriteLine();

double max=array[0];
double min=array[0];
for (int i=1; i<array.Length; i++)
{
    if (array[i]>max) max=array[i];
    else if (array[i]<min) min=array[i];
}
Console.WriteLine($"Максимальное значение равно {max}");
Console.WriteLine($"Минимальное значение равно {min}");
Console.WriteLine($"Разность между максимальным и минимальным элементом массива равна {max-min}");