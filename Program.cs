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

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    while (number >= 1000)
    {
        number /= 10;
        // 12345 / 10 = 1234(number)
        // 1234 / 10 = 123 (number)
        // number = number / 10;
    }
    int thirdDigit = number % 10; // 123 % 10 = 3
    Console.WriteLine($"Третья цифра в числе {number} => {thirdDigit}");
}
else
{
    // number < 100
    Console.WriteLine("Число не лежит в интересующем нас диапазоне");
}