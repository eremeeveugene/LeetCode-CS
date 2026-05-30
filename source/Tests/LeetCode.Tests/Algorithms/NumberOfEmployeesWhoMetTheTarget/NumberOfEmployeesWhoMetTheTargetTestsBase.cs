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

using LeetCode.Algorithms.NumberOfEmployeesWhoMetTheTarget;

namespace LeetCode.Tests.Algorithms.NumberOfEmployeesWhoMetTheTarget;

public abstract class NumberOfEmployeesWhoMetTheTargetTestsBase<T> where T : INumberOfEmployeesWhoMetTheTarget, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 2, 3, 4 }, 2, 3)]
    [DataRow(new[] { 5, 1, 4, 2, 2 }, 6, 0)]
    [DataRow(new int[] { }, 3, 0)]
    [DataRow(new[] { 0, 0, 0 }, 0, 3)]
    [DataRow(new[] { 1, 2, 3 }, 1, 3)]
    [DataRow(new[] { 1, 2, 3 }, 4, 0)]
    [DataRow(new[] { 10, 10, 10 }, 10, 3)]
    [DataRow(new[] { 9, 10, 11 }, 10, 2)]
    [DataRow(new[] { 2, 2, 2, 2 }, 2, 4)]
    [DataRow(new[] { 100 }, 50, 1)]
    [DataRow(new[] { 49 }, 50, 0)]
    public void NumberOfEmployeesWhoMetTarget_WithEmployeeHoursAndTarget_ReturnsCountOfEmployeesMeetingTarget(int[] hours, int target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfEmployeesWhoMetTarget(hours, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}