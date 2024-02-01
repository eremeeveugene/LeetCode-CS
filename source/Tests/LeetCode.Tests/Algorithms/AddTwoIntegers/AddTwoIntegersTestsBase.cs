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

using LeetCode.Algorithms.AddTwoIntegers;

namespace LeetCode.Tests.Algorithms.AddTwoIntegers;

public abstract class AddTwoIntegersTestsBase<T> where T : IAddTwoIntegers, new()
{
    [TestMethod]
    [DataRow(12, 5, 17)]
    [DataRow(-10, 4, -6)]
    public void Sum_WhenCalledWithVariousNumbers_ReturnsExpectedSum(int num1, int num2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Sum(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}