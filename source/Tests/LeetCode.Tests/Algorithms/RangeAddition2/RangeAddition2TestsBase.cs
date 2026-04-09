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

using LeetCode.Algorithms.RangeAddition2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RangeAddition2;

public abstract class RangeAddition2TestsBase<T> where T : IRangeAddition2, new()
{
    [TestMethod]
    [DataRow(3, 3, "[[2,2],[3,3]]", 4)]
    [DataRow(3, 3, "[[2,2],[3,3],[3,3],[3,3],[2,2],[3,3],[3,3],[3,3],[2,2],[3,3],[3,3],[3,3]]", 4)]
    [DataRow(3, 3, "[]", 9)]
    public void MaxCount_WithMatrixDimensionsAndOperations_ReturnsCountOfMaximumIntegers(int m, int n, string opsJson,
        int expectedResult)
    {
        // Arrange
        var ops = JsonHelper.Parse<int[][]>(opsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxCount(m, n, ops);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}