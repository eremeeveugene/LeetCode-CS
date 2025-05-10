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

using LeetCode.Algorithms.FirstCompletelyPaintedRowOrColumn;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FirstCompletelyPaintedRowOrColumn;

public abstract class FirstCompletelyPaintedRowOrColumnTestsBase<T> where T : IFirstCompletelyPaintedRowOrColumn, new()
{
    [TestMethod]
    [DataRow("[1,3,4,2]", "[[1,4],[2,3]]", 2)]
    [DataRow("[2,8,7,4,1,3,5,6,9]", "[[3,2,5],[1,4,6],[8,7,9]]", 3)]
    public void FirstCompleteIndex_WithSequenceAndMatrix_ReturnsFirstCompletedRowOrColumnIndex(string arrJson,
        string matJson, int expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int>.DeserializeToArray(arrJson);
        var mat = JsonHelper<int>.DeserializeToJaggedArray(matJson);

        var solution = new T();

        // Act
        var actualResult = solution.FirstCompleteIndex(arr, mat);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}