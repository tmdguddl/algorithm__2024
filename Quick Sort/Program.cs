using System;

class QuickSortExample
{
    static void QuickSort(int[] list, int left, int right)
    {
        int q;
        if (left < right)
        {
            q = Partition(list, left, right);
            QuickSort(list, left, q - 1);
            QuickSort(list, q + 1, right);
        }
    }

    static int Partition(int[] list, int left, int right)
    {
        int tmp;
        int low = left + 1;
        int high = right;
        int pivot = list[left]; 

        while (low < high)
        {
            
            while (low <= right && list[low] < pivot) low++;
            while (high >= left && list[high] > pivot) high--;

            if (low < high)
            {
                
                Swap(list, low, high);
            }
        }

        
        Swap(list, left, high);
        return high;
    }

    static void Swap(int[] list, int index1, int index2)
    {
        int tmp = list[index1];
        list[index1] = list[index2];
        list[index2] = tmp;
    }

    static void Main(string[] args)
    {
        int[] list = { 34, 7, 23, 32, 5, 62 };
        QuickSort(list, 0, list.Length - 1);

        Console.WriteLine("정렬된 배열:");
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
    }
}
