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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DeleteColumnsToMakeSorted2;

public abstract class DeleteColumnsToMakeSorted2TestsBase<T> where T : IDeleteColumnsToMakeSorted2, new()
{
    [TestMethod]
    [DataRow("[\"xc\",\"yb\",\"za\"]", 0)]
    [DataRow("[\"ca\",\"bb\",\"ac\"]", 1)]
    [DataRow("[\"xga\",\"xfb\",\"yfa\"]", 1)]
    [DataRow("[\"zyx\",\"wvu\",\"tsr\"]", 3)]
    public void MinDeletionSize_WithStringsOfEqualLength_ReturnsMinimumDeletionsForLexicographicOrder(string strsJson,
        int expectedResult)
    {
        // Arrange
        var strs = JsonHelper.Parse<string[]>(strsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinDeletionSize(strs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}