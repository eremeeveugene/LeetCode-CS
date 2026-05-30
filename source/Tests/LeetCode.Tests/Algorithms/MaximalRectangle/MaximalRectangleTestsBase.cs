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

using LeetCode.Algorithms.MaximalRectangle;

namespace LeetCode.Tests.Algorithms.MaximalRectangle;

public abstract class MaximalRectangleTestsBase<T> where T : IMaximalRectangle, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaximalRectangle_GivenMatrix_ReturnsMaximalArea(char[][] matrix, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximalRectangle(matrix);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { '0' } }, 0];

        yield return [new[] { new[] { '1' } }, 1];

        yield return [new[] { new[] { '1', '0', '1', '0', '0' }, new[] { '1', '0', '1', '1', '1' }, new[] { '1', '1', '1', '1', '1' }, new[] { '1', '0', '0', '1', '0' } }, 6];
    }
}