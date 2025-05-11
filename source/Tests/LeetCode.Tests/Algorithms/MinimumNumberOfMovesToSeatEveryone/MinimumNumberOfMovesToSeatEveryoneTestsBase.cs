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

using LeetCode.Algorithms.MinimumNumberOfMovesToSeatEveryone;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfMovesToSeatEveryone;

public abstract class MinimumNumberOfMovesToSeatEveryoneTestsBase<T>
    where T : IMinimumNumberOfMovesToSeatEveryone, new()
{
    [TestMethod]
    [DataRow("[3,1,5]", "[2,7,4]", 4)]
    [DataRow("[4,1,5,9]", "[1,3,2,6]", 7)]
    [DataRow("[2,2,6,6]", "[1,3,2,6]", 4)]
    public void MinMovesToSeat_WithSeatAndStudentPositions_ReturnsMinimumTotalMovesToAssignSeats(string seatsJson,
        string studentsJson, int expectedResult)
    {
        // Arrange
        var seats = JsonHelper<int>.DeserializeToArray(seatsJson);
        var students = JsonHelper<int>.DeserializeToArray(studentsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinMovesToSeat(seats, students);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}