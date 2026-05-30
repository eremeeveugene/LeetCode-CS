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

using LeetCode.Algorithms.KeepMultiplyingFoundValuesByTwo;

namespace LeetCode.Tests.Algorithms.KeepMultiplyingFoundValuesByTwo;

public abstract class KeepMultiplyingFoundValuesByTwoTestsBase<T> where T : IKeepMultiplyingFoundValuesByTwo, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 3, 6, 1, 12 }, 3, 24)]
    [DataRow(new[] { 2, 7, 9 }, 4, 4)]
    public void FindFinalValue_WithNumsArrayAndOriginalValue_ReturnsFinalMultipliedValue(int[] nums,
        int original, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindFinalValue(nums, original);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}