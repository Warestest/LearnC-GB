/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void printMatrix(double[,] matrix){
for (int i = 0; i < matrix.GetLength(0); i++)
{
 for (int j = 0; j < matrix.GetLength(1); j++)
 {
 Console.Write($"{matrix[i, j]} ");
 }
Console.WriteLine();
}
}

double[,] randMatrix(double[,] matrix){
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round (new Random().NextDouble()* 10 - (new Random().NextDouble()* 10),2);
        }
    
    }
    return matrix;
}

double[,] matrix = new double[3, 4];



printMatrix(matrix);
randMatrix(matrix);
Console.WriteLine();
printMatrix(matrix);


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void findNumberInMatrix(int[,] matrix, int number){
int count = 0;
if( matrix.GetLength(0) * matrix.GetLength(1) < number || number < 1 )
        {
        Console.Write("Числа с таким номером в массиве нет");
        return;
        }
for (int i = 0; i < matrix.GetLength(0); i++)
{
 for (int j = 0; j < matrix.GetLength(1); j++)
 {  
    count++;
    if(count == number){
        
        Console.Write($"Элемент номер {number} это {matrix[i, j]} ");
        break;
    }    
 }    
}
}

int[,] matrix = new int[,]{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8 ,4, 2, 4},
};
printMatrix(matrix);

Console.Write("Введите номер позиции элемента: ");
int number = int.Parse(Console.ReadLine());
findNumberInMatrix(matrix, number);
*/



/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/





int[,] matrix = new int[,]{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8 ,4, 2, 4},
};


void avgColumnMatrix(int[,] matrix){
Console.Write ("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avg = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avg = (avg + matrix[i, j]);
    }
    avg = Math.Round ( avg / matrix.GetLength(0) , 2);
    Console.Write(avg + "; ");
}
Console.WriteLine();
}
avgColumnMatrix(matrix);




