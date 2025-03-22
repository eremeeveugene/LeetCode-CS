// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MaximumDifferenceBetweenEvenAndOddFrequency1;

namespace LeetCode.Tests.Algorithms.MaximumDifferenceBetweenEvenAndOddFrequency1;

public abstract class MaximumDifferenceBetweenEvenAndOddFrequency1TestsBase<T>
    where T : IMaximumDifferenceBetweenEvenAndOddFrequency1, new()
{
    [TestMethod]
    [DataRow("aaaaabbc", 3)]
    [DataRow("abcabcab", 1)]
    public void MaxDifference_WithGivenString_ReturnMaximumDifferenceBetweenEvenAndOddFrequency(string s,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDifference(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}