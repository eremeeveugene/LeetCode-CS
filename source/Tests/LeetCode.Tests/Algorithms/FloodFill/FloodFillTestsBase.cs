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

using LeetCode.Algorithms.FloodFill;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.FloodFill;

public abstract class FloodFillTestsBase<T> where T : IFloodFill, new()
{
    [TestMethod]
    [DataRow("[[0,0,0],[0,0,0]]", 0, 0, 0, "[[0,0,0],[0,0,0]]")]
    [DataRow("[[0,0,0],[0,0,0]]", 1, 0, 2, "[[2,2,2,],[2,2,2]]")]
    [DataRow("[[1,1,1],[1,1,0],[1,0,1]]", 1, 1, 2, "[[2,2,2],[2,2,0],[2,0,1]]")]
    public void FloodFill_WithInitialPositionAndNewColor_ReturnsModifiedImage(string imageJsonArray, int sr, int sc,
        int color, string expectedResultJsonArray)
    {
        // Arrange
        var intervals = JsonHelper<int>.JsonArrayToJaggedArray(imageJsonArray);
        var expectedResult = JsonHelper<int>.JsonArrayToJaggedArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FloodFill(intervals, sr, sc, color);

        // Assert
        AssertExtensions.AssertJaggedArrayEqual(expectedResult, actualResult);
    }
}