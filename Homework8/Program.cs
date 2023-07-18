/*

Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
void printMatrix(int[,] matrix){
for (int i = 0; i < matrix.GetLength(0); i++)
{
 for (int j = 0; j < matrix.GetLength(1); j++)
 {
 Console.Write($"{matrix[i, j]} ");
 }
Console.WriteLine();
}
}

int[,] matrix = new int[,]{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8 ,4, 2, 4},
};
void sortToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Исходный массив");
printMatrix(matrix);
Console.WriteLine();
sortToMin(matrix);
Console.WriteLine("Отсортированный массив");
printMatrix(matrix);
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


void printMatrix(int[,] matrix){
for (int i = 0; i < matrix.GetLength(0); i++)
{
 for (int j = 0; j < matrix.GetLength(1); j++)
 {
 Console.Write($"{matrix[i, j]} ");
 }
Console.WriteLine();
}
}



void sumRowMatrix(int[,] matrix){
    int index = 0;
    int[] arraySUM = new int[matrix.GetLength(0)];
    int minsum = arraySUM[0];
    
for (int i = 0; i < matrix.GetLength(0); i++)
    {       int tempsum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempsum += matrix[i, j];
            if (tempsum > minsum)
                {
                    minsum = tempsum;
                    index = i;
                }
        }
        Console.WriteLine($" сумма строки {i}  {tempsum}");
        arraySUM[i] = tempsum;
        

        
}
for (int i = 0; i < arraySUM.Length; i++)
{
    if (arraySUM[i] < minsum){
    minsum = arraySUM[i];
    index = i;
    }
    Console.WriteLine(arraySUM[i]);
}
Console.WriteLine($"номер самой маленькой строки {index}");

}

int[,] matrix = new int[,]{
{1, 40, 7, 2},
{0, 11, 20, 3},
{8 ,4, 2, 4},
};

printMatrix(matrix);
sumRowMatrix(matrix);



/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


