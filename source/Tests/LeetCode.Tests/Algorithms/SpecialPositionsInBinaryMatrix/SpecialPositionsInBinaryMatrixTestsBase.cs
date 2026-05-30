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

using LeetCode.Algorithms.SpecialPositionsInBinaryMatrix;

namespace LeetCode.Tests.Algorithms.SpecialPositionsInBinaryMatrix;

public abstract class SpecialPositionsInBinaryMatrixTestsBase<T> where T : ISpecialPositionsInBinaryMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void NumSpecial_WithBinaryMatrix_ReturnsCountOfSpecialPositions(int[][] mat, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumSpecial(mat);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 0, 0 }, new[] { 0, 0, 1 }, new[] { 1, 0, 0 } }, 1];

        yield return [new[] { new[] { 1, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 1 } }, 3];
    }
}