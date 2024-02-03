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

using LeetCode.Algorithms.BuildArrayFromPermutation;

namespace LeetCode.Tests.Algorithms.BuildArrayFromPermutation;

public abstract class BuildArrayFromPermutationTestsBase<T> where T : IBuildArrayFromPermutation, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 2, 1, 5, 3, 4 }, new[] { 0, 1, 2, 4, 5, 3 })]
    [DataRow(new[] { 5, 0, 1, 2, 3, 4 }, new[] { 4, 5, 0, 1, 2, 3 })]
    public void BuildArray_WithInputPermutation_ReturnsExpectedPermutationArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.BuildArray(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}