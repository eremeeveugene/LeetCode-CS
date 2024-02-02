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

using LeetCode.Algorithms.MinimumSumOfFourDigitNumberAfterSplittingDigits;

namespace LeetCode.Tests.Algorithms.MinimumSumOfFourDigitNumberAfterSplittingDigits;

public abstract class MinimumSumOfFourDigitNumberAfterSplittingDigitsTestsBase<T>
    where T : IMinimumSumOfFourDigitNumberAfterSplittingDigits, new()
{
    [TestMethod]
    [DataRow(2932, 52)]
    [DataRow(4009, 13)]
    public void MinimumSum_WithNumericInput_ReturnsExpectedMinimizedSum(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumSum(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}