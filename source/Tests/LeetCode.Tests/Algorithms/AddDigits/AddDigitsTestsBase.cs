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

using LeetCode.Algorithms.AddDigits;

namespace LeetCode.Tests.Algorithms.AddDigits;

public abstract class AddDigitsTestsBase<T> where T : IAddDigits, new()
{
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(38, 2)]
    public void Test(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AddDigits(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}