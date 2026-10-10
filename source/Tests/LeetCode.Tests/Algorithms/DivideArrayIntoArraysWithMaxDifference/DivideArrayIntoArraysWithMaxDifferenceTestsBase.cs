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

using LeetCode.Algorithms.DivideArrayIntoArraysWithMaxDifference;

namespace LeetCode.Tests.Algorithms.DivideArrayIntoArraysWithMaxDifference;

public abstract class DivideArrayIntoArraysWithMaxDifferenceTestsBase<T> where T : IDivideArrayIntoArraysWithMaxDifference, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void DivideArray_WithVariousInputs_ReturnsCorrectTripletGroupingOrEmptyArray(int[] nums, int k, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DivideArray(nums, k);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 3, 4, 8, 7, 9, 3, 5, 1 }, 2, new[] { new[] { 1, 1, 3 }, new[] { 3, 4, 5 }, new[] { 7, 8, 9 } }];

        yield return [new[] { 2, 4, 2, 2, 5, 2 }, 2, Array.Empty<int[]>()];

        yield return
        [
            new[] { 4, 2, 9, 8, 2, 12, 7, 12, 10, 5, 8, 5, 5, 7, 9, 2, 5, 11 },
            14,
            new[] { new[] { 2, 2, 2 }, new[] { 4, 5, 5 }, new[] { 5, 5, 7 }, new[] { 7, 8, 8 }, new[] { 9, 9, 10 }, new[] { 11, 12, 12 } }
        ];

        yield return [new[] { 1, 2, 3 }, 1, Array.Empty<int[]>()];

        yield return [new[] { 1, 2, 3 }, 2, new[] { new[] { 1, 2, 3 } }];

        yield return [new[] { 5, 5, 5 }, 1, new[] { new[] { 5, 5, 5 } }];

        yield return [new[] { 1, 1, 1, 10, 10, 10 }, 0, new[] { new[] { 1, 1, 1 }, new[] { 10, 10, 10 } }];

        yield return [new[] { 1, 2, 3, 4, 5, 6 }, 2, new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }];

        yield return [new[] { 1, 2, 3, 4, 5, 6 }, 1, Array.Empty<int[]>()];

        yield return [new[] { 3, 2, 1, 6, 5, 4 }, 2, new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }];

        yield return [new[] { 1, 100000, 2 }, 100000, new[] { new[] { 1, 2, 100000 } }];

        yield return [new[] { 1, 100000, 2 }, 5, Array.Empty<int[]>()];

        yield return [new[] { 9, 7, 8, 1, 2, 3, 4, 5, 6 }, 2, new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }];

        yield return [new[] { 1, 5, 9, 2, 6, 10, 3, 7, 11 }, 2, new[] { new[] { 1, 2, 3 }, new[] { 5, 6, 7 }, new[] { 9, 10, 11 } }];

        yield return [new[] { 1, 5, 9, 2, 6, 10, 3, 7, 11 }, 10, new[] { new[] { 1, 2, 3 }, new[] { 5, 6, 7 }, new[] { 9, 10, 11 } }];

        yield return [new[] { 4, 4, 4, 4, 4, 4, 4, 4, 4 }, 1, new[] { new[] { 4, 4, 4 }, new[] { 4, 4, 4 }, new[] { 4, 4, 4 } }];

        yield return [new[] { 1, 3, 5, 7, 9, 11 }, 4, new[] { new[] { 1, 3, 5 }, new[] { 7, 9, 11 } }];

        yield return [new[] { 10, 1, 1, 10, 1, 10 }, 0, new[] { new[] { 1, 1, 1 }, new[] { 10, 10, 10 } }];

        yield return [new[] { 1, 2, 4, 5, 6, 8 }, 3, new[] { new[] { 1, 2, 4 }, new[] { 5, 6, 8 } }];

        yield return [new[] { 2, 2, 2, 3, 3, 3 }, 1, new[] { new[] { 2, 2, 2 }, new[] { 3, 3, 3 } }];
    }
}