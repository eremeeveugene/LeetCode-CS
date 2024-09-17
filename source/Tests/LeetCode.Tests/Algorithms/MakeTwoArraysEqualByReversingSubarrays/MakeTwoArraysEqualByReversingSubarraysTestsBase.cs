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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MakeTwoArraysEqualByReversingSubarrays;

public abstract class MakeTwoArraysEqualByReversingSubarraysTestsBase<T>
    where T : IMakeTwoArraysEqualByReversingSubarrays, new()
{
    [TestMethod]
    [DataRow("[7]", "[7]", true)]
    [DataRow("[1,2,3,4]", "[2,4,1,3]", true)]
    [DataRow("[3,7,9]", "[3,7,11]", false)]
    public void CanBeEqual_GivenTargetAndArray_ReturnsIfTheyCanBeEqual(string targetJsonArray, string arrJsonArray,
        bool expectedResult)
    {
        // Arrange
        var target = JsonHelper<int>.DeserializeToArray(targetJsonArray);
        var arr = JsonHelper<int>.DeserializeToArray(arrJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CanBeEqual(target, arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}