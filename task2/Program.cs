/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double [] PointOfIntersection (int k1, int b1, int k2, int b2, int size)
{
    double [] point = new double [size];
    point[0] = (double)(b2-b1)/(k1-k2);
    point[1] = k1 * point [0] + b1;
    return point;
}
void PrintArray (double [] array)
{
    Console.WriteLine ("Coords of your point: ");
    for (int i = 0; i<array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine("\b\b.");
}
Console.Write("Enter k1: ");
int userKOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b1: ");
int userBOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2: ");
int userKTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2: ");
int userBTwo = Convert.ToInt32(Console.ReadLine());
PrintArray(PointOfIntersection(userKOne, userBOne, userKTwo, userBTwo, 2));