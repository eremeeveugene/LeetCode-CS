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

using LeetCode.Algorithms.DeleteColumnsToMakeSorted;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DeleteColumnsToMakeSorted;

public abstract class DeleteColumnsToMakeSortedTestsBase<T> where T : IDeleteColumnsToMakeSorted, new()
{
    [TestMethod]
    [DataRow("[\"a\",\"b\"]", 0)]
    [DataRow("[\"cba\",\"daf\",\"ghi\"]", 1)]
    [DataRow("[\"zyx\",\"wvu\",\"tsr\"]", 3)]
    public void MinDeletionSize_WithStringArrayInput_ReturnsNumberOfColumnsToDelete(string strsJson, int expectedResult)
    {
        // Arrange
        var strs = JsonHelper<string[]>.Parse(strsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinDeletionSize(strs);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}