/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void isPalyndrome(string number){
  if (number[0]==number[4] && number[1]==number[3]){
    Console.WriteLine("да");
  }
  else Console.WriteLine("нет");
}

if (number!.Length == 5){
    isPalyndrome(number);
}
else Console.WriteLine($"Введи правильное число");



/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z1");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z2");
int z2 = int.Parse(Console.ReadLine());



double formulaSegmentLength(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) +  Math.Pow((z2-z1), 2));
}

double segmLength =  Math.Round (formulaSegmentLength(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmLength}");



/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int cubeNumber = int.Parse(Console.ReadLine());
//int i = 0;
for (int i = 1; i <= cubeNumber; i++){
    
    Console.Write($"{i * i * i} ");
}
