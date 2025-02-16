// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumArrayEnd;

namespace LeetCode.Tests.Algorithms.MinimumArrayEnd;

public abstract class MinimumArrayEndTestsBase<T> where T : IMinimumArrayEnd, new()
{
    [TestMethod]
    [DataRow(3, 4, 6)]
    [DataRow(2, 7, 15)]
    public void MinEnd_GivenNAndX_ReturnsExpectedResult(int n, int x, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinEnd(n, x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}