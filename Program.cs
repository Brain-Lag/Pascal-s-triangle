using System;
using System.Linq;


while (true)
{
    Console.WriteLine("введите степень");
    int b = int.Parse(Console.ReadLine());

    int[] output = PasTri(b);
    for (int i= 0; i < output.Length; i++)
    {
        Console.Write(output[i] + " ");
    }
    Console.WriteLine();
}

//static int Pascal(int b)
//{
//    int[][] Triangle = new int[b][];
//    for (int i = 2; i < b; i++)
//    {
//        for (int j = 0; j <= i; j++)
//        {
//            if (i == j) Triangle[i][j] = 1;
//            else if (j == 0) Triangle[i][j] = 1;
//            else
//            {
//                Triangle[i][j] = Triangle[i - 1][j] + Triangle[i - 1][j - 1];
//            }
//        }
//    }
//    var str = string.Join(" ", Triangle);
//    return Triangle;
//}

int[] PasTri(int b)
{
    int[] result = new int[b];
    result[0] = 1;
    for (int i = 1; i < b; i++)
    {
        int left = 0;
        for (int j = 0; j <= i; j++)
        {
            int tmp = result[j];
            result[j] += left;
            left = tmp;
        }
    }
    return result;
}