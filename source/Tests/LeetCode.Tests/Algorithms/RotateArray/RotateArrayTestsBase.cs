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

using LeetCode.Algorithms.RotateArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RotateArray;

public abstract class RotateArrayTestsBase<T> where T : IRotateArray, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4,5,6,7]", 3, "[5,6,7,1,2,3,4]")]
    [DataRow("[-1,-100,3,99]", 2, "[3,99,-1,-100]")]
    [DataRow("[1]", 1, "[1]")]
    [DataRow("[1]", 100, "[1]")]
    [DataRow("[1]", 100_000, "[1]")]
    public void Rotate_WithNumsArrayAndKSteps_ShiftsElementsRightByKSteps(string numsJson, int k,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        solution.Rotate(nums, k);

        var actualResult = nums;

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}