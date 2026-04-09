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

using LeetCode.Algorithms.ZeroArrayTransformation3;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ZeroArrayTransformation3;

public abstract class ZeroArrayTransformation3TestsBase<T> where T : IZeroArrayTransformation3, new()
{
    [TestMethod]
    [DataRow("[2,0,2]", "[[0,2],[0,2],[1,1]]", 1)]
    [DataRow("[1,1,1,1]", "[[1,3],[0,2],[1,3],[1,2]]", 2)]
    [DataRow("[1,2,3,4]", "[[0,3]]", -1)]
    public void MaxRemoval_WithGivenNumsAndQueries_ReturnsMaximumRemovablePrefixLength(string numsJson,
        string queriesJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var queries = JsonHelper.Parse<int[][]>(queriesJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxRemoval(nums, queries);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}