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

using LeetCode.Algorithms.ValidPerfectSquare;

namespace LeetCode.Tests.Algorithms.ValidPerfectSquare;

public abstract class ValidPerfectSquareTestsBase<T> where T : IValidPerfectSquare, new()
{
    [TestMethod]
    [DataRow(16, true)]
    [DataRow(14, false)]
    [DataRow(int.MaxValue, false)]
    [DataRow(1, true)]
    [DataRow(2, false)]
    [DataRow(3, false)]
    [DataRow(4, true)]
    [DataRow(9, true)]
    [DataRow(25, true)]
    [DataRow(36, true)]
    [DataRow(100, true)]
    [DataRow(121, true)]
    [DataRow(808201, true)]
    [DataRow(1000000, true)]
    [DataRow(2147395600, true)]
    [DataRow(2147395599, false)]
    [DataRow(2147302921, true)]
    [DataRow(2147483646, false)]
    [DataRow(99999999, false)]
    [DataRow(65536, true)]
    public void IsPerfectSquare_GivenNumber_ReturnsWhetherNumberIsPerfectSquare(int num, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsPerfectSquare(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}