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

using LeetCode.Algorithms.MaxChunksToMakeSorted;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaxChunksToMakeSorted;

public abstract class MaxChunksToMakeSortedTestsBase<T> where T : IMaxChunksToMakeSorted, new()
{
    [TestMethod]
    [DataRow("[4,3,2,1,0]", 1)]
    [DataRow("[1,0,2,3,4]", 4)]
    public void MaxChunksToSorted_WithUnsortedArray_ReturnsMaximumNumberOfChunks(string arrJson,
        int expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int[]>.Parse(arrJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxChunksToSorted(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}