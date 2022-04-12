/*
Задача 72: Заданы 2 массива: info и data. В массиве data хранятся двоичные представления 
нескольких чисел (без разделителя). В массиве info хранится информация о количестве бит,
которые занимают числа из массива info. Напишите программу, которая составит массив десятичных
представлений чисел массива data с учётом информации из массива info.
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1
*/

void DecimalNumberPrint(int[] arrayData, int[] arrayInfo, int count = 0, int i = 0, int length = 0)
{
    if (count < arrayInfo.Length)
    {
        length += arrayInfo[count];
        int pow = arrayInfo[count];
        double numberDecimal = 0;
        while (i < length)
        {
            pow--;
            numberDecimal += arrayData[i] * Math.Pow(2, pow);
            i++;
        }
        Console.Write($"{numberDecimal} ");
        DecimalNumberPrint(arrayData, arrayInfo, count + 1, i, length);
    }
}

Console.WriteLine("Введите массив data: ");
int[] dataUser = Console.ReadLine()!.Split().Select(x=> Convert.ToInt32(x)).ToArray();
Console.WriteLine("Введите массив info: ");
int[] infoUser = Console.ReadLine()!.Split().Select(x=> Convert.ToInt32(x)).ToArray();

Console.WriteLine("Зашифрованная последовательность десятичных чисел: ");
DecimalNumberPrint(dataUser, infoUser);
