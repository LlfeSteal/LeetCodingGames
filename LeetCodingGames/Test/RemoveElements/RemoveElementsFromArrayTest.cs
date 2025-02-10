using FluentAssertions;
using LeetCodingGames.Imp.RemoveElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCodingGames.Test.RemoveElements
{
    [TestClass]
    public class RemoveElementsFromArrayTest
    {
        [TestMethod]
        public void RemoveElementShouldRemoveDuplicated_Case1()
        {
            // Arrange
            int[] nums = new[] { 3, 2, 2, 3 };
            var s = new RemoveElementsFromArray();

            // Act
            int result = s.RemoveElement(nums, 3);

            // Assert
            result.Should().Be(2);
            int[] expectedNums = new[] { 2, 2 };
            nums.Take(2).Should().BeEquivalentTo(expectedNums);
        }

        [TestMethod]
        public void RemoveElementShouldRemoveDuplicated_Case2()
        {
            // Arrange
            int[] nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var s = new RemoveElementsFromArray();

            // Act
            int result = s.RemoveElement(nums, 2);

            // Assert
            result.Should().Be(5);
            int[] expectedNums = new[] { 0, 1, 3, 0, 4 };
            nums.Take(5).Should().BeEquivalentTo(expectedNums);
        }
    }
}
