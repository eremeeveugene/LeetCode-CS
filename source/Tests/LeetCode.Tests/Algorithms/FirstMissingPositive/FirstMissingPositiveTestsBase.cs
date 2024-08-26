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

using LeetCode.Algorithms.FirstMissingPositive;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FirstMissingPositive;

public abstract class FirstMissingPositiveTestsBase<T> where T : IFirstMissingPositive, new()
{
    [TestMethod]
    [DataRow("[]", 1)]
    [DataRow("[1, 2, 0]", 3)]
    [DataRow("[3, 4, -1, 1]", 2)]
    [DataRow("[7, 8, 9, 11, 12]", 1)]
    [DataRow("[1, 2, 3]", 4)]
    [DataRow("[-1, -2, -3]", 1)]
    [DataRow("[0]", 1)]
    [DataRow("[2, 3, 4]", 1)]
    [DataRow("[1]", 2)]
    [DataRow("[5, 3, 2, 1, 4]", 6)]
    [DataRow("[0, 2, 2, 1, 1]", 3)]
    [DataRow("[1, 1, 0, -1, -2]", 2)]
    public void FirstMissingPositive_GivenArray_ReturnsFirstMissingPositiveInteger(string numsJsonArray,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FirstMissingPositive(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}