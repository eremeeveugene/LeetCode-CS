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

using LeetCode.Algorithms.DeleteColumnsToMakeSorted2;

namespace LeetCode.Tests.Algorithms.DeleteColumnsToMakeSorted2;

public abstract class DeleteColumnsToMakeSorted2TestsBase<T> where T : IDeleteColumnsToMakeSorted2, new()
{
    [TestMethod]
    [DataRow(new[] { "xc", "yb", "za" }, 0)]
    [DataRow(new[] { "ca", "bb", "ac" }, 1)]
    [DataRow(new[] { "xga", "xfb", "yfa" }, 1)]
    [DataRow(new[] { "zyx", "wvu", "tsr" }, 3)]
    public void MinDeletionSize_WithStringsOfEqualLength_ReturnsMinimumDeletionsForLexicographicOrder(string[] strs, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinDeletionSize(strs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}