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

using LeetCode.Algorithms.MyCalendar3;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.MyCalendar3;

public abstract class MyCalendar3TestsBase<T> where T : IMyCalendar3, new()
{
    private const string Book = "book";

    [TestMethod]
    [DataRow("[\"book\", \"book\", \"book\", \"book\", \"book\", \"book\"]",
        "[[10, 20], [50, 60], [10, 40], [5, 15], [5, 10], [25, 55]]", "[1, 1, 2, 3, 3, 3]")]
    public void Book_WithOverlappingEvents_ReturnsMaxConcurrentBookingsAfterEachEvent(string methodsJson,
        string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper.Parse<string[]>(methodsJson);
        var arguments = JsonHelper.Parse<int[][]>(argumentsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = new List<int>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Book:
                    actualResult.Add(solution.Book(arguments[i][0], arguments[i][1]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}