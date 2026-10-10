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

using LeetCode.Algorithms.AverageSalaryExcludingTheMinimumAndMaximumSalary;

namespace LeetCode.Tests.Algorithms.AverageSalaryExcludingTheMinimumAndMaximumSalary;

public abstract class AverageSalaryExcludingTheMinimumAndMaximumSalaryTestsBase<T> where T : IAverageSalaryExcludingTheMinimumAndMaximumSalary, new()
{
    [TestMethod]
    [DataRow(new[] { 4000, 3000, 1000, 2000 }, 2500.00000)]
    [DataRow(new[] { 1000, 2000, 3000 }, 2000.00000)]
    [DataRow(new[] { 1000, 1500, 2000 }, 1500.0)]
    [DataRow(new[] { 5000, 1000, 3000 }, 3000.0)]
    [DataRow(new[] { 1000, 2000, 3000, 4000, 5000 }, 3000.0)]
    [DataRow(new[] { 5000, 4000, 3000, 2000, 1000 }, 3000.0)]
    [DataRow(new[] { 1000, 2000, 3000, 4000 }, 2500.0)]
    [DataRow(new[] { 1000, 2000, 4000, 5000 }, 3000.0)]
    [DataRow(new[] { 1000, 2000, 2500, 3000 }, 2250.0)]
    [DataRow(new[] { 1000, 3000, 4000, 10000 }, 3500.0)]
    [DataRow(new[] { 1000, 1001, 1002 }, 1001.0)]
    [DataRow(new[] { 1000, 1001, 1002, 1003 }, 1001.5)]
    [DataRow(new[] { 1000, 1000000, 500000 }, 500000.0)]
    [DataRow(new[] { 1000, 1000000, 500000, 600000 }, 550000.0)]
    [DataRow(new[] { 2000, 4000, 6000, 8000, 10000, 12000 }, 7000.0)]
    [DataRow(new[] { 100000, 200000, 300000, 400000, 500000 }, 300000.0)]
    [DataRow(new[] { 1000, 1002, 1004, 1006, 1008 }, 1004.0)]
    [DataRow(new[] { 999999, 1000000, 1000, 2000 }, 500999.5)]
    [DataRow(new[] { 7000, 3000, 5000, 1000, 9000, 11000, 13000 }, 7000.0)]
    [DataRow(new[] { 8000, 9000, 2000, 3000, 6000, 1000 }, 4750.0)]
    public void Average_WithSalaryArray_ComputesCorrectAverage(int[] salary, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Average(salary);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}