using System;

namespace ISTC.ThirdStage.Advance.Algorithms.Sorting.Sorting
{
    public static class Quick
    {
        static void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        public static void QuickSort(int[] items)
        {
            Quicksort(items, 0, items.Length - 1);
        }

        private static void Quicksort(int[] items, int left, int right)
        {
            Random _pivotRng = new Random();

            if (left < right)
            {
                int pivotIndex = _pivotRng.Next(left, right);

                int newPivot = Partition(items, left, right, pivotIndex);
                Quicksort(items, left, newPivot - 1);
                Quicksort(items, newPivot + 1, right);
            }
        }

        private static int Partition(int[] items, int left, int right, int pivotIndex)
        {
            int pivotValue = items[pivotIndex];

            Swap(items, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (items[i].CompareTo(pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }

            Swap(items, storeIndex, right);
            return storeIndex;
        }
    }
}
