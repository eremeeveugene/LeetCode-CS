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

using LeetCode.Algorithms.ZeroArrayTransformation3;

namespace LeetCode.Tests.Algorithms.ZeroArrayTransformation3;

public abstract class ZeroArrayTransformation3TestsBase<T> where T : IZeroArrayTransformation3, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxRemoval_WithGivenNumsAndQueries_ReturnsMaximumRemovablePrefixLength(int[] nums, int[][] queries, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxRemoval(nums, queries);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 2, 0, 2 }, new[] { new[] { 0, 2 }, new[] { 0, 2 }, new[] { 1, 1 } }, 1];

        yield return [new[] { 1, 1, 1, 1 }, new[] { new[] { 1, 3 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 2 } }, 2];

        yield return [new[] { 1, 2, 3, 4 }, new[] { new[] { 0, 3 } }, -1];

        yield return [new[] { 0 }, new int[][] { }, 0];

        yield return [new[] { 0 }, new[] { new[] { 0, 0 } }, 1];

        yield return [new[] { 1 }, new[] { new[] { 0, 0 } }, 0];

        yield return [new[] { 1 }, new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 1];

        yield return [new[] { 2 }, new[] { new[] { 0, 0 } }, -1];

        yield return [new[] { 0, 0 }, new[] { new[] { 0, 1 }, new[] { 1, 1 } }, 2];

        yield return [new[] { 1, 1 }, new[] { new[] { 0, 0 }, new[] { 1, 1 }, new[] { 0, 1 } }, 2];

        yield return [new[] { 1, 0, 1 }, new[] { new[] { 0, 0 }, new[] { 2, 2 }, new[] { 0, 2 } }, 2];

        yield return [new[] { 2, 2 }, new[] { new[] { 0, 1 }, new[] { 0, 1 }, new[] { 0, 1 } }, 1];

        yield return [new[] { 1, 2, 1 }, new[] { new[] { 0, 2 }, new[] { 1, 1 }, new[] { 1, 2 }, new[] { 0, 1 } }, 2];

        yield return [new[] { 3 }, new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } }, 2];

        yield return [new[] { 0, 0, 0 }, new[] { new[] { 0, 2 }, new[] { 1, 1 }, new[] { 0, 0 }, new[] { 2, 2 } }, 4];

        yield return [new[] { 1, 0, 0, 1 }, new[] { new[] { 0, 3 }, new[] { 1, 2 }, new[] { 0, 1 }, new[] { 2, 3 } }, 3];

        yield return [new[] { 2, 1, 2 }, new[] { new[] { 0, 0 }, new[] { 0, 2 }, new[] { 2, 2 }, new[] { 1, 1 }, new[] { 0, 2 } }, 3];

        yield return [new[] { 1, 1, 1 }, new[] { new[] { 0, 0 }, new[] { 1, 1 } }, -1];

        yield return [new[] { 5, 5 }, new[] { new[] { 0, 1 }, new[] { 0, 1 }, new[] { 0, 1 }, new[] { 0, 1 } }, -1];

        yield return [new[] { 1, 3, 1 }, new[] { new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1 }, new[] { 0, 2 }, new[] { 0, 0 } }, 2];

        yield return [new[] { 2, 0, 2 }, new[] { new[] { 0, 2 }, new[] { 0, 2 }, new[] { 1, 1 }, new[] { 0, 0 }, new[] { 2, 2 } }, 3];

        yield return [CreateFilledArray(100000, 0), CreateQueries(100000, 0, 0), 100000];

        yield return [CreateFilledArray(100000, 1), CreateQueries(100000, 0, 99999), 99999];

        yield return [CreateFilledArray(100000, 2), CreateQueries(1, 0, 99999), -1];
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

    private static int[][] CreateQueries(int count, int left, int right)
    {
        var result = new int[count][];

        for (var i = 0; i < count; i++)
        {
            result[i] = [left, right];
        }

        return result;
    }
}