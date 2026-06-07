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

using LeetCode.Algorithms.MakeTwoArraysEqualByReversingSubarrays;

namespace LeetCode.Tests.Algorithms.MakeTwoArraysEqualByReversingSubarrays;

public abstract class MakeTwoArraysEqualByReversingSubarraysTestsBase<T> where T : IMakeTwoArraysEqualByReversingSubarrays, new()
{
    [TestMethod]
    [DataRow(new[] { 7 }, new[] { 7 }, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 2, 4, 1, 3 }, true)]
    [DataRow(new[] { 3, 7, 9 }, new[] { 3, 7, 11 }, false)]
    [DataRow(new[] { 1 }, new[] { 2 }, false)]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 }, true)]
    [DataRow(new[] { 1, 2 }, new[] { 2, 1 }, true)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, true)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 4 }, false)]
    [DataRow(new[] { 5, 5, 5 }, new[] { 5, 5, 5 }, true)]
    [DataRow(new[] { 1, 2, 2, 3 }, new[] { 2, 1, 3, 2 }, true)]
    [DataRow(new[] { 1, 2, 2, 3 }, new[] { 1, 2, 3, 3 }, false)]
    [DataRow(new[] { 10, 20, 30 }, new[] { 30, 10, 20 }, true)]
    [DataRow(new[] { 1, 1, 2 }, new[] { 2, 1, 1 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 }, true)]
    [DataRow(new[] { 100, 200 }, new[] { 100, 201 }, false)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, true)]
    [DataRow(new[] { 4, 4 }, new[] { 4, 5 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 2 }, false)]
    [DataRow(new[] { 3, 3, 3, 3 }, new[] { 3, 3, 3, 3 }, true)]
    public void CanBeEqual_GivenTargetAndArray_ReturnsIfTheyCanBeEqual(int[] target, int[] arr, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanBeEqual(target, arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}