using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodingGames.Imp
{
    public class RemoveduplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int remainingItems = 0;
            int previousValue = int.MinValue;

            for (int i = 0; i < nums.Length; ++i)
            {
                int currentElement = nums[i];

                if (currentElement != previousValue)
                {
                    nums[remainingItems] = currentElement;
                    ++remainingItems;
                    previousValue = currentElement;
                }
            }

            return remainingItems;
        }
    }
}
