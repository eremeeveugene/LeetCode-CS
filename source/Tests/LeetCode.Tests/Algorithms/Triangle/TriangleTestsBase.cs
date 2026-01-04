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

using LeetCode.Algorithms.Triangle;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.Triangle;

public abstract class TriangleTestsBase<T> where T : ITriangle, new()
{
    [TestMethod]
    [DataRow("[[2],[3,4],[6,5,7],[4,1,8,3]]", 11)]
    [DataRow("[[-10]]", -10)]
    public void MinimumTotal_WithTriangleInput_ReturnsMinimumPathSumFromTopToBottom(string triangleJson,
        int expectedResult)
    {
        // Arrange
        var triangle = JsonHelper<IList<IList<int>>>.Parse(triangleJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumTotal(triangle);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}