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

using LeetCode.Algorithms.SpiralMatrix4;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.SpiralMatrix4;

public abstract class SpiralMatrix4TestsBase<T> where T : ISpiralMatrix4, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SpiralMatrix_WithDimensionsAndLinkedList_FillsMatrixInClockwiseSpiralOrderOrMinusOne(
        int m,
        int n,
        int[] headArray,
        int[][] expectedResult)
    {
        // Arrange
        var head = ListNode.ToListNodeOrThrow(headArray);

        var solution = new T();

        // Act
        var actualResult = solution.SpiralMatrix(m, n, head);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            3,
            5,
            new[] { 3, 0, 2, 6, 8, 1, 7, 9, 4, 2, 5, 5, 0 },
            new[] { new[] { 3, 0, 2, 6, 8 }, new[] { 5, 0, -1, -1, 1 }, new[] { 5, 2, 4, 9, 7 } }
        ];

        yield return [1, 4, new[] { 0, 1, 2 }, new[] { new[] { 0, 1, 2, -1 } }];

        yield return
        [
            4,
            4,
            new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
            new[] { new[] { 1, 2, 3, 4 }, new[] { 12, 13, 14, 5 }, new[] { 11, 16, 15, 6 }, new[] { 10, 9, 8, 7 } }
        ];
    }
}