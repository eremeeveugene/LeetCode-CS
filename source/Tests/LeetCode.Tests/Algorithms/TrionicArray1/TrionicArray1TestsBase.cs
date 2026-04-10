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

using LeetCode.Algorithms.TrionicArray1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TrionicArray1;

public abstract class TrionicArray1TestsBase<T> where T : ITrionicArray1, new()
{
    [TestMethod]
    [DataRow("[1,3,5,4,2,6]", true)]
    [DataRow("[2,1,3]", false)]
    public void IsTrionic_WithNumsArray_ReturnsTrueIfTrionic(string numsJson, bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.IsTrionic(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}