using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1 Array with different changes.
            // Console.Write("Enter size of array: ");
            // int size = int.Parse(Console.ReadLine());
            // int[] arr = new int[size];
            // for (int i = 0; i < size; i++)
            // {
            //     arr[i] = int.Parse(Console.ReadLine());
            // }
            // int max = arr[0];
            // int min = arr[0];
            // var count1 = 0;
            // var count2 = 0;
            // Upper part is needed.
            // First part of question
            // for (int a = 1; a < size; a++)
            // {
            //     if(max < arr[a]){
            //         max = arr[a];
            //         count1 = a;
            //     }
            // }
            // Console.WriteLine($"Maximum value in array is {max}, with index {count1}");
            // Second part of question            
            // for (int b = 1; b < size; b++)
            // {
            //     if(min > arr[b]){
            //         min = arr[b];
            //         count2 = b;
            //     }
            // }
            // Console.WriteLine($"Minimum value in array is {min}, with index {count2}");
            // Third part, sum of values of array.
            // var sum = 0;
            // for (int c = 0; c < size; c++)
            // {
            //     sum += arr[c];
            // }
            // Console.WriteLine($"Sum of all values of array is {sum}");
            // var sum1 = 0;
            // var sra = 0.0;
            // for (int p = 0; p < length; p++)
            // {
            //     sum1 += arr[p];
            // }
            // sra = sum1/size;
            // Console.WriteLine($"Average of all elements is {sra}");
            // Odd numbers
            // for (int j = 0; j < size; j++)
            // {
            //     if(arr[j] % 2 == 1)
            //     {
            //         Console.Write(arr[j] + " ");
            //     }
            // }
            // Question 2
            // Console.Write("Enter size of array: ");
            // int size1 = int.Parse(Console.ReadLine());
            // int[] arr1 = new int[size1];
            // int[] arr2 = new int[size1];
            // for (int l = 0; l < size1; l++)
            // {
            //     arr1[l] = int.Parse(Console.ReadLine());
            // }
            // for (int m = 0; m < arr1.Length; m++)
            // {
            //     arr2[m] += arr1[size1-1];
            //     size1--;
            // }
            // Console.WriteLine("This is inverted array!");
            // for (int y = 0; y < arr2.Length; y++)
            // {
            //     Console.Write(arr2[y] + " ");
            // }
            // Question 3
            Console.Write("Enter size of array: ");
            int size3 = int.Parse(Console.ReadLine());
            Console.Write("Enter variable count: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Enter variable index: ");
            int index = int.Parse(Console.ReadLine());
            int[] arr3 = new int[size3];
            Console.WriteLine("Enter array values ");
            for (int g = 0; g < size3; g++)
            {
                arr3[g] = int.Parse(Console.ReadLine());
            }
            int[] arr4 = new int[count];
            var v = 0;
            for (int u = index; u < size3; u++)
            {
                arr4[v] = arr3[u];
                v += 1;
            }
            for (int f = index+1; f < count; f++)
            {
                arr4[f] = 1;
            }
            for (int x = 0; x < arr4.Length; x++)
            {
                Console.Write(arr4[x] + " ");
            }
        }
    }
}
