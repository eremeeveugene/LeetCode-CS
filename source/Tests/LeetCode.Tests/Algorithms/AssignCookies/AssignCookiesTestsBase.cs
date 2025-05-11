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

using LeetCode.Algorithms.AssignCookies;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.AssignCookies;

public abstract class AssignCookiesTestsBase<T> where T : IAssignCookies, new()
{
    [TestMethod]
    [DataRow("[1,2,3]", "[1]", 1)]
    [DataRow("[1,2]", "[1,2,3]", 2)]
    public void FindContentChildren_WithGivenGreedyAndSizeArrays_ReturnsMaxSatisfiedChildren(string gJson,
        string sJson, int expectedResult)
    {
        // Arrange
        var g = JsonHelper<int[]>.Parse(gJson);
        var s = JsonHelper<int[]>.Parse(sJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindContentChildren(g, s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}