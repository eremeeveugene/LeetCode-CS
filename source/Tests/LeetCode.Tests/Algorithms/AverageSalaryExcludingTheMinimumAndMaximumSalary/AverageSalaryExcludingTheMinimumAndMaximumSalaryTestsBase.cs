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

using LeetCode.Algorithms.AverageSalaryExcludingTheMinimumAndMaximumSalary;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.AverageSalaryExcludingTheMinimumAndMaximumSalary;

public abstract class AverageSalaryExcludingTheMinimumAndMaximumSalaryTestsBase<T>
    where T : IAverageSalaryExcludingTheMinimumAndMaximumSalary, new()
{
    [TestMethod]
    [DataRow("[4000,3000,1000,2000]", 2500.00000)]
    [DataRow("[1000,2000,3000]", 2000.00000)]
    public void Average_WithSalaryArray_ComputesCorrectAverage(string salaryJson, double expectedResult)
    {
        // Arrange
        var salary = JsonHelper<int>.DeserializeToArray(salaryJson);

        var solution = new T();

        // Act
        var actualResult = solution.Average(salary);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}