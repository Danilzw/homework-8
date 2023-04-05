//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int [,]getarray(int [,]array)
{
    
    int temp = 0;
    int i=1;
    int j=1;
    while(true)
    {
        temp++;
        array[i,j] = temp;
        if(array[i,j + 1] == 0 && array[i-1,j] != 0)
        {
            j++;
            continue;
        }
        if(array[i+1,j] == 0)
        {
            i++;
            continue;
        }
        if(array[i,j-1] == 0)
        {
            j--;
            continue;
        }
        if(array[i-1,j] ==0)
        {
            i--;
            continue;
        }
        break;
    }
    return array;
}

void printarray(int [,] array)
{
    for(int i=1;i<array.GetLength(0)-1;i++)
    {
        for(int j=1;j<array.GetLength(1)-1;j++)
        {
            System.Console.Write(array[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int [,] array = new int[6,6];

for(int i=0;i<6;i++)
{
    for(int j=0;j<6;j++)
    {
        array[i,j] = 1;
    }
}

for(int i=1;i<5;i++)
{
    for(int j=1;j<5;j++)
    {
        array[i,j] = 0;
    }
}
getarray(array);
printarray(array);