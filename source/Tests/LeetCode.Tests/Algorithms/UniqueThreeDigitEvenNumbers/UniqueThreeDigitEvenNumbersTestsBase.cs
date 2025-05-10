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

using LeetCode.Algorithms.UniqueThreeDigitEvenNumbers;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.UniqueThreeDigitEvenNumbers;

public abstract class UniqueThreeDigitEvenNumbersTestsBase<T> where T : IUniqueThreeDigitEvenNumbers, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4]", 12)]
    [DataRow("[0,2,2]", 2)]
    [DataRow("[6,6,6]", 1)]
    [DataRow("[1,3,5]", 0)]
    public void TotalNumbers_WithGivenDigitsArray_ReturnsUniqueThreeDigitEvenNumbers(string digitsJson,
        int expectedResult)
    {
        // Arrange
        var digits = JsonHelper<int>.DeserializeToArray(digitsJson);

        var solution = new T();

        // Act
        var actualResult = solution.TotalNumbers(digits);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}