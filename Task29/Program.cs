//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вводим массив через консоль


int[] arr = new int[8];

for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Введите число");
    int n = Convert.ToInt32(Console.ReadLine());
    arr[i] = n;
}
Console.WriteLine(string.Join(", ", arr));

// Стихийный метод)

// Console.WriteLine("Введите число А");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число C");
// int C = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число D");
// int D = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число E");
// int E = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число F");
// int F = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число G");
// int G = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число H");
// int H = Convert.ToInt32(Console.ReadLine());
// arr[0] = A;
// arr[1] = B;
// arr[2] = C;
// arr[3] = D;
// arr[4] = E;
// arr[5] = F;
// arr[6] = G;
// arr[7] = H;
// Console.WriteLine(string.Join(", ", arr));
