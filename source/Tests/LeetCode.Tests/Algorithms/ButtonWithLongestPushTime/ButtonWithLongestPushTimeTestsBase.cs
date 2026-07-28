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

using LeetCode.Algorithms.ButtonWithLongestPushTime;

namespace LeetCode.Tests.Algorithms.ButtonWithLongestPushTime;

public abstract class ButtonWithLongestPushTimeTestsBase<T> where T : IButtonWithLongestPushTime, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ButtonWithLongestTime_GivenEventArray_ReturnsIdOfButtonWithMaxTime(int[][] events, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ButtonWithLongestTime(events);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 2, 5 }, new[] { 3, 9 }, new[] { 1, 15 } }, 1];

        yield return [new[] { new[] { 10, 5 }, new[] { 1, 7 } }, 10];

        yield return [new[] { new[] { 5, 3 }, new[] { 2, 6 } }, 2];

        yield return [new[] { new[] { 2, 3 }, new[] { 5, 6 } }, 2];

        yield return [new[] { new[] { 1, 10 } }, 1];

        yield return [new[] { new[] { 3, 4 }, new[] { 1, 10 } }, 1];

        yield return [new[] { new[] { 1, 4 }, new[] { 3, 10 } }, 3];

        yield return [new[] { new[] { 2, 5 }, new[] { 4, 8 }, new[] { 1, 20 } }, 1];

        yield return [new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, 1];

        yield return [new[] { new[] { 3, 1 }, new[] { 2, 2 }, new[] { 1, 3 } }, 1];

        yield return [new[] { new[] { 5, 2 }, new[] { 3, 10 }, new[] { 8, 11 } }, 3];

        yield return [new[] { new[] { 4, 7 }, new[] { 2, 14 }, new[] { 6, 15 } }, 2];

        yield return [new[] { new[] { 1, 5 }, new[] { 10, 10 }, new[] { 3, 15 } }, 1];

        yield return [new[] { new[] { 9, 3 }, new[] { 8, 6 }, new[] { 7, 9 } }, 7];

        yield return [new[] { new[] { 2, 10 }, new[] { 5, 25 } }, 5];

        yield return [new[] { new[] { 5, 10 }, new[] { 2, 15 } }, 5];

        yield return [new[] { new[] { 1, 100 } }, 1];

        yield return [new[] { new[] { 7, 50 } }, 7];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 4 }, new[] { 3, 6 }, new[] { 4, 8 } }, 1];

        yield return [new[] { new[] { 4, 2 }, new[] { 3, 4 }, new[] { 2, 6 }, new[] { 1, 8 } }, 1];

        yield return [new[] { new[] { 6, 5 }, new[] { 1, 11 }, new[] { 6, 17 } }, 1];

        yield return [new[] { new[] { 3, 8 }, new[] { 1, 12 }, new[] { 2, 20 } }, 2];
    }
}