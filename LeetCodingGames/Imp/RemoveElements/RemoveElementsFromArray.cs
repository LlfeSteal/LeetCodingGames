using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodingGames.Imp.RemoveElements
{
    public class RemoveElementsFromArray
    {
        public int RemoveElement(int[] nums, int val)
        {
            int remainingItems = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                int currentElement = nums[i];

                if (currentElement != val)
                {
                    nums[remainingItems] = currentElement;
                    ++remainingItems;
                }
            }

            return remainingItems;
        }
    }
}
