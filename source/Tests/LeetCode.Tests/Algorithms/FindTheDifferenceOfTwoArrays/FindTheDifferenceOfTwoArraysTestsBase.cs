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

using LeetCode.Algorithms.FindTheDifferenceOfTwoArrays;

namespace LeetCode.Tests.Algorithms.FindTheDifferenceOfTwoArrays;

public abstract class FindTheDifferenceOfTwoArraysTestsBase<T> where T : IFindTheDifferenceOfTwoArrays, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindDifference_WithTwoIntegerArrays_ReturnsUniqueElementsInEachArray(int[] nums1, int[] nums2, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDifference(nums1, nums2);

        // Assert
        Assert.AreEquivalent<IEnumerable<IEnumerable<int>>>(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 2, 3 }, new[] { 2, 4, 6 }, new[] { new[] { 1, 3 }, new[] { 4, 6 } }];

        yield return [new[] { 1, 2, 3, 3 }, new[] { 1, 1, 2, 2 }, new[] { new[] { 3 }, Array.Empty<int>() }];

        yield return [new[] { 1 }, new[] { 1 }, new[] { new int[] { }, new int[] { } }];

        yield return [new[] { 1 }, new[] { 2 }, new[] { new[] { 1 }, new[] { 2 } }];

        yield return [new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { new int[] { }, new int[] { } }];

        yield return [new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }];

        yield return [new[] { 0 }, new[] { 0, 0 }, new[] { new int[] { }, new int[] { } }];

        yield return [new[] { -1, -2, -3 }, new[] { -3, 0, 1 }, new[] { new[] { -1, -2 }, new[] { 0, 1 } }];

        yield return [new[] { 1000, -1000 }, new[] { -1000, 1000, 500 }, new[] { new int[] { }, new[] { 500 } }];

        yield return [new[] { 5, 5, 5, 5 }, new[] { 5 }, new[] { new int[] { }, new int[] { } }];

        yield return [new[] { 1, 2, 3, 4, 5 }, new[] { 5 }, new[] { new[] { 1, 2, 3, 4 }, new int[] { } }];

        yield return [new[] { 7 }, new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { new int[] { }, new[] { 1, 2, 3, 4, 5, 6 } }];

        yield return [new[] { 1, 1, 2, 3, 3, 4 }, new[] { 2, 4, 6, 6 }, new[] { new[] { 1, 3 }, new[] { 6 } }];

        yield return [new[] { 10, 20, 30 }, new[] { 30, 20, 10 }, new[] { new int[] { }, new int[] { } }];

        yield return [new[] { 8, 9 }, new[] { 9, 10, 11 }, new[] { new[] { 8 }, new[] { 10, 11 } }];

        yield return [new[] { 0, 1 }, new[] { 1, 0, 2 }, new[] { new int[] { }, new[] { 2 } }];

        yield return [new[] { -5, 5 }, new[] { 5, -5 }, new[] { new int[] { }, new int[] { } }];

        yield return [new[] { 3, 6, 9, 12 }, new[] { 6, 12, 15 }, new[] { new[] { 3, 9 }, new[] { 15 } }];

        yield return [new[] { 100, 200, 300, 100 }, new[] { 200, 400, 400 }, new[] { new[] { 100, 300 }, new[] { 400 } }];

        yield return [new[] { 4, 5, 6 }, new[] { 6, 7, 8, 4 }, new[] { new[] { 5 }, new[] { 7, 8 } }];
    }
}