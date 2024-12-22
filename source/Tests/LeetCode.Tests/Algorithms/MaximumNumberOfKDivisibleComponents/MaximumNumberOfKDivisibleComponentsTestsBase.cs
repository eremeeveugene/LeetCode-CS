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

using LeetCode.Algorithms.MaximumNumberOfKDivisibleComponents;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfKDivisibleComponents;

public abstract class MaximumNumberOfKDivisibleComponentsTestsBase<T>
    where T : IMaximumNumberOfKDivisibleComponents, new()
{
    [TestMethod]
    [DataRow(5, "[[0,2],[1,2],[1,3],[2,4]]", "[1,8,1,4,4]", 6, 2)]
    [DataRow(7, "[[0,1],[0,2],[1,3],[1,4],[2,5],[2,6]]", "[3,0,6,1,5,2,1]", 3, 3)]
    public void MaxKDivisibleComponents_WithGraphEdgesAndValues_ReturnsComponentCount(int n, string edgesJsonArray,
        string valuesJsonArray, int k, int expectedResult)
    {
        // Arrange
        var edges = JsonHelper<int>.DeserializeToJaggedArray(edgesJsonArray);
        var values = JsonHelper<int>.DeserializeToArray(valuesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaxKDivisibleComponents(n, edges, values, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}