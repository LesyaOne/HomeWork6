/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int PositiveCount (int [] array)
{
    int countPositive = 0;
    for (int i = 0; i<array.Length; i++)
        if (array [i] > 0) countPositive ++;
    return countPositive;
}
int [] TakeNumbers (int size)
{
    int [] array = new int [size];
    for (int i = 0; i<size; i++)
    {
        Console.Write("Enter number: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.Write("How many numbers are you going to enter? ");
int userSize = Convert.ToInt32(Console.ReadLine());
int [] userArray = TakeNumbers(userSize);
Console.Write($"You entered {PositiveCount(userArray)} positive numbers");

