// // Бесконечный ввод сообщения
// // Если ввели число, бесконечный цикл останавливаем
// while (true) 
// {
//     Console.Write("Введите число: ");
//     string stringNumber = Console.ReadLine();
//     int number; // Ничего не клал в нее
//     bool isNumber = int.TryParse(stringNumber, out number);
//     // Если isNumber == true, значит строчка stringNumber 
//     // состоит ТОЛЬКО из цифр; false - в строке есть буквы.
//     // Если в stringNumber только цифры, то 
//     // в переменную number попадет само число; иначе - 0
//     if (isNumber) // isNumber == true
//     {
//         Console.WriteLine("Вы ввели цифры. Цикл закончился");
//         break; 
//     }
// }

// Задача 13: Напишите программу, 
// которая выводит третью цифру 
// заданного числа или сообщает, 
// что третьей цифры нет.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100)
// {
//     while (number >= 1000)
//     {
//         number /= 10;
//         // 12345 / 10 = 1234(number)
//         // 1234 / 10 = 123 (number)
//         // number = number / 10;
//     }
//     int thirdDigit = number % 10; // 123 % 10 = 3
//     Console.WriteLine($"Третья цифра в числе {number} => {thirdDigit}");
// }
// else
// {
//     // number < 100
//     Console.WriteLine("Число не лежит в интересующем нас диапазоне");
// }




// Задача №17. Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер 
// четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координату по оси ОХ: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по оси ОY: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("I четверть");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("II четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("III четверть");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("IV четверть");
// }
// else if (x == 0 && y == 0)
// {
//     Console.WriteLine("Начало координат: (0,0)");
// }
// else // x = 0, y != 0 (0,5) => x = 0, y = 5
// {
//     Console.WriteLine("Точка лежит на оси. Одна из координат равна 0");
// }

// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// x1 = 3, y1 = 6; x2 =2, y2 = 1
// A (7,-5); B (1,-1) -> 7,21



// Console.Write("Введите х1 : ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите у1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите х2 : ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите у2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// // d = distance (расстояние между 2 точками)
// // AB = √(x1 - x2)2 + (y1 - y2)2
// // Math.Sqrt(25) = 5 
// // Math.Pow(число, степень) => Math.Pow(2, 3) => 2*2*2 = 8
// double d = Math.Sqrt((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2)));
// // Math.Round(число, кол-во знаков): Math.Round(1.275, 2) => 1.27
// Console.WriteLine($"d = {Math.Round(d, 2)}"); // d до 2 знаков
// Console.WriteLine($"d = {d:f2}"); // {имя:fкол-воз_наков}


// Напишите программу, которая принимает
// на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// while
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 1; // Начало

while (start <= N) // start += 1
{
    Console.Write($"{Math.Pow(start, 2)}\t");
    start += 1; //start = start + 1
}

// for
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
// (точка входа; условие цикла: действие со счетчиком)
// start++ - это start = start + 1 (Инкремент)
// start-- - это start = start - 1 (Декремент)
for (int start = 1; start <= N; start++)
{
    Console.Write($"{Math.Pow(start, 2)}\t");
}
// int start = 1; // Начало

// while (start <= N) // start += 1
// {
//     Console.Write($"{Math.Pow(start, 2)}\t");
//     start += 1; //start = start + 1
// }