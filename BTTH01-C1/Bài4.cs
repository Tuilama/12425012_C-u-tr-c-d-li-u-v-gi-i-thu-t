//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BTTH01_C1
//{
//    internal class Bài4
//    {
//        static void Main()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            int[] arr = new int[1000];
//            Random rand = new Random();

//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = rand.Next(0, 1000);
//            }

//            Console.WriteLine("a. Mảng ban đầu:");
//            Console.WriteLine(string.Join(" ", arr));

//            Array.Sort(arr);

//            Console.WriteLine("\nb. Mảng sau khi sắp xếp tăng dần:");
//            Console.WriteLine(string.Join(" ", arr));
//        }
//    }
//}
