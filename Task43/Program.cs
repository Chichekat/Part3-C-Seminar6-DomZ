// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение B1: ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение K1: ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение B2: ");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение K2: ");
double k2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Точка пересечения: ({Point(b1, k1, b2, k2)})");

string Point (double b1, double k1, double b2, double k2){
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
string result = x.ToString() + "; " + y.ToString();
return result;
}