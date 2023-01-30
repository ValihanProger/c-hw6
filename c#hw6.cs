// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] ConverterToBinary(int num)
// {
//     int[] result = new int [num];
//     int i = 0;
//     while (num > 0)
//     {
//         result[i] = num%2;
//         Console.WriteLine(result);
//         num = num/2;
//         i = i + 1;
//     }

//     foreach (var item in result.Reverse())
//     {
//         Console.Write(item);
//     }
//     return result;
// }


// Console.Write("Enter a number M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"   {num} -> {ConverterToBinary(num)}");

int count = 0;
int CntZeroes()
{
    Console.Write("Введите элементы(через пробел): ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во элементов > 0: {count}");
    return count;


}
CntZeroes();
