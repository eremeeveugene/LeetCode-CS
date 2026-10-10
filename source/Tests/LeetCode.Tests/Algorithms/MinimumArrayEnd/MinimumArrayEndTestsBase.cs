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

using LeetCode.Algorithms.MinimumArrayEnd;

namespace LeetCode.Tests.Algorithms.MinimumArrayEnd;

public abstract class MinimumArrayEndTestsBase<T> where T : IMinimumArrayEnd, new()
{
    [TestMethod]
    [DataRow(3, 4, 6)]
    [DataRow(2, 7, 15)]
    [DataRow(1, 1, 1L)]
    [DataRow(1, 100000000, 100000000L)]
    [DataRow(2, 1, 3L)]
    [DataRow(2, 2, 3L)]
    [DataRow(3, 1, 5L)]
    [DataRow(4, 1, 7L)]
    [DataRow(5, 2, 10L)]
    [DataRow(10, 5, 39L)]
    [DataRow(3, 7, 23L)]
    [DataRow(8, 8, 15L)]
    [DataRow(100, 1, 199L)]
    [DataRow(7, 12, 30L)]
    [DataRow(16, 3, 63L)]
    [DataRow(2, 100000000, 100000001L)]
    [DataRow(1000, 6, 3999L)]
    [DataRow(50, 1024, 1073L)]
    [DataRow(3, 5, 13L)]
    [DataRow(1000000, 1, 1999999L)]
    public void MinEnd_WithArrayLengthAndTargetAndValue_ReturnsMinimumPossibleLastElement(int n, int x, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinEnd(n, x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}