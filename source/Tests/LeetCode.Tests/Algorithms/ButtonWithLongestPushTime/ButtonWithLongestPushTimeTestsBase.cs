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
    public void ButtonWithLongestTime_GivenEventArray_ReturnsIdOfButtonWithMaxTime(int[][] events,
        int expectedResult)
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
    }
}