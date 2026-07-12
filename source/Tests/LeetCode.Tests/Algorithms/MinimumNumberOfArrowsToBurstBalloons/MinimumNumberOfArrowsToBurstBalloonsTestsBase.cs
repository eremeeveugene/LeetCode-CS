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

using LeetCode.Algorithms.MinimumNumberOfArrowsToBurstBalloons;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfArrowsToBurstBalloons;

public abstract class MinimumNumberOfArrowsToBurstBalloonsTestsBase<T> where T : IMinimumNumberOfArrowsToBurstBalloons, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindMinArrowShots_GivenDifferentPointCombinations_ReturnsMinimumArrowsRequired(int[][] points, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMinArrowShots(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 10, 16 }, new[] { 2, 8 }, new[] { 1, 6 }, new[] { 7, 12 } }, 2];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 } }, 4];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, 2];

        yield return
        [
            new[]
            {
                new[] { 3, 9 },
                new[] { 7, 12 },
                new[] { 3, 8 },
                new[] { 6, 8 },
                new[] { 9, 10 },
                new[] { 2, 9 },
                new[] { 0, 9 },
                new[] { 3, 9 },
                new[] { 0, 6 },
                new[] { 2, 8 }
            },
            2
        ];
    }
}