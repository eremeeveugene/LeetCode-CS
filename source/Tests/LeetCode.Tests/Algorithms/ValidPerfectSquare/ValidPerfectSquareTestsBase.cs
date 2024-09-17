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

using LeetCode.Algorithms.ValidPerfectSquare;

namespace LeetCode.Tests.Algorithms.ValidPerfectSquare;

public abstract class ValidPerfectSquareTestsBase<T> where T : IValidPerfectSquare, new()
{
    [TestMethod]
    [DataRow(16, true)]
    [DataRow(14, false)]
    [DataRow(2147483647, false)]
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