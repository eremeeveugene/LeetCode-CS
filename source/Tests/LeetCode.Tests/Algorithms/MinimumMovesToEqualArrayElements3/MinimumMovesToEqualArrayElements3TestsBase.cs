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

using LeetCode.Algorithms.MinimumMovesToEqualArrayElements3;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumMovesToEqualArrayElements3;

public abstract class MinimumMovesToEqualArrayElements3TestsBase<T> where T : IMinimumMovesToEqualArrayElements3, new()
{
    [TestMethod]
    [DataRow("[2,1,3]", 3)]
    [DataRow("[4,4,5]", 2)]
    public void MinMoves_WithNumsArray_ReturnsMinimumMovesToEqualArrayElements(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinMoves(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}