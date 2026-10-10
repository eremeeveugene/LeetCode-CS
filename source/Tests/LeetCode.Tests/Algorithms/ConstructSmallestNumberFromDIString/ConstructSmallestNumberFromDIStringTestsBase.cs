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

using LeetCode.Algorithms.ConstructSmallestNumberFromDIString;

namespace LeetCode.Tests.Algorithms.ConstructSmallestNumberFromDIString;

public abstract class ConstructSmallestNumberFromDIStringTestsBase<T> where T : IConstructSmallestNumberFromDIString, new()
{
    [TestMethod]
    [DataRow("DDD", "4321")]
    [DataRow("IIIDIDDD", "123549876")]
    [DataRow("I", "12")]
    [DataRow("D", "21")]
    [DataRow("II", "123")]
    [DataRow("DD", "321")]
    [DataRow("ID", "132")]
    [DataRow("DI", "213")]
    [DataRow("IDI", "1324")]
    [DataRow("DID", "2143")]
    [DataRow("IIII", "12345")]
    [DataRow("DDDD", "54321")]
    [DataRow("IDID", "13254")]
    [DataRow("DIDI", "21435")]
    [DataRow("IIDD", "12543")]
    [DataRow("DDII", "32145")]
    [DataRow("IDDI", "14325")]
    [DataRow("DIID", "21354")]
    [DataRow("IIIIIIII", "123456789")]
    [DataRow("DDDDDDDD", "987654321")]
    [DataRow("IDIDIDID", "132547698")]
    [DataRow("DIDIDIDI", "214365879")]
    [DataRow("IIIDDD", "1237654")]
    public void SmallestNumber_WithGivenPattern_ReturnsLexicographicallySmallestPermutation(string pattern, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestNumber(pattern);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}