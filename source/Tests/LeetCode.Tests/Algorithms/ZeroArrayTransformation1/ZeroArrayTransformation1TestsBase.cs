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

using LeetCode.Algorithms.ZeroArrayTransformation1;

namespace LeetCode.Tests.Algorithms.ZeroArrayTransformation1;

public abstract class ZeroArrayTransformation1TestsBase<T> where T : IZeroArrayTransformation1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IsZeroArray_WithNumsAndQueries_ReturnsWhetherArrayCanBeTransformedToAllZeros(int[] nums, int[][] queries, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsZeroArray(nums, queries);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 0, 1 }, new[] { new[] { 0, 2 } }, true];

        yield return [new[] { 4, 3, 2, 1 }, new[] { new[] { 1, 3 }, new[] { 0, 2 } }, false];

        yield return [new[] { 0 }, new int[][] { }, true];

        yield return [new[] { 1 }, new int[][] { }, false];

        yield return [new[] { 1 }, new[] { new[] { 0, 0 } }, true];

        yield return [new[] { 2 }, new[] { new[] { 0, 0 } }, false];

        yield return [new[] { 0, 0, 0 }, new[] { new[] { 0, 1 } }, true];

        yield return [new[] { 1, 1, 1 }, new[] { new[] { 0, 0 }, new[] { 1, 1 }, new[] { 2, 2 } }, true];

        yield return [new[] { 1, 1, 1 }, new[] { new[] { 0, 0 }, new[] { 1, 1 } }, false];

        yield return [new[] { 2, 2 }, new[] { new[] { 0, 1 }, new[] { 0, 1 } }, true];

        yield return [new[] { 2, 2 }, new[] { new[] { 0, 1 }, new[] { 0, 0 } }, false];

        yield return [new[] { 3, 0, 3 }, new[] { new[] { 0, 2 }, new[] { 0, 2 }, new[] { 0, 2 } }, true];

        yield return [new[] { 3, 0, 3 }, new[] { new[] { 0, 2 }, new[] { 0, 2 } }, false];

        yield return [new[] { 1, 2, 1 }, new[] { new[] { 0, 2 }, new[] { 1, 1 } }, true];

        yield return [new[] { 1, 2, 1 }, new[] { new[] { 0, 2 } }, false];

        yield return [new[] { 5, 4, 3, 2, 1 }, new[] { new[] { 0, 4 }, new[] { 0, 4 }, new[] { 0, 4 }, new[] { 0, 4 }, new[] { 0, 4 } }, true];

        yield return [new[] { 5, 4, 3, 2, 1 }, new[] { new[] { 0, 4 }, new[] { 0, 4 }, new[] { 0, 4 }, new[] { 0, 4 } }, false];

        yield return [new[] { 1, 2, 3 }, new[] { new[] { 2, 2 }, new[] { 1, 2 }, new[] { 0, 2 } }, true];

        yield return [new[] { 1, 2, 3 }, new[] { new[] { 2, 2 }, new[] { 1, 2 }, new[] { 0, 1 } }, false];

        yield return [new[] { 0, 5, 0 }, new[] { new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 } }, true];

        yield return [new[] { 0, 5, 0 }, new[] { new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 } }, false];

        yield return [new[] { 10, 0, 0, 0 }, new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } }, true];

        yield return [new[] { 4, 3, 2, 1 }, new[] { new[] { 0, 3 }, new[] { 0, 2 }, new[] { 0, 1 }, new[] { 0, 0 } }, true];

        yield return [CreateFilledArray(100000, 1), new[] { new[] { 0, 99999 } }, true];

        yield return [CreateFilledArray(100000, 2), new[] { new[] { 0, 99999 } }, false];
    }

    private static int[] CreateFilledArray(int length, int value)
    {
        var result = new int[length];

        for (var i = 0; i < length; i++)
        {
            result[i] = value;
        }

        return result;
    }
}