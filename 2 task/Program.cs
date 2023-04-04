//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] getarray(int [,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(1,9);
        }
    }

    return array;
}

void printArray(int [,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            System.Console.Write(array[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int [,] array = new int [4,4];


getarray(array);

printArray(array);

int getmin(int [,] array)
{   
    int result = 0;
    int min = 99999;
    for(int i=0;i<array.GetLength(0);i++)
    {
        int temp = 0;
        for(int j=0;j<array.GetLength(1);j++)
        {
           temp = array[i,j] + temp;
        }
        if(temp < min)
        {
            min = temp;
            result = i;
        }
    }

    return result;
}

int result = getmin(array);

System.Console.WriteLine("--------------");
System.Console.Write(result + 1);