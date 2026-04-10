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

using LeetCode.Algorithms.CheckIfArrayIsSortedAndRotated;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CheckIfArrayIsSortedAndRotated;

public abstract class CheckIfArrayIsSortedAndRotatedTestsBase<T> where T : ICheckIfArrayIsSortedAndRotated, new()
{
    [TestMethod]
    [DataRow("[3,4,5,1,2]", true)]
    [DataRow("[2,1,3,4]", false)]
    [DataRow("[1,2,3]", true)]
    public void Check_GivenNums_ReturnsIfSortedOrRotated(string numsJson, bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.Check(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}