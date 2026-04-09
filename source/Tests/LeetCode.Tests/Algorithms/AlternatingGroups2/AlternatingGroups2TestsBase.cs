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

using LeetCode.Algorithms.AlternatingGroups2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.AlternatingGroups2;

public abstract class AlternatingGroups2TestsBase<T> where T : IAlternatingGroups2, new()
{
    [TestMethod]
    [DataRow("[0,1,0,1,0]", 3, 3)]
    [DataRow("[0,1,0,0,1,0,1]", 6, 2)]
    [DataRow("[1,1,0,1]", 4, 0)]
    public void NumberOfAlternatingGroups_WithColorsAndK_ReturnsTheNumberOfAlternatingGroups(string colorsJson,
        int k, int expectedResult)
    {
        // Arrange
        var colors = JsonHelper.Parse<int[]>(colorsJson);

        var solution = new T();

        // Act
        var actualResult = solution.NumberOfAlternatingGroups(colors, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}