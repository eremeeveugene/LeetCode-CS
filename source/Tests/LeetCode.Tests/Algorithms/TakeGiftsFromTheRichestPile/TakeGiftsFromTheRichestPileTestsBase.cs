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

using LeetCode.Algorithms.TakeGiftsFromTheRichestPile;

namespace LeetCode.Tests.Algorithms.TakeGiftsFromTheRichestPile;

public abstract class TakeGiftsFromTheRichestPileTestsBase<T> where T : ITakeGiftsFromTheRichestPile, new()
{
    [TestMethod]
    [DataRow(new[] { 25, 64, 9, 4, 100 }, 4, 29L)]
    [DataRow(new[] { 1, 1, 1, 1 }, 4, 4L)]
    public void PickGifts_WithGiftArrayAndIterations_ReturnsTotalValueAfterKRemovals(int[] gifts, int k, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PickGifts(gifts, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}