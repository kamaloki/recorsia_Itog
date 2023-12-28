//Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// void PrintNumbers(int start, int end)
// {
//     if(start > end)
//     {
//         return;
//     }

//     Console.Write(start + " ");
//     PrintNumbers(start + 1, end); 
// }

// PrintNumbers(number1, number2);











//Задача 2: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.WriteLine("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int FunctionAkkerman(int m2, int n2)
// {
//     if(m2 == 0)
//     {
//         return n2 + 1;
//     }
        
//     else if(m2 > 0 && n2 == 0)
//     {
//         return FunctionAkkerman(m2 - 1, 1);
//     }
        
//     else 
//     {
//         return FunctionAkkerman(m2 -1, FunctionAkkerman(m2, n2 -1));
//     }
// }

// Console.WriteLine(FunctionAkkerman(m, n));









//Задача 3: Задайте произвольный массив. Выведете его элементы, 
//начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = new int[6];

void PrintArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);  
        Console.Write(array[i] + " ");
    }
}

int index = array.Length - 1;

void PrintNewArray(int[] array, int index)
{
    if(index < 0)
    {
        return;
    }

    Console.Write(array[index] + " ");
    PrintNewArray(array, index - 1);
}

PrintArray();
Console.WriteLine();
PrintNewArray(array, index);
