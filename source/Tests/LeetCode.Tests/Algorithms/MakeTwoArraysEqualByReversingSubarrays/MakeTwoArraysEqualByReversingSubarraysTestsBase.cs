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

using LeetCode.Algorithms.MakeTwoArraysEqualByReversingSubarrays;

namespace LeetCode.Tests.Algorithms.MakeTwoArraysEqualByReversingSubarrays;

public abstract class MakeTwoArraysEqualByReversingSubarraysTestsBase<T>
    where T : IMakeTwoArraysEqualByReversingSubarrays, new()
{
    [TestMethod]
    [DataRow(new[] { 7 }, new[] { 7 }, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 2, 4, 1, 3 }, true)]
    [DataRow(new[] { 3, 7, 9 }, new[] { 3, 7, 11 }, false)]
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