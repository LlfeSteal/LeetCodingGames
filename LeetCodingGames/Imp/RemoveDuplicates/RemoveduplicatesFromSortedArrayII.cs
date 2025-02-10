using System.Collections.Generic;

namespace LeetCodingGames.Imp.RemoveDuplicates
{
    public class RemoveduplicatesFromSortedArrayII
    {
        // TODO: Improve the execution time : 122ms
        public int RemoveDuplicates(int[] nums)
        {
            int remainingItems = 0;
            var sequenceCount = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                int currentElement = nums[i];
                bool alreadySeen = sequenceCount.TryGetValue(currentElement, out int countNumber);

                if (!alreadySeen || countNumber < 2)
                {
                    nums[remainingItems] = currentElement;
                    ++remainingItems;

                    if (alreadySeen)
                    {
                        sequenceCount[currentElement] += 1;
                    }
                    else
                    {
                        sequenceCount.Add(currentElement, 1);
                    }

                }
            }

            return remainingItems;
        }
    }
}
