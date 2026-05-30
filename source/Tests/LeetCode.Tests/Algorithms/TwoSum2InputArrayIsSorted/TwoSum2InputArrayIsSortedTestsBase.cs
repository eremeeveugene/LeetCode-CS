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
    public void TwoSum_WithSortedArrayAndTargetSum_ReturnsOneIndexedPairAddingToTarget(int[] numbers, int target,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TwoSum(numbers, target);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}