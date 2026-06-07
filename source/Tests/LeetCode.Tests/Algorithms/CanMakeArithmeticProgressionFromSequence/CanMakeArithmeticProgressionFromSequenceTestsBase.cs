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

using LeetCode.Algorithms.CanMakeArithmeticProgressionFromSequence;

namespace LeetCode.Tests.Algorithms.CanMakeArithmeticProgressionFromSequence;

public abstract class CanMakeArithmeticProgressionFromSequenceTestsBase<T> where T : ICanMakeArithmeticProgressionFromSequence, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 5, 1 }, true)]
    [DataRow(new[] { 1, 2, 4 }, false)]
    [DataRow(new[] { 1, 2 }, true)]
    [DataRow(new[] { 5, 5 }, true)]
    [DataRow(new[] { 1, 1, 1 }, true)]
    [DataRow(new[] { 0, 0, 0 }, true)]
    [DataRow(new[] { -1, 0, 1 }, true)]
    [DataRow(new[] { -3, -1, 1, 3 }, true)]
    [DataRow(new[] { 10, 5, 0 }, true)]
    [DataRow(new[] { 2, 4, 6, 8 }, true)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, true)]
    [DataRow(new[] { 1, 2, 3, 5 }, false)]
    [DataRow(new[] { 5, 5, 5, 5 }, true)]
    [DataRow(new[] { -5, -10, -15 }, true)]
    [DataRow(new[] { 100, 50, 0, -50 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 6 }, false)]
    [DataRow(new[] { 0, 1, 2 }, true)]
    [DataRow(new[] { 3, 3, 3 }, true)]
    public void CanMakeArithmeticProgression_GivenArray_ReturnsWhetherArithmeticProgressionIsPossible(int[] arr, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanMakeArithmeticProgression(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}