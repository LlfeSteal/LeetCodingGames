using FluentAssertions;
using LeetCodingGames.Imp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodingGames.Test
{
    [TestClass]
    public class RemoveduplicatesFromSortedArrayTest
    {
        [TestMethod]
        public void RemoveElementShouldRemoveDuplicated_Case1()
        {
            // Arrange
            int[] nums = new[] { 1, 1, 2 };
            var s = new RemoveduplicatesFromSortedArray();

            // Act
            int result = s.RemoveDuplicates(nums);

            // Assert
            result.Should().Be(2);
            int[] expectedNums = new[] { 1, 2 };
            nums.Take(2).Should().BeEquivalentTo(expectedNums);
        }

        [TestMethod]
        public void RemoveElementShouldRemoveDuplicated_Case2()
        {
            // Arrange
            int[] nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var s = new RemoveduplicatesFromSortedArray();

            // Act
            int result = s.RemoveDuplicates(nums);

            // Assert
            result.Should().Be(5);
            int[] expectedNums = new[] { 0, 1, 2, 3, 4 };
            nums.Take(5).Should().BeEquivalentTo(expectedNums);
        }
    }
}
