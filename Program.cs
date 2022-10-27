//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//class Program
//{
//    public static int Main()
//    {
//        Console.Write("Введите число A: "); //число, которое нужно возвести в степень
//        int num = int.Parse(Console.ReadLine());

//       Console.Write("Введите степень B: "); //степень числа
//        int n = int.Parse(Console.ReadLine());

//        int number = 1; //число, возведенное в степень
//        for (int i = 0; i < n; i++)
//        {
//            number *= num;
//        }
//        Console.WriteLine("{0} ^ {1} = {2}", num, n, number);
//        Console.ReadKey();
//        return 0;
//    }
//}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


//int GetSum(int num)
//{
//    int sum = 0;

//    for(int current = 1; current <= num; current++)
//            sum += current; //sum = sum + current; 

//    return sum;
//}

//Console.Write("Введите число: ");
//int a = Convert.ToInt32(Console.ReadLine());

//int s = GetSum(a);
//Console.WriteLine($"Сумма чисел от 1 до {a} является {s}");


//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

//int[] CreateRandomArray(int size, int minValue, int maxValue)
//{
//    int[] array = new int[size];

//    for(int i = 0; i < size; i++)
//        array[i] = new Random(). Next(minValue, maxValue + 1);

//    return array;
//}

//void ShowArray(int[] array)
//{
//     for(int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");

//     Console.WriteLine();
//}

//Console.Write("size: ");
//int size = Convert.ToInt32(Console.ReadLine());
//Console.Write("min: ");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.Write("max: ");
//int max = Convert.ToInt32(Console.ReadLine());

//int[] myArray = CreateRandomArray(size, min, max);
//ShowArray(myArray);
