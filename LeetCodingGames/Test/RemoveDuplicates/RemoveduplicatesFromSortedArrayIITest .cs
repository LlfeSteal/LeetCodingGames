using FluentAssertions;
using LeetCodingGames.Imp.RemoveDuplicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCodingGames.Test.RemoveDuplicates
{
    [TestClass]
    public class RemoveduplicatesFromSortedArrayTestII
    {
        [TestMethod]
        public void RemoveDuplicatesShouldRemoveDuplicated_Case1()
        {
            // Arrange
            int[] nums = new[] { 1, 1, 1, 2, 2, 3 };
            var s = new RemoveduplicatesFromSortedArrayII();

            // Act
            int result = s.RemoveDuplicates(nums);

            // Assert
            result.Should().Be(5);
            int[] expectedNums = new[] { 1, 1, 2, 2, 3 };
            nums.Take(5).Should().BeEquivalentTo(expectedNums);
        }

        [TestMethod]
        public void RemoveDuplicatesShouldRemoveDuplicated_Case2()
        {
            // Arrange
            int[] nums = new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            var s = new RemoveduplicatesFromSortedArrayII();

            // Act
            int result = s.RemoveDuplicates(nums);

            // Assert
            result.Should().Be(7);
            int[] expectedNums = new[] { 0, 0, 1, 1, 2, 3, 3 };
            nums.Take(7).Should().BeEquivalentTo(expectedNums);
        }
    }
}
