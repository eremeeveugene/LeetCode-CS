// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FindScoreOfAnArrayAfterMarkingAllElements;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindScoreOfAnArrayAfterMarkingAllElements;

public abstract class FindScoreOfAnArrayAfterMarkingAllElements1<T>
    where T : IFindScoreOfAnArrayAfterMarkingAllElements, new()
{
    [TestMethod]
    [DataRow("[2,1,3,4,5,2]", 7)]
    [DataRow("[2,3,5,1,3,2]", 5)]
    public void FindScore_WithIntegerArray_ReturnsScore(string numsJsonArray, long expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindScore(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}