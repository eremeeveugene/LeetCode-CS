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

using LeetCode.Algorithms.ToggleLightBulbs;

namespace LeetCode.Tests.Algorithms.ToggleLightBulbs;

public abstract class ToggleLightBulbsTestsBase<T> where T : IToggleLightBulbs, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ToggleLightBulbs_WithGivenBulbSequence_ReturnsSwitchedOnBulbsSortedInAscendingOrder(List<int> bulbs, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var switchedOnBulbs = solution.ToggleLightBulbs(bulbs);

        var actualResult = new int[switchedOnBulbs.Count];

        switchedOnBulbs.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new List<int> { 100, 100 }, Array.Empty<int>()];

        yield return [new List<int> { 10, 30, 20, 10 }, new[] { 20, 30 }];

        yield return [new List<int> { 1 }, new[] { 1 }];

        yield return [new List<int> { 100 }, new[] { 100 }];

        yield return [new List<int> { 1, 1 }, Array.Empty<int>()];

        yield return [new List<int> { 1, 2, 3 }, new[] { 1, 2, 3 }];

        yield return [new List<int> { 3, 2, 1 }, new[] { 1, 2, 3 }];

        yield return [new List<int> { 5, 5, 5 }, new[] { 5 }];

        yield return [new List<int> { 1, 100, 1, 100 }, Array.Empty<int>()];

        yield return [new List<int> { 50, 50, 50, 50 }, Array.Empty<int>()];

        yield return [new List<int> { 2, 4, 6, 8, 10, 4 }, new[] { 2, 6, 8, 10 }];

        yield return [new List<int> { 100, 99, 98, 97, 96, 95, 100 }, new[] { 95, 96, 97, 98, 99 }];

        yield return [new List<int> { 7, 3, 7, 3, 7 }, new[] { 7 }];

        yield return [new List<int> { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, new[] { 1, 2, 3 }];

        yield return [new List<int> { 64, 63, 65, 64 }, new[] { 63, 65 }];

        yield return [new List<int> { 99, 1, 50, 99, 1, 50, 25 }, new[] { 25 }];

        yield return [new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }, new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }];

        yield return [new List<int> { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 10 }, new[] { 20, 30, 40, 50, 60, 70, 80, 90, 100 }];

        yield return [BuildBulbs(100, 1), BuildSequence(100)];

        yield return [BuildBulbs(50, 2), Array.Empty<int>()];
    }

    private static List<int> BuildBulbs(int count, int repeatCount)
    {
        var bulbs = new List<int>();

        for (var repeat = 0; repeat < repeatCount; repeat++)
        {
            for (var i = 1; i <= count; i++)
            {
                bulbs.Add(i);
            }
        }

        return bulbs;
    }

    private static int[] BuildSequence(int count)
    {
        var sequence = new int[count];

        for (var i = 0; i < count; i++)
        {
            sequence[i] = i + 1;
        }

        return sequence;
    }
}