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

using LeetCode.Algorithms.TwoOutOfThree;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TwoOutOfThree;

public abstract class TwoOutOfThreeTestsBase<T> where T : ITwoOutOfThree, new()
{
    [TestMethod]
    [DataRow("[1,1,3,2]", "[2,3]", "[3]", "[3,2]")]
    [DataRow("[3,1]", "[2,3]", "[1,2]", "[2,3,1]")]
    [DataRow("[1,2,2]", "[4,3,3]", "[5]", "[]")]
    public void TwoOutOfThree_WithThreeIntegerArrays_ReturnsValuesPresentInAtLeastTwoArrays(string nums1Json,
        string nums2Json, string nums3Json, string expectedResultJson)
    {
        // Arrange
        var nums1 = JsonHelper<int[]>.Parse(nums1Json);
        var nums2 = JsonHelper<int[]>.Parse(nums2Json);
        var nums3 = JsonHelper<int[]>.Parse(nums3Json);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.TwoOutOfThree(nums1, nums2, nums3);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult.ToList());
    }
}