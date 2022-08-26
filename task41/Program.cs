// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите числа через пробел");
int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + "; ");
}
int res = 0;
for (int k = 0; k < arr.Length; k++)
{
    if (arr[k] > 0)
    {
        res++;
    }
}
Console.WriteLine(" ");
Console.WriteLine($"Количество элементов > 0 = {res}");