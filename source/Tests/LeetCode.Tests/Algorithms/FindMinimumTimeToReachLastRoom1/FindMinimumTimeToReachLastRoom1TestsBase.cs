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

using LeetCode.Algorithms.FindMinimumTimeToReachLastRoom1;

namespace LeetCode.Tests.Algorithms.FindMinimumTimeToReachLastRoom1;

public abstract class FindMinimumTimeToReachLastRoom1TestsBase<T> where T : IFindMinimumTimeToReachLastRoom1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinTimeToReach_WithMoveTimeMatrix_ReturnsMinimumTimeRequired(int[][] moveTime,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinTimeToReach(moveTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 4 }, new[] { 4, 4 } }, 6];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 2 } }, 3];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 3];

        yield return [new[] { new[] { 0, 2, 4 }, new[] { 3, 1, 5 }, new[] { 6, 3, 8 } }, 9];

        yield return [new[] { new[] { 15, 58 }, new[] { 67, 4 } }, 60];

        yield return [new[] { new[] { 17, 56 }, new[] { 97, 80 } }, 81];

        yield return [new[] { new[] { 94, 79, 62, 27, 69, 84 }, new[] { 6, 32, 11, 82, 42, 30 } }, 72];

        yield return
        [
            new[]
            {
                new[] { 63, 102, 19, 11, 110, 26, 89, 101, 19 }, new[] { 7, 17, 119, 94, 44, 3, 30, 111, 54 },
                new[] { 20, 66, 72, 19, 76, 6, 16, 0, 97 }, new[] { 7, 48, 113, 22, 14, 100, 99, 91, 60 }
            },
            93
        ];
    }
}