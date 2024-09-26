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

using LeetCode.Algorithms.MyCalendar1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MyCalendar1;

public abstract class MyCalendar1TestsBase<T> where T : IMyCalendar1, new()
{
    [TestMethod]
    [DataRow("[10,15,20]", "[20,25,30]", "[true,false,true]")]
    public void Test(string startJsonArray, string endJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var start = JsonHelper<int>.DeserializeToArray(startJsonArray);
        var end = JsonHelper<int>.DeserializeToArray(endJsonArray);
        var expectedResult = JsonHelper<bool>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = new bool[expectedResult.Length];

        for (var i = 0; i < expectedResult.Length; i++)
        {
            actualResult[i] = solution.Book(start[i], end[i]);
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}