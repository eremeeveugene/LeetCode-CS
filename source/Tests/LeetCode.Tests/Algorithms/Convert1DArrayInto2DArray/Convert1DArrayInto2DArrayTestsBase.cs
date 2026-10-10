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

using LeetCode.Algorithms.Convert1DArrayInto2DArray;

namespace LeetCode.Tests.Algorithms.Convert1DArrayInto2DArray;

public abstract class Convert1DArrayInto2DArrayTestsBase<T> where T : IConvert1DArrayInto2DArray, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Construct2DArray_WithOriginalArrayAndDimensions_ReturnsReshapedMatrixOrEmptyArray(
        int[] original,
        int m,
        int n,
        int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Construct2DArray(original, m, n);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 3 }, 1, 2, Array.Empty<int[]>()];

        yield return [new[] { 1, 2 }, 1, 1, Array.Empty<int[]>()];

        yield return [new[] { 1, 2, 3 }, 1, 3, new[] { new[] { 1, 2, 3 } }];

        yield return [new[] { 1, 2, 3, 4 }, 2, 2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }];

        yield return [new[] { 1 }, 1, 1, new[] { new[] { 1 } }];

        yield return [new[] { 1, 2 }, 1, 2, new[] { new[] { 1, 2 } }];

        yield return [new[] { 1, 2 }, 2, 1, new[] { new[] { 1 }, new[] { 2 } }];

        yield return [new[] { 1, 2, 3, 4, 5, 6 }, 2, 3, new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }];

        yield return [new[] { 1, 2, 3, 4, 5, 6 }, 3, 2, new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } }];

        yield return [new[] { 1, 2, 3, 4, 5, 6 }, 1, 6, new[] { new[] { 1, 2, 3, 4, 5, 6 } }];

        yield return [new[] { 1, 2, 3, 4, 5, 6 }, 6, 1, new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 }, new[] { 5 }, new[] { 6 } }];

        yield return [new[] { 1, 2, 3, 4, 5, 6 }, 2, 2, Array.Empty<int[]>()];

        yield return [new[] { 1, 2, 3, 4, 5, 6 }, 3, 3, Array.Empty<int[]>()];

        yield return [new[] { 1, 2, 3, 4 }, 1, 3, Array.Empty<int[]>()];

        yield return [new[] { 1, 2, 3, 4 }, 4, 1, new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 } }];

        yield return [new[] { 5, 6, 7, 8, 9, 10, 11, 12, 13 }, 3, 3, new[] { new[] { 5, 6, 7 }, new[] { 8, 9, 10 }, new[] { 11, 12, 13 } }];

        yield return [new[] { 9, 8, 7, 6 }, 2, 2, new[] { new[] { 9, 8 }, new[] { 7, 6 } }];

        yield return [new[] { 1, 2, 3 }, 2, 2, Array.Empty<int[]>()];

        yield return [new[] { 100000, 2 }, 2, 1, new[] { new[] { 100000 }, new[] { 2 } }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 2, 4, new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 } }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 4, 2, new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 } }];
    }
}