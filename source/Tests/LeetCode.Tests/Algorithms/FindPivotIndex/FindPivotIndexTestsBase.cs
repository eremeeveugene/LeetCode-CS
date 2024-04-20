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

using LeetCode.Algorithms.FindPivotIndex;

namespace LeetCode.Tests.Algorithms.FindPivotIndex;

public abstract class FindPivotIndexTestsBase<T> where T : IFindPivotIndex, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, -1, 8, 4 }, 3)]
    [DataRow(new[] { 1, -1, 4 }, 2)]
    [DataRow(new[] { 2, 5 }, -1)]
    public void PivotIndex_GivenArray_ReturnsExpectedIndexOrMinusOne(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PivotIndex(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}