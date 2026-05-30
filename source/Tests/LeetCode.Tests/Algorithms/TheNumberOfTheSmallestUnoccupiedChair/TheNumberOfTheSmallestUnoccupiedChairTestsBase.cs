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

using LeetCode.Algorithms.TheNumberOfTheSmallestUnoccupiedChair;

namespace LeetCode.Tests.Algorithms.TheNumberOfTheSmallestUnoccupiedChair;

public abstract class TheNumberOfTheSmallestUnoccupiedChairTestsBase<T>
    where T : ITheNumberOfTheSmallestUnoccupiedChair, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SmallestChair_WithArrivalAndLeavingTimes_ReturnsChairAssignedToTargetFriend(int[][] times,
        int targetFriend, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestChair(times, targetFriend);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 4 }, new[] { 2, 3 }, new[] { 4, 6 } }, 1, 1];

        yield return [new[] { new[] { 1, 4 }, new[] { 2, 3 }, new[] { 4, 6 } }, 2, 0];

        yield return [new[] { new[] { 3, 10 }, new[] { 1, 5 }, new[] { 2, 6 } }, 0, 2];

        yield return
        [
            new[]
            {
                new[] { 33, 35 }, new[] { 26, 29 }, new[] { 9, 28 }, new[] { 4, 31 }, new[] { 8, 10 },
                new[] { 32, 34 }, new[] { 15, 24 }, new[] { 27, 39 }, new[] { 14, 36 }, new[] { 1, 14 },
                new[] { 25, 39 }, new[] { 5, 27 }, new[] { 6, 15 }, new[] { 2, 38 }, new[] { 19, 36 },
                new[] { 24, 34 }, new[] { 3, 26 }
            },
            0, 3
        ];
    }
}