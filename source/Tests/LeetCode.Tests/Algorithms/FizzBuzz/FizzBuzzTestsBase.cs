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

using LeetCode.Algorithms.FizzBuzz;

namespace LeetCode.Tests.Algorithms.FizzBuzz;

public abstract class FizzBuzzTestsBase<T> where T : IFizzBuzz, new()
{
    [TestMethod]
    [DataRow(3, new[] { "1", "2", "Fizz" })]
    [DataRow(5, new[] { "1", "2", "Fizz", "4", "Buzz" })]
    [DataRow(15,
        new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuzz_WithPositiveIntegerN_ReturnsSequenceWithFizzBuzzRulesApplied(int n, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FizzBuzz(n).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}