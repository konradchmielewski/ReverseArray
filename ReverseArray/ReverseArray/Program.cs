using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the size of an array: ");
            string arrSizeString = Console.ReadLine();
            int arrSize;
            int[] arr;

            while (!Int32.TryParse(arrSizeString, out arrSize) || arrSize <= 0)
            {
                Console.WriteLine("Please provide a correct positive value.");
                arrSizeString = Console.ReadLine();
            }
            arr = new int[arrSize];

            Console.WriteLine("Please provide the elements of an array. Use space (' ') after each element.");
            string arrElementsString = Console.ReadLine();
            string[] elements = arrElementsString.Split(null);

            for (int a = 0; a < elements.Length; a++)
            {
                if (Int32.TryParse(elements[a], out int oneNum))
                    arr[a] = oneNum;
            }

            ArrayReverse(arr);
            Console.WriteLine("The reversed array to the one you have provided is: " + string.Join(" ", arr));
            Console.ReadKey();
        }

        // Method which reverses an array of integers.
        static int[] ArrayReverse(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;

            while (i < j)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            return arr;
        }
    }
}