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

using LeetCode.Algorithms.FindXValueOfArray1;

namespace LeetCode.Tests.Algorithms.FindXValueOfArray1;

public abstract class FindXValueOfArray1TestsBase<T> where T : IFindXValueOfArray1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ResultArray_WithGivenNumbersAndDivisor_ReturnsSubarrayProductRemainderCounts(int[] nums, int k, long[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ResultArray(nums, k);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 2, 3, 4, 5 }, 3, new long[] { 9, 2, 4 }];
        yield return [new[] { 1, 2, 4, 8, 16, 32 }, 4, new long[] { 18, 1, 2, 0 }];
        yield return [new[] { 1, 1, 2, 1, 1 }, 2, new long[] { 9, 6 }];
        yield return [new[] { 1 }, 1, new long[] { 1 }];
        yield return [new[] { 1000000000 }, 1, new long[] { 1 }];
        yield return [new[] { 1 }, 2, new long[] { 0, 1 }];
        yield return [new[] { 2 }, 2, new long[] { 1, 0 }];
        yield return [new[] { 1 }, 3, new long[] { 0, 1, 0 }];
        yield return [new[] { 2 }, 3, new long[] { 0, 0, 1 }];
        yield return [new[] { 3 }, 3, new long[] { 1, 0, 0 }];
        yield return [new[] { 3 }, 4, new long[] { 0, 0, 0, 1 }];
        yield return [new[] { 4 }, 4, new long[] { 1, 0, 0, 0 }];
        yield return [new[] { 4 }, 5, new long[] { 0, 0, 0, 0, 1 }];
        yield return [new[] { 5 }, 5, new long[] { 1, 0, 0, 0, 0 }];
        yield return [new[] { 1, 1, 1, 1 }, 1, new long[] { 10 }];
        yield return [new[] { 1, 1, 1, 1 }, 5, new long[] { 0, 10, 0, 0, 0 }];
        yield return [new[] { 2, 2, 2, 2 }, 2, new long[] { 10, 0 }];
        yield return [new[] { 2, 2, 2, 2 }, 3, new long[] { 0, 4, 6 }];
        yield return [new[] { 2, 2, 2, 2 }, 4, new long[] { 6, 0, 4, 0 }];
        yield return [new[] { 2, 2, 2, 2 }, 5, new long[] { 0, 1, 4, 2, 3 }];
        yield return [new[] { 3, 3, 3, 3 }, 4, new long[] { 0, 4, 0, 6 }];
        yield return [new[] { 4, 4, 4, 4 }, 5, new long[] { 0, 4, 0, 0, 6 }];
        yield return [new[] { 5, 10, 15 }, 5, new long[] { 6, 0, 0, 0, 0 }];
        yield return [new[] { 2, 3 }, 4, new long[] { 0, 0, 2, 1 }];
        yield return [new[] { 2, 3, 2 }, 4, new long[] { 1, 0, 4, 1 }];
        yield return [new[] { 3, 2, 3 }, 4, new long[] { 0, 0, 4, 2 }];
        yield return [new[] { 1, 2, 3, 4, 5 }, 5, new long[] { 5, 3, 3, 1, 3 }];
        yield return [new[] { 5, 4, 3, 2, 1 }, 5, new long[] { 5, 3, 3, 1, 3 }];
        yield return [new[] { 1, 3, 5, 7 }, 2, new long[] { 0, 10 }];
        yield return [new[] { 1, 2, 1, 2, 1 }, 2, new long[] { 12, 3 }];
        yield return [new[] { 3, 1, 2, 3, 4 }, 3, new long[] { 11, 2, 2 }];
        yield return [new[] { 2, 4, 6, 8 }, 4, new long[] { 8, 0, 2, 0 }];
        yield return [new[] { 1, 5, 1 }, 5, new long[] { 4, 2, 0, 0, 0 }];
        yield return [new[] { 1000000000, 1000000000 }, 5, new long[] { 3, 0, 0, 0, 0 }];
        yield return [new[] { 999999999, 999999999, 999999999 }, 5, new long[] { 0, 2, 0, 0, 4 }];
        yield return [new[] { 1000000000, 999999999, 999999998, 999999997 }, 3, new long[] { 6, 2, 2 }];
        yield return [new[] { 1000000000, 999999999, 999999998, 999999997 }, 4, new long[] { 4, 1, 4, 1 }];
        yield return [new[] { 1000000000, 999999999, 999999998, 999999997 }, 5, new long[] { 4, 1, 2, 1, 2 }];
        yield return [CreateFilledArray(1, 100000), 1, new[] { 5000050000L }];
        yield return [CreateFilledArray(1, 100000), 5, new[] { 0, 5000050000L, 0, 0, 0 }];
        yield return [CreateFilledArray(1000000000, 100000), 5, new[] { 5000050000L, 0, 0, 0, 0 }];
        yield return [CreateFilledArray(4, 100000), 5, new[] { 0, 2500000000L, 0, 0, 2500050000L }];
    }

    private static int[] CreateFilledArray(int value, int length)
    {
        var result = new int[length];

        Array.Fill(result, value);

        return result;
    }
}