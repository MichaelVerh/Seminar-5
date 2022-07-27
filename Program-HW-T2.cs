// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на четных позициях.
int[] array=new int[8];
    FillArray(array, 0, 10);
    PrintArray(array);

    int sum=0;
    for(int i=0; i<array.Length; i++)
    {
        if (i%2==1) sum+=array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных местах, равна {sum}");




void FillArray(int[] array, int startNumber=0, int finishNumber=1)
{
    finishNumber++;
    Random random=new Random();
    for (int i=0; i<array.Length; i++)
    {
        array[i]=random.Next(startNumber, finishNumber);
    }
}


void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]+"\t");
    }
    Console.WriteLine();
}