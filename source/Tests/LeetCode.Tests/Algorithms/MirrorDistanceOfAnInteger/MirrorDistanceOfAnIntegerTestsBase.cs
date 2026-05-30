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

using LeetCode.Algorithms.MirrorDistanceOfAnInteger;

namespace LeetCode.Tests.Algorithms.MirrorDistanceOfAnInteger;

public abstract class MirrorDistanceOfAnIntegerTestsBase<T> where T : IMirrorDistanceOfAnInteger, new()
{
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 0)]
    [DataRow(7, 0)]
    [DataRow(10, 9)]
    [DataRow(25, 27)]
    [DataRow(100, 99)]
    [DataRow(101, 0)]
    [DataRow(111, 0)]
    [DataRow(121, 0)]
    [DataRow(123, 198)]
    [DataRow(200, 198)]
    [DataRow(908, 99)]
    [DataRow(1000, 999)]
    [DataRow(1200, 1179)]
    [DataRow(1331, 0)]
    [DataRow(2222, 0)]
    [DataRow(4567, 3087)]
    [DataRow(1000000000, 999999999)]
    public void MirrorDistance_WithGivenInteger_ReturnsAbsoluteDifferenceBetweenNumberAndReversedDigits(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MirrorDistance(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}