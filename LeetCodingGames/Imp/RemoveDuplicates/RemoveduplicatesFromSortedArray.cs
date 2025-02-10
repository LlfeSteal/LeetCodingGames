namespace LeetCodingGames.Imp.RemoveDuplicates
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
