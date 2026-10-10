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

using LeetCode.Algorithms.HappyNumber;

namespace LeetCode.Tests.Algorithms.HappyNumber;

public abstract class HappyNumberTestsBase<T> where T : IHappyNumber, new()
{
    [TestMethod]
    [DataRow(1, true)]
    [DataRow(2, false)]
    [DataRow(3, false)]
    [DataRow(7, true)]
    [DataRow(19, true)]
    [DataRow(4, false)]
    [DataRow(10, true)]
    [DataRow(13, true)]
    [DataRow(20, false)]
    [DataRow(23, true)]
    [DataRow(28, true)]
    [DataRow(31, true)]
    [DataRow(32, true)]
    [DataRow(44, true)]
    [DataRow(49, true)]
    [DataRow(68, true)]
    [DataRow(70, true)]
    [DataRow(100, true)]
    [DataRow(1111111, true)]
    [DataRow(999999999, false)]
    [DataRow(2147483647, false)]
    [DataRow(2147483646, false)]
    [DataRow(1000000000, true)]
    [DataRow(89, false)]
    [DataRow(145, false)]
    public void IsHappy_WithPositiveInteger_ReturnsTrueIfNumberEventuallyReachesOneOtherwiseFalse(int s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsHappy(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}