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

using LeetCode.Algorithms.MaximumDifferenceByRemappingDigit;

namespace LeetCode.Tests.Algorithms.MaximumDifferenceByRemappingDigit;

public abstract class MaximumDifferenceByRemappingDigitTestsBase<T> where T : IMaximumDifferenceByRemappingDigit, new()
{
    [TestMethod]
    [DataRow(11891, 99009)]
    [DataRow(90, 99)]
    public void MinMaxDifference_WithDigitRemapping_ReturnsDifferenceBetweenMaxAndMin(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinMaxDifference(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}