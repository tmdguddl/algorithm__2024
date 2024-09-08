using System;

class MergeSortExample
{
    static int[] sorted;

    static void Merge(int[] list, int left, int mid, int right)
    {
        int i = left, j = mid + 1, k = left;
        sorted = new int[list.Length];

        while (i <= mid && j <= right)
        {
            if (list[i] <= list[j])
                sorted[k++] = list[i++];
            else
                sorted[k++] = list[j++];
        }

        if (i > mid)
        {
            while (j <= right)
                sorted[k++] = list[j++];
        }

        else
        {
            while (i <= mid)
                sorted[k++] = list[i++];
        }


        for (int l = left; l <= right; l++)
        {
            list[l] = sorted[l];
        }
    }

    static void MergeSort(int[] list, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(list, left, mid);
            MergeSort(list, mid + 1, right);
            Merge(list, left, mid, right);
        }
    }

    static void Main(string[] args)
    {
        int[] list = { 38, 27, 43, 3, 9, 82, 10 };
        MergeSort(list, 0, list.Length - 1);

        Console.WriteLine("정렬된 배열:");
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
    }
}
