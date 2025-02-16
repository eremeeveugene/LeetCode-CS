// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ButtonWithLongestPushTime;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ButtonWithLongestPushTime;

public abstract class ButtonWithLongestPushTimeTestsBase<T> where T : IButtonWithLongestPushTime, new()
{
    [TestMethod]
    [DataRow("[[1,2],[2,5],[3,9],[1,15]]", 1)]
    [DataRow("[[10,5],[1,7]]", 10)]
    public void ButtonWithLongestTime_GivenEventArray_ReturnsIdOfButtonWithMaxTime(string eventsJsonArray,
        int expectedResult)
    {
        // Arrange
        var events = JsonHelper<int>.DeserializeToJaggedArray(eventsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ButtonWithLongestTime(events);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}