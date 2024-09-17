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

using LeetCode.Algorithms.NumberOfStudentsUnableToEatLunch;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NumberOfStudentsUnableToEatLunch;

public abstract class NumberOfStudentsUnableToEatLunchTestsBase<T> where T : INumberOfStudentsUnableToEatLunch, new()
{
    [TestMethod]
    [DataRow("[1,1,0,0]", "[0,1,0,1]", 0)]
    [DataRow("[1,1,1,0,0,1]", "[1,0,0,0,1,1]", 3)]
    public void CountStudents_WithStudentsAndSandwichesArray_ReturnsUnsatisfiedStudentsCount(string studentsJsonArray,
        string sandwichesJsonArray, int expectedResult)
    {
        // Arrange
        var students = JsonHelper<int>.DeserializeToArray(studentsJsonArray);
        var sandwiches = JsonHelper<int>.DeserializeToArray(sandwichesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CountStudents(students, sandwiches);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}