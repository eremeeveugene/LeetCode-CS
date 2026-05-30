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

using LeetCode.Algorithms.MinimizeMaximumPairSumInArray;

namespace LeetCode.Tests.Algorithms.MinimizeMaximumPairSumInArray;

public abstract class MinimizeMaximumPairSumInArrayTestsBase<T>
    where T : IMinimizeMaximumPairSumInArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 5, 2, 3 }, 7)]
    [DataRow(new[] { 3, 5, 4, 2, 4, 6 }, 8)]
    public void MinPairSum_WithNumsArray_ReturnsMinimizedMaximumPairSum(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinPairSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}