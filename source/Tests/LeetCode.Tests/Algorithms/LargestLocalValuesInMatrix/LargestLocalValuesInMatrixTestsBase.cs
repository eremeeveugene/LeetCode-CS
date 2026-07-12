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

using LeetCode.Algorithms.LargestLocalValuesInMatrix;

namespace LeetCode.Tests.Algorithms.LargestLocalValuesInMatrix;

public abstract class LargestLocalValuesInMatrixTestsBase<T> where T : ILargestLocalValuesInMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LargestLocal_WithGridInput_ReturnsMatrixOfMaxValuesFrom3x3Neighborhoods(int[][] grid, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestLocal(grid);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 9, 9, 8, 1 }, new[] { 5, 6, 2, 6 }, new[] { 8, 2, 6, 4 }, new[] { 6, 2, 2, 2 } },
            new[] { new[] { 9, 9 }, new[] { 8, 6 } }
        ];

        yield return
        [
            new[] { new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 2, 1, 1 }, new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1 } },
            new[] { new[] { 2, 2, 2 }, new[] { 2, 2, 2 }, new[] { 2, 2, 2 } }
        ];
    }
}