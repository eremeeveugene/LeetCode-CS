// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.RemoveDuplicatesFromSortedArray;

namespace LeetCode.Tests.Algorithms.RemoveDuplicatesFromSortedArray;

public abstract class RemoveDuplicatesFromSortedArrayTestsBase<T> where T : IRemoveDuplicatesFromSortedArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new[] { 0, 1, 2, 3, 4 })]
    [DataRow(new[] { 0 }, 1, new[] { 0 })]
    [DataRow(new[] { -100 }, 1, new[] { -100 })]
    [DataRow(new[] { 100 }, 1, new[] { 100 })]
    [DataRow(new[] { 1, 1 }, 1, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { -100, 100 }, 2, new[] { -100, 100 })]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, 1, new[] { 2 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { -3, -3, -2, -2, -1, -1 }, 3, new[] { -3, -2, -1 })]
    [DataRow(new[] { 0, 0, 0, 1 }, 2, new[] { 0, 1 })]
    [DataRow(new[] { 0, 1, 1, 1 }, 2, new[] { 0, 1 })]
    [DataRow(new[] { -100, -100, 0, 0, 100, 100 }, 3, new[] { -100, 0, 100 })]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4 }, 4, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 5, 6, 6, 7, 7, 7, 8 }, 4, new[] { 5, 6, 7, 8 })]
    [DataRow(new[] { -5, -4, -3, -3, -3, -2 }, 4, new[] { -5, -4, -3, -2 })]
    [DataRow(new[] { 10, 10, 20, 30, 30, 30, 30, 40 }, 4, new[] { 10, 20, 30, 40 })]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 }, 4, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { -1, 0, 0, 1 }, 3, new[] { -1, 0, 1 })]
    [DataRow(new[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 10 }, 2, new[] { 9, 10 })]
    public void RemoveDuplicates_GivenSortedArray_ReturnsCountOfUniqueElements(int[] nums, int expectedResult, int[] expectedNums)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveDuplicates(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);

        var actualNums = new int[actualResult];

        Array.Copy(nums, actualNums, actualResult);

        Assert.AreSequenceEqual(expectedNums, actualNums, SequenceOrder.InAnyOrder);
    }

    [TestMethod]
    public void RemoveDuplicates_WithMaxLengthSortedArray_ReturnsCountOfUniqueElements()
    {
        // Arrange
        var solution = new T();

        var nums = new int[30000];

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = (i / 150) - 100;
        }

        // Act
        var actualResult = solution.RemoveDuplicates(nums);

        // Assert
        Assert.AreEqual(200, actualResult);

        for (var i = 0; i < actualResult; i++)
        {
            Assert.AreEqual(i - 100, nums[i]);
        }
    }
}