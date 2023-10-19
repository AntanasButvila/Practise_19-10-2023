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

Console.Write("Введите координату по оси ОХ: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси ОY: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("I четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("II четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("III четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("IV четверть");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("Начало координат: (0,0)");
}
else // x = 0, y != 0 (0,5) => x = 0, y = 5
{
    Console.WriteLine("Точка лежит на оси. Одна из координат равна 0");
}