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

using LeetCode.Algorithms.LexicographicallySmallestStringAfterApplyingOperations;

namespace LeetCode.Tests.Algorithms.LexicographicallySmallestStringAfterApplyingOperations;

public abstract class LexicographicallySmallestStringAfterApplyingOperationsTestsBase<T>
    where T : ILexicographicallySmallestStringAfterApplyingOperations, new()
{
    [TestMethod]
    [DataRow("5525", 9, 2, "2050")]
    [DataRow("74", 5, 1, "24")]
    [DataRow("0011", 4, 2, "0011")]
    [DataRow("35", 9, 1, "00")]
    [DataRow("0246", 1, 2, "0044")]
    [DataRow("00", 5, 1, "00")]
    [DataRow("12", 3, 1, "00")]
    [DataRow("8080", 3, 3, "0000")]
    [DataRow("1234", 2, 2, "1032")]
    [DataRow("4321", 3, 3, "0022")]
    [DataRow("5555", 5, 2, "5050")]
    [DataRow("0000", 7, 3, "0000")]
    [DataRow("9999", 1, 1, "0000")]
    [DataRow("1357", 4, 2, "1155")]
    [DataRow("2468", 9, 3, "0044")]
    [DataRow("123456", 5, 2, "123456")]
    [DataRow("987654", 7, 4, "509472")]
    [DataRow("11", 1, 1, "00")]
    [DataRow("56", 8, 1, "01")]
    [DataRow("3141", 6, 3, "0191")]
    [DataRow("27", 2, 1, "01")]
    [DataRow("8765", 8, 2, "6183")]
    [DataRow("102030", 3, 4, "102030")]
    [DataRow("000111", 9, 5, "000111")]
    [DataRow("9090", 5, 2, "9090")]
    public void FindLexSmallestString_GivenDigitStringAndAddAndRotateValues_ReturnsLexicographicallySmallestString(
        string s,
        int a,
        int b,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindLexSmallestString(s, a, b);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}