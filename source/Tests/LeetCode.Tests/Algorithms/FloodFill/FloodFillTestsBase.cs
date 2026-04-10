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

using LeetCode.Algorithms.FloodFill;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FloodFill;

public abstract class FloodFillTestsBase<T> where T : IFloodFill, new()
{
    [TestMethod]
    [DataRow("[[0,0,0],[0,0,0]]", 0, 0, 0, "[[0,0,0],[0,0,0]]")]
    [DataRow("[[0,0,0],[0,0,0]]", 1, 0, 2, "[[2,2,2,],[2,2,2]]")]
    [DataRow("[[1,1,1],[1,1,0],[1,0,1]]", 1, 1, 2, "[[2,2,2],[2,2,0],[2,0,1]]")]
    public void FloodFill_WithInitialPositionAndNewColor_ReturnsModifiedImage(string imageJson, int sr, int sc,
        int color, string expectedResultJson)
    {
        // Arrange
        var image = JsonHelper.Parse<int[][]>(imageJson);
        var expectedResult = JsonHelper.Parse<int[][]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.FloodFill(image, sr, sc, color);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}