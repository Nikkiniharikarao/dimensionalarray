using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2darray
{
    class ArrayExample
    {
        //public static void Main()
        //{
        //    int[,] arr = new int[3,3];//declaration of 2D array  
        //    arr[0 , 1] = 10;//initialization  
        //    arr[1 , 2] = 20;
        //    arr[2 , 0] = 30;

        //    //traversal  
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write(arr[i, j] + " ");
        //        }
        //        Console.WriteLine();//new line at each row 
        //        }
        //    Console.ReadLine();
        //}

        //    int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//declaration and initialization  

        //    //traversal  
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write(arr[i ,j]+" ");
        //              }
        //        Console.WriteLine();//new line at each row  
        //        //Console.ReadLine();

        //    }
        //    Console.ReadLine();
        //}
      public static   void printarray(int[] array)
        {
            Console.WriteLine("printing array elements:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 3)
                {
                    break;
                }
                Console.WriteLine(array[i]);
                
               
            }
            Console.ReadLine();
        }

        static void Main()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7, 7, 8, };

            ArrayExample a = new ArrayExample();
            printarray(array1);
            printarray(array2);
        }
    }



}




