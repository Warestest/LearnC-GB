/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write (" Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99 && number < 1000) {
     int secondfigure = number % 100 / 10;
    Console.Write (secondfigure);

} else Console.WriteLine("Число вне диапазона"); 


/* 
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("число: ");
int number = int.Parse(Console.ReadLine());
if (number < -99 || number > 99)
{    
    if ((number % 10000) > 0)
        {
        while (number > 999)
                {
                    number /= 10;
                        }
                Console.Write(number % 10);
        }
    else Console.Write(number % 10);
    

}
else Console.WriteLine("третьей цифры нет");


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
 
Console.Write (" Введите цифру дня недели чтобы узнать выходной ли это: ");
int numberOfDay = int.Parse(Console.ReadLine());
if (numberOfDay > 0 && numberOfDay < 8) {
    if (numberOfDay < 6) {Console.WriteLine("нет");}
    else Console.WriteLine("да");
} else Console.WriteLine("Цифра вне диапазона"); 