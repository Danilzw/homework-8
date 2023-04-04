//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] getarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }

    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}

int[,] array = new int[4, 4];

getarray(array);
printArray(array);
System.Console.WriteLine("-----------------");

int[,] Fillarray(int[,] array)
{
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for(int k = 0;k<array.GetLength(1)-1;k++)
           {
                if(array[i,j]>array[i,k])
                {
                    min = array[i,k];
                    array[i,k] = array[i,j];
                    array[i,j] = min;

                }
           }
        }
    }

    return array;
}

int[,] finallyarray = Fillarray(array);

printArray(finallyarray);