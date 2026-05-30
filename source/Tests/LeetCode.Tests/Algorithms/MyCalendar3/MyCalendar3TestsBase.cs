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
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.MyCalendar3;

public abstract class MyCalendar3TestsBase<T> where T : IMyCalendar3, new()
{
    private const string Book = "book";

    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Book_WithOverlappingEvents_ReturnsMaxConcurrentBookingsAfterEachEvent(string[] methods,
        int[][] arguments, int[] expectedResult)
    {
        // Arrange
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

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { "book", "book", "book", "book", "book", "book" },
            new[] { new[] { 10, 20 }, new[] { 50, 60 }, new[] { 10, 40 }, new[] { 5, 15 }, new[] { 5, 10 }, new[] { 25, 55 } },
            new[] { 1, 1, 2, 3, 3, 3 }
        ];
    }
}