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

using LeetCode.Algorithms.MaximizeExpressionOfThreeElements;

namespace LeetCode.Tests.Algorithms.MaximizeExpressionOfThreeElements;

public abstract class MaximizeExpressionOfThreeElementsTestsBase<T> where T : IMaximizeExpressionOfThreeElements, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4, 2, 5 }, 8)]
    [DataRow(new[] { -2, 0, 5, -2, 4 }, 11)]
    public void MaximizeExpressionOfThree_WithGivenNums_ReturnsMaximumExpressionValue(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximizeExpressionOfThree(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}