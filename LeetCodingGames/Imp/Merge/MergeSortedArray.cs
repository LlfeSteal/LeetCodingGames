namespace LeetCodingGames.Imp.Merge
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int totalSize = nums1.Length;
            int currentNums1Index = 0;
            int currentNums2Index = 0;
            int[] mergedArray = new int[totalSize];

            for (int i = 0; i < totalSize; ++i)
            {
                if (currentNums1Index == m)
                {
                    for (int j = currentNums2Index; j < nums2.Length; ++j)
                    {
                        mergedArray[i++] = nums2[j];
                    }
                    break;
                }
                if (currentNums2Index == nums2.Length)
                {
                    for (int j = currentNums1Index; j < m; ++j)
                    {
                        mergedArray[i++] = nums1[j];
                    }
                    break;
                }

                int currentNums1 = nums1[currentNums1Index];
                int currentNums2 = nums2[currentNums2Index];


                if (currentNums1 <= currentNums2)
                {
                    mergedArray[i] = currentNums1;
                    ++currentNums1Index;
                }
                else
                {
                    mergedArray[i] = currentNums2;
                    ++currentNums2Index;
                }
            }

            for (int i = 0; i < m + n; i++)
            {
                nums1[i] = mergedArray[i];
            }
        }
    }
}
