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

using LeetCode.Algorithms.DiagonalTraverse;

namespace LeetCode.Tests.Algorithms.DiagonalTraverse;

public abstract class DiagonalTraverseTestsBase<T> where T : IDiagonalTraverse, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindDiagonalOrder_WithMatrix_ReturnsElementsInDiagonalTraversalOrder(int[][] mat, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDiagonalOrder(mat);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 1, 2, 3, 4 }];

        yield return [new[] { new[] { 1 } }, new[] { 1 }];

        yield return [new[] { new[] { 1, 2 } }, new[] { 1, 2 }];

        yield return [new[] { new[] { 1 }, new[] { 2 } }, new[] { 1, 2 }];

        yield return [new[] { new[] { 1, 2, 3 } }, new[] { 1, 2, 3 }];

        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 } }, new[] { 1, 2, 3 }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } }, new[] { 1, 2, 3, 5, 4, 6 }];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, new[] { 1, 2, 4, 5, 3, 6 }];

        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 } }, new[] { 1, 2, 5, 9, 6, 3, 4, 7, 10, 11, 8, 12 }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 } }, new[] { 1, 2, 3, 5, 4, 6, 7, 8 }];

        yield return [new[] { new[] { -1, 0 }, new[] { 0, -1 } }, new[] { -1, 0, 0, -1 }];

        yield return [new[] { new[] { 1, 2, 3, 4, 5 } }, new[] { 1, 2, 3, 4, 5 }];

        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 }, new[] { 5 } }, new[] { 1, 2, 3, 4, 5 }];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 }, new[] { 10, 11, 12 } }, new[] { 1, 2, 4, 7, 5, 3, 6, 8, 10, 11, 9, 12 }];

        yield return [new[] { new[] { 100000, -100000 }, new[] { 0, 5 } }, new[] { 100000, -100000, 0, 5 }];

        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 }, new[] { 13, 14, 15, 16 } }, new[] { 1, 2, 5, 9, 6, 3, 4, 7, 10, 13, 14, 11, 8, 12, 15, 16 }];

        yield return [new[] { new[] { 7, 7 }, new[] { 7, 7 } }, new[] { 7, 7, 7, 7 }];

        yield return [new[] { new[] { 1, 2, 3, 4, 5, 6 }, new[] { 7, 8, 9, 10, 11, 12 } }, new[] { 1, 2, 7, 8, 3, 4, 9, 10, 5, 6, 11, 12 }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 }, new[] { 9, 10 } }, new[] { 1, 2, 3, 5, 4, 6, 7, 9, 8, 10 }];
    }
}