using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 3, 2, 5, 1, 4 };
            int count = 0;
            int temp;
            bool swap;

            //bubble sort
            do
            {
                swap = false;
                for (int i = 0; i < Numbers.Length - 1; i++)
                {
                    if (Numbers[i] > Numbers[i + 1])
                    {
                        temp = Numbers[i];
                        Numbers[i] = Numbers[i + 1];
                        Numbers[i + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap == true);

            //print
            Console.Write("Sorted: {");
            foreach (var Number in Numbers)
            {
                Console.Write(Number);
                if (Numbers.Length - 1 > count)
                    Console.Write(", ");
                count++;
            }
            Console.WriteLine("}");
        }
    }
}
