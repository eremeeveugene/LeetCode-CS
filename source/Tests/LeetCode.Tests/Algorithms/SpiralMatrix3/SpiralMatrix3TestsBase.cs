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

using LeetCode.Algorithms.SpiralMatrix3;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SpiralMatrix3;

public abstract class SpiralMatrix3TestsBase<T> where T : ISpiralMatrix3, new()
{
    [TestMethod]
    [DataRow(1, 4, 0, 0, "[[0,0],[0,1],[0,2],[0,3]]")]
    [DataRow(5, 6, 1, 4,
        "[[1,4],[1,5],[2,5],[2,4],[2,3],[1,3],[0,3],[0,4],[0,5],[3,5],[3,4],[3,3],[3,2],[2,2],[1,2],[0,2],[4,5],[4,4],[4,3],[4,2],[4,1],[3,1],[2,1],[1,1],[0,1],[4,0],[3,0],[2,0],[1,0],[0,0]]")]
    public void SpiralMatrixIII_WithGridSizeAndStartCoordinates_ReturnsCorrectPath(int rows, int cols, int rStart,
        int cStart, string expectedResultJsonArray)
    {
        // Arrange
        var solution = new T();

        var expectedResult = JsonHelper<int>.DeserializeToJaggedArray(expectedResultJsonArray);

        // Act
        var actualResult = solution.SpiralMatrixIII(rows, cols, rStart, cStart);

        // Assert
        JaggedArrayAssert.AreEqual(expectedResult, actualResult);
    }
}