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

using LeetCode.Algorithms.FindTheMaximumLengthOfValidSubsequence2;

namespace LeetCode.Tests.Algorithms.FindTheMaximumLengthOfValidSubsequence2;

public abstract class FindTheMaximumLengthOfValidSubsequence2TestsBase<T> where T : IFindTheMaximumLengthOfValidSubsequence2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, 5)]
    [DataRow(new[] { 1, 4, 2, 3, 1, 4 }, 3, 4)]
    public void MaximumLength_WithIntegerArrayAndLimitK_ReturnsMaximumLengthUnderConstraint(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumLength(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}