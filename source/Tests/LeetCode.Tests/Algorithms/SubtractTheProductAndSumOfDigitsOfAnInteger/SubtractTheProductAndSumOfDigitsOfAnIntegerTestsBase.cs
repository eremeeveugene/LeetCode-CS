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

using LeetCode.Algorithms.SubtractTheProductAndSumOfDigitsOfAnInteger;

namespace LeetCode.Tests.Algorithms.SubtractTheProductAndSumOfDigitsOfAnInteger;

public abstract class SubtractTheProductAndSumOfDigitsOfAnIntegerTestsBase<T>
    where T : ISubtractTheProductAndSumOfDigitsOfAnInteger, new()
{
    [TestMethod]
    [DataRow(234, 15)]
    [DataRow(4421, 21)]
    public void SubtractProductAndSum_WithSpecificInputs_ReturnsExpectedDifference(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SubtractProductAndSum(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}