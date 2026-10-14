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

using LeetCode.Algorithms.MaxDifferenceYouCanGetFromChangingAnInteger;

namespace LeetCode.Tests.Algorithms.MaxDifferenceYouCanGetFromChangingAnInteger;

public abstract class MaxDifferenceYouCanGetFromChangingAnIntegerTestsBase<T> where T : IMaxDifferenceYouCanGetFromChangingAnInteger, new()
{
    [TestMethod]
    [DataRow(9, 8)]
    [DataRow(555, 888)]
    [DataRow(10000, 80000)]
    [DataRow(123456, 820000)]
    [DataRow(1, 8)]
    [DataRow(2, 8)]
    [DataRow(5, 8)]
    [DataRow(10, 80)]
    [DataRow(11, 88)]
    [DataRow(19, 89)]
    [DataRow(90, 89)]
    [DataRow(99, 88)]
    [DataRow(100, 800)]
    [DataRow(101, 808)]
    [DataRow(111, 888)]
    [DataRow(191, 898)]
    [DataRow(1000, 8000)]
    [DataRow(1090, 8090)]
    [DataRow(2019, 8000)]
    [DataRow(9009, 8998)]
    [DataRow(9999, 8888)]
    [DataRow(12345, 82000)]
    [DataRow(100000, 800000)]
    [DataRow(987654, 810000)]
    [DataRow(11111111, 88888888)]
    [DataRow(10000000, 80000000)]
    [DataRow(99999999, 88888888)]
    [DataRow(100000000, 800000000)]
    [DataRow(90000009, 89999998)]
    [DataRow(29, 80)]
    [DataRow(92, 87)]
    [DataRow(1001, 8008)]
    [DataRow(96860991, 83030880)]
    [DataRow(50116789, 80000000)]
    [DataRow(21183414, 80000000)]
    [DataRow(67541354, 80000000)]
    public void MaxDiff_WithDigitReplacementsAppliedTwice_ReturnsMaximumDifferenceBetweenResults(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDiff(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}