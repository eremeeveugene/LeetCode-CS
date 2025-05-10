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

using LeetCode.Algorithms.FindTargetIndicesAfterSortingArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTargetIndicesAfterSortingArray;

public abstract class FindTargetIndicesAfterSortingArrayTestsBase<T>
    where T : IFindTargetIndicesAfterSortingArray, new()
{
    [TestMethod]
    [DataRow("[1,2,5,2,3]", 2, "[1,2]")]
    [DataRow("[1,2,5,2,3]", 3, "[3]")]
    [DataRow("[1,2,5,2,3]", 5, "[4]")]
    public void TargetIndices_WithArrayAndTarget_ReturnsListOfTargetIndices(string numsJson, int target,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJson);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.TargetIndices(nums, target);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}