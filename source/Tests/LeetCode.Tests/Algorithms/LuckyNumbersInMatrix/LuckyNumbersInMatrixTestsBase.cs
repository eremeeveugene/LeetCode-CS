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

using LeetCode.Algorithms.LuckyNumbersInMatrix;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LuckyNumbersInMatrix;

public abstract class LuckyNumbersInMatrixTestsBase<T> where T : ILuckyNumbersInMatrix, new()
{
    [TestMethod]
    [DataRow("[[3,7,8],[9,11,13],[15,16,17]]", new[] { 15 })]
    [DataRow("[[1,10,4,2],[9,3,8,7],[15,16,17,12]]", new[] { 12 })]
    [DataRow("[[7,8],[1,2]]", new[] { 7 })]
    public void LuckyNumbers_WithMatrixJsonArray_ReturnsLuckyNumbers(string matrixJsonArray, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        var matrix = JsonHelper<int>.DeserializeToJaggedArray(matrixJsonArray);

        // Act
        var actualResult = solution.LuckyNumbers(matrix);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult.ToArray());
    }
}