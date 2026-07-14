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

using LeetCode.Algorithms.AddToArrayFormOfInteger;

namespace LeetCode.Tests.Algorithms.AddToArrayFormOfInteger;

public abstract class AddToArrayFormOfIntegerTestsBase<T> where T : IAddToArrayFormOfInteger, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 0, 0 }, 34, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 2, 7, 4 }, 181, new[] { 4, 5, 5 })]
    [DataRow(new[] { 2, 1, 5 }, 806, new[] { 1, 0, 2, 1 })]
    [DataRow(new[] { 1 }, 999, new[] { 1, 0, 0, 0 })]
    [DataRow(new[] { 9, 9, 9 }, 1, new[] { 1, 0, 0, 0 })]
    [DataRow(new[] { 0 }, 0, new[] { 0 })]
    [DataRow(new[] { 0 }, 1, new[] { 1 })]
    [DataRow(new[] { 5 }, 5, new[] { 1, 0 })]
    [DataRow(new[] { 1, 0 }, 90, new[] { 1, 0, 0 })]
    [DataRow(new[] { 9 }, 9, new[] { 1, 8 })]
    [DataRow(new[] { 1, 2, 3 }, 0, new[] { 1, 2, 3 })]
    [DataRow(new[] { 0 }, 123, new[] { 1, 2, 3 })]
    [DataRow(new[] { 1 }, 10000, new[] { 1, 0, 0, 0, 1 })]
    [DataRow(new[] { 9, 9, 9, 9 }, 9999, new[] { 1, 9, 9, 9, 8 })]
    [DataRow(new[] { 1, 0, 0 }, 1, new[] { 1, 0, 1 })]
    [DataRow(new[] { 2, 5 }, 25, new[] { 5, 0 })]
    [DataRow(new[] { 1, 2 }, 8, new[] { 2, 0 })]
    [DataRow(new[] { 7, 7, 7 }, 333, new[] { 1, 1, 1, 0 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 100, new[] { 1, 2, 4, 4, 5 })]
    [DataRow(new[] { 6 }, 6, new[] { 1, 2 })]
    public void AddToArrayForm_WithArrayAndInteger_ReturnsSumAsArray(int[] num, int k, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AddToArrayForm(num, k).ToArray();

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}