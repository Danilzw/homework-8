//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int [,]getarray(int [,]array)
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

void printarray(int [,] array)
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


int [,]getarray1(int [,]array)
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

void printarray1(int [,] array)
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

int [,] array2= new int [2,2];
int [,] array1 = new int [2,2];

getarray(array1);
printarray(array1);

System.Console.WriteLine("----------------");

getarray(array2);
printarray(array2);

System.Console.WriteLine("=====================");

int [,] getresult(int [,] array1,int [,] array2)
{  
    int [,] array3 = new int [array1.GetLength(0),array2.GetLength(1)];
     for (int i = 0; i <array3.GetLength(0); i++)
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
                array3[i, j] = 0;
                for (int n = 0; n < array1.GetLength(1); n++)
                {
                    array3[i, j] += array1[i, n] * array2[n, j];
                }
            }
        }



    return array3;
}

getresult(array1,array2);

printarray(getresult(array1,array2));