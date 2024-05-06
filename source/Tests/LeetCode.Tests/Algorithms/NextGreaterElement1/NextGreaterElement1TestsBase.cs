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

using LeetCode.Algorithms.NextGreaterElement1;

namespace LeetCode.Tests.Algorithms.NextGreaterElement1;

public abstract class NextGreaterElement1TestsBase<T> where T : INextGreaterElement1, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 1, 2 }, new[] { 1, 3, 4, 2 }, new[] { -1, 3, -1 })]
    [DataRow(new[] { 2, 4 }, new[] { 1, 2, 3, 4 }, new[] { 3, -1 })]
    public void NextGreaterElement_GivenNums1AndNums2_ReturnsExpectedArray(int[] nums1, int[] nums2,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NextGreaterElement(nums1, nums2);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}