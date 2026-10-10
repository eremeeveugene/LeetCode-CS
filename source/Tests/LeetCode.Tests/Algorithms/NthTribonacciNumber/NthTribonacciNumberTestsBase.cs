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

using LeetCode.Algorithms.NthTribonacciNumber;

namespace LeetCode.Tests.Algorithms.NthTribonacciNumber;

public abstract class NthTribonacciNumberTestsBase<T> where T : INthTribonacciNumber, new()
{
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(4, 4)]
    [DataRow(25, 1389537)]
    [DataRow(5, 7)]
    [DataRow(6, 13)]
    [DataRow(7, 24)]
    [DataRow(8, 44)]
    [DataRow(9, 81)]
    [DataRow(10, 149)]
    [DataRow(11, 274)]
    [DataRow(12, 504)]
    [DataRow(15, 3136)]
    [DataRow(18, 19513)]
    [DataRow(20, 66012)]
    [DataRow(22, 223317)]
    [DataRow(28, 8646064)]
    [DataRow(30, 29249425)]
    [DataRow(33, 181997601)]
    [DataRow(35, 615693474)]
    [DataRow(36, 1132436852)]
    [DataRow(37, 2082876103)]
    public void Tribonacci_WithIndexN_ReturnsNthTribonacciNumber(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Tribonacci(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}