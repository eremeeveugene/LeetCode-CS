// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.XORQueriesOfSubarray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.XORQueriesOfSubarray;

public abstract class XORQueriesOfSubarrayTestsBase<T> where T : IXORQueriesOfSubarray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 4, 8 }, "[[0,1],[1,2],[0,3],[3,3]]", new[] { 2, 7, 14, 8 })]
    [DataRow(new[] { 4, 8, 2, 10 }, "[[2,3],[1,3],[0,0],[0,3]]", new[] { 8, 0, 4, 4 })]
    [DataRow(new[] { 16 }, "[[0,0],[0,0],[0,0]]", new[] { 16, 16, 16 })]
    [DataRow(new[] { 15, 8, 8, 8, 15 }, "[[2,2],[3,3]]", new[] { 8, 8 })]
    public void XorQueries_WithArrayAndQueries_ReturnsCorrectResults(int[] arr, string queriesJsonArray,
        int[] expectedResult)
    {
        // Arrange
        var queries = JsonHelper<int>.DeserializeToJaggedArray(queriesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.XorQueries(arr, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}