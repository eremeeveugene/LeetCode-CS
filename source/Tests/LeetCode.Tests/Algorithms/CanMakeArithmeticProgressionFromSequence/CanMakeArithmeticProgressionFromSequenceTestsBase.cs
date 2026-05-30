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