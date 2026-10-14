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
    [DataRow(new[] { 1 }, 1, 1L)]
    [DataRow(new[] { 2 }, 1, 1L)]
    [DataRow(new[] { 4 }, 1, 2L)]
    [DataRow(new[] { 1000000000 }, 1, 31622L)]
    [DataRow(new[] { 1000000000 }, 2, 177L)]
    [DataRow(new[] { 1000000000 }, 1000, 1L)]
    [DataRow(new[] { 4, 9, 16 }, 3, 9L)]
    [DataRow(new[] { 4, 9, 16 }, 1, 17L)]
    [DataRow(new[] { 5, 5, 5 }, 2, 9L)]
    [DataRow(new[] { 100, 1 }, 5, 2L)]
    [DataRow(new[] { 3, 3 }, 1000, 2L)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 4, 31L)]
    [DataRow(new[] { 10, 10, 10, 10 }, 6, 8L)]
    [DataRow(new[] { 999999999, 1000000000 }, 3, 31799L)]
    [DataRow(new[] { 2, 3, 5, 7, 11, 13 }, 10, 6L)]
    [DataRow(new[] { 65536, 256, 16 }, 4, 36L)]
    [DataRow(new[] { 1000000000, 1000000000, 1000000000 }, 7, 367L)]
    [DataRow(new[] { 8, 15, 24, 35, 48, 63, 80 }, 5, 53L)]
    [DynamicData(nameof(GetLargeTestData))]
    public void PickGifts_WithGiftArrayAndIterations_ReturnsTotalValueAfterKRemovals(int[] gifts, int k, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PickGifts(gifts, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [BuildGifts(1000, 1000000000, 0), 1000, 31622000L];

        yield return [BuildGifts(1000, 1000000000, 1), 1000, 31622000L];

        yield return [BuildGifts(1000, 1000000000, 1000000), 500, 125263632656L];

        yield return [BuildGifts(1000, 1000000000, 7), 1000, 31622000L];
    }

    private static int[] BuildGifts(int length, int start, int step)
    {
        var gifts = new int[length];

        for (var i = 0; i < length; i++)
        {
            gifts[i] = start - (i * step);
        }

        return gifts;
    }
}