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

namespace LeetCode.Tests.Algorithms.NumberOfStudentsUnableToEatLunch;

public abstract class NumberOfStudentsUnableToEatLunchTestsBase<T> where T : INumberOfStudentsUnableToEatLunch, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 0, 0 }, new[] { 0, 1, 0, 1 }, 0)]
    [DataRow(new[] { 1, 1, 1, 0, 0, 1 }, new[] { 1, 0, 0, 0, 1, 1 }, 3)]
    public void CountStudents_WithStudentsAndSandwichesArray_ReturnsUnsatisfiedStudentsCount(int[] students,
        int[] sandwiches, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountStudents(students, sandwiches);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}