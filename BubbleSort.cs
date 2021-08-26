using System;

static class BubbleSort
{
    static BubbleSort()
    {

    }

    public static void Sort(int[] list)
    {
        Display(list);

        int current;

        // For each item in the array, perform swaps until all items are sorted.
        for (int i = 0; i < list.Length; i++)
        {
            // Loop through array again.
            // This loop will compare and sort each item as long as:
            //      The current item is greater than the next item.
            for (int j = 0; j < list.Length - 1; j++)
            {
                current = list[j];
                if (list[j] > list[j + 1])
                {
                    list[j] = list[j + 1]; // Perform the swap.
                    list[j + 1] = current;
                    Display(list);
                }
            }
        }

        Display(list);
    }

    public static void Display(int[] list)
    {
        Console.Write("[");

        for (int i = 0; i < list.Length; i++)
        {
            if (i < list.Length - 1) Console.Write(list[i] + ", ");
            else Console.Write(list[i]);
        }

        Console.Write("]\n");
    }
}
