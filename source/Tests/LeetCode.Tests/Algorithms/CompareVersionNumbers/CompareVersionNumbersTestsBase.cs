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

using LeetCode.Algorithms.CompareVersionNumbers;

namespace LeetCode.Tests.Algorithms.CompareVersionNumbers;

public abstract class CompareVersionNumbersTestsBase<T> where T : ICompareVersionNumbers, new()
{
    [TestMethod]
    [DataRow("0", "0", 0)]
    [DataRow("1.01", "1.001", 0)]
    [DataRow("1.0", "1.0.0", 0)]
    [DataRow("0.1", "1.1", -1)]
    [DataRow("6", "003479002", -1)]
    [DataRow("4", "4.969.3.863.960.99661.8.085.769.0.735662509.75003", -1)]
    [DataRow("306.9.0.0", "3.0691430.7.7.263.005.2.1.6.606.702.7.076519166.507", 1)]
    [DataRow("30307.038",
        "30307.038.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0.0",
        0)]
    public void CompareVersion_WithVersionStrings_ReturnsExpectedComparisonResult(string version1, string version2,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CompareVersion(version1, version2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}