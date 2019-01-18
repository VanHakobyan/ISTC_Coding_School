using System;

namespace ISTC.ThirdStage.Advance.Algorithms.Sorting.Sorting
{
    public static class Insertion
    {
        public static void InsertionSort(int[] items)
        {
            int sortedRangeEndIndex = 1;

            while (sortedRangeEndIndex < items.Length)
            {
                if (items[sortedRangeEndIndex].CompareTo(items[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    Insert(items, insertIndex, sortedRangeEndIndex);
                }

                sortedRangeEndIndex++;
            }
        }

        private static int FindInsertionIndex(int[] items, int valueToInsert)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].CompareTo(valueToInsert) > 0)
                {
                    return i;
                }
            }

            throw new InvalidOperationException("Index out");
        }

        private static void Insert(int[] itemArray, int indexInsertingAt, int indexInsertingFrom)
        {
            // itemArray =       0 1 2 4 5 6 3 7     
            // insertingAt =     3     
            // insertingFrom =   6     

           

            int temp = itemArray[indexInsertingAt];

            // Step 2.  
            itemArray[indexInsertingAt] = itemArray[indexInsertingFrom];

            // Step 3.     
            for (int current = indexInsertingFrom; current > indexInsertingAt; current--)
            {
                itemArray[current] = itemArray[current - 1];
            }

            // Step 4.     
            itemArray[indexInsertingAt + 1] = temp;
        }

       
    }
}
