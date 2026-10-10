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

using LeetCode.Algorithms.SmallestRangeCoveringElementsFromKLists;

namespace LeetCode.Tests.Algorithms.SmallestRangeCoveringElementsFromKLists;

public abstract class SmallestRangeCoveringElementsFromKListsTestsBase<T> where T : ISmallestRangeCoveringElementsFromKLists, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SmallestRange_WithMultipleSortedLists_ReturnsMinimumRangeIncludingAtLeastOneElementFromEachList(
        IList<IList<int>> nums,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestRange(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new IList<int>[] { new[] { 10 }, new[] { 11 } }, new[] { 10, 11 }];

        yield return [new IList<int>[] { new[] { 4, 10, 15, 24, 26 }, new[] { 0, 9, 12, 20 }, new[] { 5, 18, 22, 30 } }, new[] { 20, 24 }];

        yield return [new IList<int>[] { new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3 } }, new[] { 1, 1 }];
        yield return [new IList<int>[] { new[] { 1 } }, new[] { 1, 1 }];
        yield return [new IList<int>[] { new[] { -100000 }, new[] { 100000 } }, new[] { -100000, 100000 }];
        yield return [new IList<int>[] { new[] { 5, 5, 5 }, new[] { 5 } }, new[] { 5, 5 }];
        yield return [new IList<int>[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, new[] { 3, 4 }];
        yield return [new IList<int>[] { new[] { 1, 5, 9 }, new[] { 2, 6, 10 }, new[] { 3, 7, 11 } }, new[] { 1, 3 }];
        yield return [new IList<int>[] { new[] { -5, -3, 0 }, new[] { -4, -1 }, new[] { -2 } }, new[] { -4, -2 }];
        yield return [new IList<int>[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } }, new[] { 0, 0 }];
        yield return [new IList<int>[] { new[] { 1, 100 }, new[] { 50, 60 }, new[] { 55, 200 } }, new[] { 55, 100 }];
        yield return [new IList<int>[] { new[] { 10, 20, 30, 40 }, new[] { 5 }, new[] { 25, 26 } }, new[] { 5, 25 }];
        yield return [new IList<int>[] { new[] { 1, 2, 3, 4, 5 } }, new[] { 1, 1 }];
        yield return [new IList<int>[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 }, new[] { 5 } }, new[] { 1, 5 }];
        yield return [new IList<int>[] { new[] { -100000, -50000, 0, 50000, 100000 }, new[] { 100000 }, new[] { -100000 } }, new[] { -100000, 100000 }];
        yield return [new IList<int>[] { new[] { 3, 3, 4 }, new[] { 4, 4, 5 }, new[] { 1, 4, 9 } }, new[] { 4, 4 }];
        yield return [new IList<int>[] { new[] { 1, 10 }, new[] { 2, 9 }, new[] { 3, 8 }, new[] { 4, 7 } }, new[] { 1, 4 }];
        yield return [new IList<int>[] { new[] { 7, 8, 9 }, new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, new[] { 3, 7 }];
        yield return [new IList<int>[] { new[] { 2, 2, 2 }, new[] { 2, 2 }, new[] { 1, 2, 3 } }, new[] { 2, 2 }];
        yield return [new IList<int>[] { new[] { 1, 1000 }, new[] { 500, 501 }, new[] { 999, 1001, 2000 } }, new[] { 501, 1000 }];
    }
}