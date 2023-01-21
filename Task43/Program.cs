// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float getIntFromUser(string message)
{
    Console.WriteLine(message);
    float userInt = int.Parse(Console.ReadLine());
    return userInt;
}

float k1 = getIntFromUser("Введите значение переменной k1: ");
float b1 = getIntFromUser("Введите значение переменной b1: ");
float k2 = getIntFromUser("Введите значение переменной k2: ");
float b2 = getIntFromUser("Введите значение переменной b2: ");

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

Console.WriteLine($"Координаты точки пересечения двух прямых ({x}; {y})");
