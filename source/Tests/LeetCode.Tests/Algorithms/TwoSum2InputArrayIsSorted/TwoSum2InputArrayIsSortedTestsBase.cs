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

using LeetCode.Algorithms.TwoSum2InputArrayIsSorted;

namespace LeetCode.Tests.Algorithms.TwoSum2InputArrayIsSorted;

public abstract class TwoSum2InputArrayIsSortedTestsBase<T> where T : ITwoSum2InputArrayIsSorted, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 7, 11, 15 }, 9, new[] { 1, 2 })]
    [DataRow(new[] { 2, 3, 4 }, 6, new[] { 1, 3 })]
    [DataRow(new[] { -1, 0 }, -1, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, 3, new[] { 1, 2 })]
    [DataRow(new[] { 0, 0 }, 0, new[] { 1, 2 })]
    [DataRow(new[] { -3, -1, 0, 2, 4 }, 1, new[] { 2, 4 })]
    [DataRow(new[] { -10, -3, 0, 5, 9 }, 2, new[] { 2, 4 })]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 8, new[] { 1, 4 })]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 10, new[] { 1, 5 })]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 16, new[] { 4, 5 })]
    [DataRow(new[] { -5, -3, -1 }, -8, new[] { 1, 2 })]
    [DataRow(new[] { -5, -3, -1 }, -6, new[] { 1, 3 })]
    [DataRow(new[] { -5, -3, -1 }, -4, new[] { 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 9, new[] { 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 1, 2 })]
    [DataRow(new[] { 0, 1, 2, 3 }, 1, new[] { 1, 2 })]
    [DataRow(new[] { 100, 200, 300, 400 }, 500, new[] { 1, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 11, new[] { 5, 6 })]
    [DataRow(new[] { -5, -4, -3, -2, -1 }, -9, new[] { 1, 2 })]
    [DataRow(new[] { 1, 3, 4, 5, 7, 11 }, 9, new[] { 3, 4 })]
    public void TwoSum_WithSortedArrayAndTargetSum_ReturnsOneIndexedPairAddingToTarget(int[] numbers, int target, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TwoSum(numbers, target);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}