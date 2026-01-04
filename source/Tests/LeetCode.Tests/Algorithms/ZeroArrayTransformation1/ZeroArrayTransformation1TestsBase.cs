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

using LeetCode.Algorithms.ZeroArrayTransformation1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ZeroArrayTransformation1;

public abstract class ZeroArrayTransformation1TestsBase<T> where T : IZeroArrayTransformation1, new()
{
    [TestMethod]
    [DataRow("[1,0,1]", "[[0,2]]", true)]
    [DataRow("[4,3,2,1]", "[[1,3],[0,2]]", false)]
    public void IsZeroArray_WithNumsAndQueries_ReturnsWhetherArrayCanBeTransformedToAllZeros(string numsJson,
        string queriesJson, bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var queries = JsonHelper<int[][]>.Parse(queriesJson);

        var solution = new T();

        // Act
        var actualResult = solution.IsZeroArray(nums, queries);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}