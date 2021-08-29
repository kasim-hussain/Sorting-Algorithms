using System;

static class MergeSort
{
    static MergeSort()
    {

    }

    public static void Sort(int[] list, int start, int end)
    {
        int midpoint = start + (end - start) / 2;

        // So long as the start remains less than total length of the array:
        //      Recursively keep splitting the array smaller,
        //      and form Left / Right side arrays.
        //      Merge these arrays & sort.
        if (start < end)
        {
            Sort(list, start, midpoint);
            Sort(list, midpoint + 1, end);

            Merge(list, start, midpoint, end);
        }
    }

    private static void Merge(int[] list, int start, int midpoint, int end)
    {
        // Get lengths for Temp arrays.
        int Lsize = midpoint - start + 1;
        int Rsize = end - midpoint;

        // Create Temp arrays using new lengths.
        int[] L = new int[Lsize];
        int[] R = new int[Rsize];

        int i, j;

        // Populate Temp arrays.
        for (i = 0; i < L.Length; i++) L[i] = list[start + i];
        for (j = 0; j < R.Length; j++) R[j] = list[midpoint + 1 + j];

        i = 0; j = 0; int k = start;

        // Rebuild process.
        //      Loop through arrays while their indexes are smaller than the list.
        while (i < L.Length && j < R.Length)
        {
            // Compare values from each list and add smallest to the final list.
            if (L[i] < R[j])
            {
                list[k] = L[i];
                i++;
            }
            else
            {
                list[k] = R[j];
                j++;
            }
            k++;
        }

        // If items still remain in either list, add them to the final list.
        while (i < L.Length)
        {
            list[k] = L[i];
            i++;
            k++;
        }

        while (j < R.Length)
        {
            list[k] = R[j];
            j++;
            k++;
        }
    }

    private static void Display(int[] list)
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
