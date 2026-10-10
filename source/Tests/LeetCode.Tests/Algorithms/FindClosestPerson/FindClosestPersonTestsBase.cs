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

using LeetCode.Algorithms.FindClosestPerson;

namespace LeetCode.Tests.Algorithms.FindClosestPerson;

public abstract class FindClosestPersonTestsBase<T> where T : IFindClosestPerson, new()
{
    [TestMethod]
    [DataRow(2, 7, 4, 1)]
    [DataRow(2, 5, 6, 2)]
    [DataRow(1, 5, 3, 0)]
    [DataRow(1, 100, 50, 1)]
    [DataRow(1, 2, 3, 2)]
    [DataRow(3, 2, 1, 2)]
    [DataRow(10, 20, 15, 0)]
    [DataRow(100, 1, 99, 1)]
    [DataRow(50, 50, 50, 0)]
    [DataRow(7, 7, 1, 0)]
    [DataRow(1, 100, 1, 1)]
    [DataRow(1, 100, 100, 2)]
    [DataRow(20, 10, 14, 2)]
    [DataRow(30, 40, 36, 2)]
    [DataRow(5, 15, 10, 0)]
    [DataRow(60, 80, 71, 2)]
    [DataRow(99, 100, 1, 1)]
    [DataRow(2, 4, 3, 0)]
    [DataRow(8, 1, 5, 1)]
    [DataRow(1, 3, 100, 2)]
    public void FindClosest_WithThreeIntegers_ReturnsIndexOfClosestToTarget(int x, int y, int z, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindClosest(x, y, z);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}