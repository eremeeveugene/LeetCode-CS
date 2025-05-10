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

using LeetCode.Algorithms.MyCalendar3;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MyCalendar3;

public abstract class MyCalendar3TestsBase<T> where T : IMyCalendar3Factory, new()
{
    private const string Book = "book";


    ////[TestMethod]
    ////[DataRow("[\"book\", \"book\", \"book\", \"book\", \"book\", \"book\"]",
    ////    "[[10, 20], [50, 60], [10, 40], [5, 15], [5, 10], [25, 55]]", "[1, 1, 2, 3, 3, 3]")]
    ////public void Test(int k, string expectedResultJson)
    ////{
    ////    // Arrange
    ////    var expectedResult = JsonHelper<string>.DeserializeToArray(expectedResultJson);

    ////    var solutionFactory = new T();
    ////    var solution = solutionFactory.Create(k);

    ////    // Act
    ////    var actualResult = new List<object>
    ////    {
    ////        solution.InsertLast(1),
    ////        solution.InsertLast(2),
    ////        solution.InsertFront(3),
    ////        solution.InsertFront(4),
    ////        solution.GetRear(),
    ////        solution.IsFull(),
    ////        solution.DeleteLast(),
    ////        solution.InsertFront(4),
    ////        solution.GetFront()
    ////    };

    ////    // Assert
    ////    CollectionAssert.AreEqual(expectedResult, actualResult.Select(r => r.ToString()?.ToLower()).ToArray());
    ////}
}