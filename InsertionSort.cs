using System;

static class InsertionSort
{
    static InsertionSort()
    {

    }

    public static void Sort(int[] list)
    {
        Display(list);

        int current;

        // Loop through array starting from the 2nd position.
        for (int i = 1; i < list.Length; i++)
        {
            current = list[i];

            // Loop through array again starting from the beginning.
            // This loop will compare and sort each item as long as:
            //      The index is greater or equal to 0.
            //      The previous item is greater than the current item.
            int j = i - 1;
            while (j >= 0 && list[j] > current)
            {
                list[j + 1] = list[j]; // Peform the swap.
                j = j - 1;             // Move to previous item to perform another comparison.
            }
            list[j + 1] = current;     // Place item in its correct position.
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
