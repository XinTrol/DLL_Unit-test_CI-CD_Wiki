using System;
using Xunit;
using ArrayLibrary;

namespace ArrayLibraryTests
{
    public class ArrayHelperTests
    {
        [Fact]
        public void SortArray_ShouldSortCorrectly()
        {
            int[] input = { 5, 3, 8, 1 };
            int[] expected = { 1, 3, 5, 8 };

            int[] result = ArrayHelper.SortArray(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FilterArray_ShouldReturnOnlyEvenNumbers()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 2, 4 };

            int[] result = ArrayHelper.FilterArray(input, x => x % 2 == 0);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindElement_ShouldReturnCorrectIndex()
        {
            int[] input = { 10, 20, 30, 40 };
            int value = 30;
            int expectedIndex = 2;

            int result = ArrayHelper.FindElement(input, value);

            Assert.Equal(expectedIndex, result);
        }

        [Fact]
        public void FindElement_ShouldReturnMinusOne_WhenNotFound()
        {
            int[] input = { 1, 2, 3 };
            int value = 10;

            int result = ArrayHelper.FindElement(input, value);

            Assert.Equal(-1, result);
        }
    }
}