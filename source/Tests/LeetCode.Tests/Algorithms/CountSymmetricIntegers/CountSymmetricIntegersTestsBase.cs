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
    [DataRow(1, 1, 0)]
    [DataRow(11, 11, 1)]
    [DataRow(10, 10, 0)]
    [DataRow(1, 10, 0)]
    [DataRow(1, 99, 9)]
    [DataRow(100, 1000, 0)]
    [DataRow(1000, 1000, 0)]
    [DataRow(1001, 1001, 1)]
    [DataRow(1010, 1010, 1)]
    [DataRow(1, 10000, 624)]
    [DataRow(9999, 9999, 1)]
    [DataRow(10000, 10000, 0)]
    [DataRow(1234, 1234, 0)]
    [DataRow(1230, 1260, 1)]
    [DataRow(5000, 5100, 6)]
    [DataRow(1, 1000, 9)]
    [DataRow(2000, 3000, 69)]
    [DataRow(9000, 10000, 55)]
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