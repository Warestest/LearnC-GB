
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите число степени B");
int b = Convert.ToInt32(Console.ReadLine());

int tostep(int a, int b){
int step = a;

    for (int i = 1; i < b; i++)
    {
    step = step * a;
    }
    return step;
}
int step = tostep(a, b);
Console.WriteLine($"{a} в степени {b} равно: " + step);

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число для суммирования: ");
int number = int.Parse(Console.ReadLine());

  int SumOfDigits(int number){
    
    int count = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }
  int sumNumber = SumOfDigits(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] arr = new int[8];

for (int i = 0; i < 8; i++){
Console.Write($"Введите {i + 1} число массива из {arr.Length} если числа нет введите 0: ");
int number = int.Parse(Console.ReadLine());
arr[i] = number;
}

Console.Write($"[{arr[0]} , {arr[1]} , {arr[2]} , {arr[3]} , {arr[4]} , {arr[5]} , {arr[6]} , {arr[7]}]");