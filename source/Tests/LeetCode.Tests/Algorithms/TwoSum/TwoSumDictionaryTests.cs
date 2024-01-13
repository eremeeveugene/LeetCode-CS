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

using LeetCode.Algorithms.TwoSum;

namespace LeetCode.Tests.Algorithms.TwoSum;

[TestClass]
public class TwoSumDictionaryTests
{
    [TestMethod]
    [DataRow(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [DataRow(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [DataRow(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [DataRow(new[] { 2, 5, 5, 11 }, 10, new[] { 1, 2 })]
    public void TwoSumDictionary_GetResult_WithNumberArrayAndTarget_ReturnsIndicesForTargetSum(int[] nums, int target,
        int[] expectedResult)
    {
        // Act
        var actualResult = TwoSumDictionary.GetResult(nums, target);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}