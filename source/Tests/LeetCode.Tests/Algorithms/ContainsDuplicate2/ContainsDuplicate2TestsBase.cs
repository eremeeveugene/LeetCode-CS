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

using LeetCode.Algorithms.ContainsDuplicate2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ContainsDuplicate2;

public abstract class ContainsDuplicate2TestsBase<T> where T : IContainsDuplicate2, new()
{
    [TestMethod]
    [DataRow("[1, 2, 3, 1]", 3, true)]
    [DataRow("[1, 0, 1, 1]", 1, true)]
    [DataRow("[1, 2, 3, 1, 2, 3]", 2, false)]
    public void ContainsNearbyDuplicate_WithGivenRange_ChecksForDuplicatesWithinRange(string numsJsonArray, int k,
        bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ContainsNearbyDuplicate(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}