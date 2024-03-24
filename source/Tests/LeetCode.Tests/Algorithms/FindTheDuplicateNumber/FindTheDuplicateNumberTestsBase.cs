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

using LeetCode.Algorithms.FindTheDuplicateNumber;

namespace LeetCode.Tests.Algorithms.FindTheDuplicateNumber;

public abstract class FindTheDuplicateNumberTestsBase<T> where T : IFindTheDuplicateNumber, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 4, 2, 2 }, 2)]
    [DataRow(new[] { 3, 1, 3, 4, 2 }, 3)]
    [DataRow(new[] { 3, 3, 3, 3, 3 }, 3)]
    public void FindDuplicate_GivenArray_ReturnsFirstDuplicate(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDuplicate(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}