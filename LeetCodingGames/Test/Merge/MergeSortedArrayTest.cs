using FluentAssertions;
using LeetCodingGames.Imp.Merge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCodingGames.Test.Merge
{
    [TestClass]
    public class MergeSortedArrayTest
    {
        [TestMethod]
        public void MergeShouldMergeArray_Case1()
        {
            // Arrange
            int[] nums1 = new[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new[] { 2, 5, 6 };
            var s = new MergeSortedArray();

            // Act
            s.Merge(nums1, 3, nums2, 3);

            // Assert
            int[] expectedNums1 = new[] { 1, 2, 2, 3, 5, 6 };
            nums1.Should().BeEquivalentTo(expectedNums1);
        }

        [TestMethod]
        public void MergeShouldMergeArray_Case2()
        {
            // Arrange
            int[] nums1 = new[] { 1 };
            int[] nums2 = new int[0];
            var s = new MergeSortedArray();

            // Act
            s.Merge(nums1, 1, nums2, 0);

            // Assert
            int[] expectedNums1 = new[] { 1 };
            nums1.Should().BeEquivalentTo(expectedNums1);
        }

        [TestMethod]
        public void MergeShouldMergeArray_Case3()
        {
            // Arrange
            int[] nums1 = new int[] { 0 };
            int[] nums2 = new[] { 1 };
            var s = new MergeSortedArray();

            // Act
            s.Merge(nums1, 0, nums2, 1);

            // Assert
            int[] expectedNums1 = new[] { 1 };
            nums1.Should().BeEquivalentTo(expectedNums1);
        }
    }
}
