// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.TwoSum;

namespace LeetCode.Tests.Algorithms.TwoSum;

public abstract class TwoSumTestsBase<T> where T: ITwoSum, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [DataRow(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [DataRow(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [DataRow(new[] { 2, 5, 5, 11 }, 10, new[] { 1, 2 })]
    public void TwoSum_WithIntArrayAndTarget_ReturnsIndicesOfNumbersAddingToTarget(int[] nums, int target,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TwoSum(nums, target);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}