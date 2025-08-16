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

using LeetCode.Algorithms.MaxDifferenceYouCanGetFromChangingAnInteger;

namespace LeetCode.Tests.Algorithms.MaxDifferenceYouCanGetFromChangingAnInteger;

public abstract class MaxDifferenceYouCanGetFromChangingAnIntegerTestsBase<T>
    where T : IMaxDifferenceYouCanGetFromChangingAnInteger, new()
{
    [TestMethod]
    [DataRow(9, 8)]
    [DataRow(555, 888)]
    [DataRow(10000, 80000)]
    [DataRow(123456, 820000)]
    public void MaxDiff_WithDigitReplacementsAppliedTwice_ReturnsMaximumDifferenceBetweenResults(int num,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDiff(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}