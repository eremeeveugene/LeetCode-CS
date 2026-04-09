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

using LeetCode.Algorithms.NRepeatedElementInSize2NArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NRepeatedElementInSize2NArray;

public abstract class NRepeatedElementInSize2NArrayTestsBase<T> where T : INRepeatedElementInSize2NArray, new()
{
    [TestMethod]
    [DataRow("[1,2,3,3]", 3)]
    [DataRow("[2,1,2,5,3,2]", 2)]
    [DataRow("[5,1,5,2,5,3,5,4]", 5)]
    public void RepeatedNTimes_WithArrayContainingOneElementRepeatedNTimes_ReturnsRepeatedElement(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.RepeatedNTimes(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}