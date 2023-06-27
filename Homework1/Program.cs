/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
Console.WriteLine(" Введите 1 число для сравнения");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите 2 число для сравнения");
int number2 = int.Parse(Console.ReadLine());
int maxNumber;
if (number1 > number2){maxNumber = number1;}
    else{maxNumber = number2;}
Console.WriteLine("max = " + maxNumber);



/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
Console.WriteLine(" Введите 1 число для сравнения");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите 2 число для сравнения");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите 3 число для сравнения");
int number3 = int.Parse(Console.ReadLine());
int maxNumber = number1;
if (maxNumber < number2){maxNumber = number2;}    
    else{if (maxNumber < number3){maxNumber = number3;}}
    if (maxNumber < number3){maxNumber = number3;}

Console.WriteLine("max = " + maxNumber);



/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
Console.WriteLine(" Введите число для определения четности");
int number1 = int.Parse(Console.ReadLine());
string odd;
if ((number1 % 2) == 0){odd = "да";}
    else {odd = "нет";}
    Console.WriteLine(odd);


/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8

Console.WriteLine(" Введите число для четных чисел от 0");
int myNumber = int.Parse(Console.ReadLine());
int endNumber = myNumber;
if ((myNumber % 2) == 0)
{
   endNumber = endNumber + 1; 
}
int odd = 2;
    while (odd < endNumber)
    {
        Console.Write($"{odd}, ");
        odd = odd + 2;
    };

*/
