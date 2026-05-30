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

using LeetCode.Algorithms.FirstUniqueEvenElement;

namespace LeetCode.Tests.Algorithms.FirstUniqueEvenElement;

public abstract class FirstUniqueEvenElementTestsBase<T> where T : IFirstUniqueEvenElement, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 4, 2, 5, 4, 6 }, 2)]
    [DataRow(new[] { 4, 4 }, -1)]
    public void FirstUniqueEven_WithGivenArray_ReturnsFirstEvenAppearingOnceOrMinusOne(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FirstUniqueEven(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}