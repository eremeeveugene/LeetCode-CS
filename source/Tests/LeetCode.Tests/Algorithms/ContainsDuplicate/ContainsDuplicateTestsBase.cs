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

using LeetCode.Algorithms.ContainsDuplicate;

namespace LeetCode.Tests.Algorithms.ContainsDuplicate;

public abstract class ContainsDuplicateTestsBase<T> where T : IContainsDuplicate, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 1 }, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, false)]
    [DataRow(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    [DataRow(new[] { 1 }, false)]
    [DataRow(new[] { 1, 1 }, true)]
    [DataRow(new[] { 1, 2 }, false)]
    [DataRow(new[] { 2, 2, 2 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, false)]
    [DataRow(new[] { 5, 4, 3, 2, 1, 5 }, true)]
    [DataRow(new[] { 0, 0 }, true)]
    [DataRow(new[] { -1, -2, -3, -1 }, true)]
    [DataRow(new[] { 1000000000, -1000000000 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 }, true)]
    [DataRow(new[] { 0 }, false)]
    [DataRow(new[] { -1, 0, 1, 0, -1 }, true)]
    [DataRow(new[] { 9, 9, 9, 9, 9 }, true)]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60 }, false)]
    [DataRow(new[] { 3, 1, 2, 3 }, true)]
    [DataRow(new[] { 4, 3, 2, 1, 0, -1, -2 }, false)]
    public void ContainsDuplicate_GivenArray_ReturnsTrueIfDuplicatesExist(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ContainsDuplicate(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}