// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.TheNumberOfTheSmallestUnoccupiedChair;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TheNumberOfTheSmallestUnoccupiedChair;

public abstract class TheNumberOfTheSmallestUnoccupiedChairTestsBase<T>
    where T : ITheNumberOfTheSmallestUnoccupiedChair, new()
{
    [TestMethod]
    [DataRow("[[1,4],[2,3],[4,6]]", 1, 1)]
    [DataRow("[[1,4],[2,3],[4,6]]", 2, 0)]
    [DataRow("[[3,10],[1,5],[2,6]]", 0, 2)]
    [DataRow(
        "[[33,35],[26,29],[9,28],[4,31],[8,10],[32,34],[15,24],[27,39],[14,36],[1,14],[25,39],[5,27],[6,15],[2,38],[19,36],[24,34],[3,26]]",
        0, 3)]
    public void SmallestChair_WithSeatingTimesAndTargetFriend_ReturnsCorrectChair(string timesJsonArray,
        int targetFriend, int expectedResult)
    {
        // Arrange
        var times = JsonHelper<int>.DeserializeToJaggedArray(timesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.SmallestChair(times, targetFriend);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}