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

using LeetCode.Algorithms.FindTheMaximumSumOfNodeValues;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTheMaximumSumOfNodeValues;

public abstract class FindTheMaximumSumOfNodeValuesTestsBase<T> where T : IFindTheMaximumSumOfNodeValues, new()
{
    [TestMethod]
    [DataRow("[1, 2, 1]", 3, "[[0,1],[0,2]]", 6)]
    [DataRow("[2, 3]", 7, "[[0,1]]", 9)]
    [DataRow("[7, 7, 7, 7, 7, 7]", 3, "[[0,1],[0,2],[0,3],[0,4],[0,5]]", 42)]
    [DataRow("[24, 78, 1, 97, 44]", 6, "[[0,2],[1,2],[4,2],[3,4]]", 260)]
    public void MaximumValueSum_WithVariousInputs_ReturnsExpectedResult(string numsJsonArray, int k,
        string edgesJsonArray, long expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var edges = JsonHelper<int>.DeserializeToJaggedArray(edgesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaximumValueSum(nums, k, edges);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}