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

using LeetCode.Algorithms.RotateArray;

namespace LeetCode.Tests.Algorithms.RotateArray;

public abstract class RotateArrayTestsBase<T> where T : IRotateArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
    [DataRow(new[] { -1, -100, 3, 99 }, 2, new[] { 3, 99, -1, -100 })]
    [DataRow(new[] { 1 }, 1, new[] { 1 })]
    [DataRow(new[] { 1 }, 100, new[] { 1 })]
    [DataRow(new[] { 1 }, 100_000, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, 1, new[] { 2, 1 })]
    [DataRow(new[] { 1, 2 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, 3, new[] { 2, 1 })]
    [DataRow(new[] { 1, 2, 3 }, 0, new[] { 1, 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 1, 2, 3, 4 }, 5, new[] { 4, 1, 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 2, new[] { 5, 6, 1, 2, 3, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 100, new[] { 3, 4, 5, 6, 1, 2 })]
    [DataRow(new[] { -2147483648, 2147483647, 0 }, 1, new[] { 0, -2147483648, 2147483647 })]
    [DataRow(new[] { 0, 0, 0, 1 }, 1, new[] { 1, 0, 0, 0 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 3, new[] { 3, 2, 1, 5, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 7, new[] { 4, 5, 6, 7, 8, 9, 10, 1, 2, 3 })]
    [DataRow(new[] { 10, 20, 30 }, 100000, new[] { 30, 10, 20 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 1, new[] { 7, 1, 2, 3, 4, 5, 6 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 6, new[] { 2, 3, 4, 5, 6, 7, 1 })]
    [DataRow(new[] { -1, -2, -3, -4 }, 2, new[] { -3, -4, -1, -2 })]
    [DataRow(new[] { 7, 7, 8, 8, 9 }, 99999, new[] { 7, 8, 8, 9, 7 })]
    public void Rotate_WithNumsArrayAndKSteps_ShiftsElementsRightByKSteps(int[] nums, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        solution.Rotate(nums, k);

        var actualResult = nums;

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}