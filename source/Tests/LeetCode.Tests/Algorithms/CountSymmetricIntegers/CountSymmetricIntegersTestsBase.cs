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

using LeetCode.Algorithms.CountSymmetricIntegers;

namespace LeetCode.Tests.Algorithms.CountSymmetricIntegers;

public abstract class CountSymmetricIntegersTestsBase<T> where T : ICountSymmetricIntegers, new()
{
    [TestMethod]
    [DataRow(1, 100, 9)]
    [DataRow(1200, 1230, 4)]
    public void CountSymmetricIntegers_GivenRange_ReturnsCountOfSymmetricIntegers(int low, int high, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSymmetricIntegers(low, high);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}