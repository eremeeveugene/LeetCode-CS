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

using LeetCode.Algorithms.ThreeConsecutiveOdds;

namespace LeetCode.Tests.Algorithms.ThreeConsecutiveOdds;

public abstract class ThreeConsecutiveOddsTestsBase<T> where T : IThreeConsecutiveOdds, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 6, 4, 1 }, false)]
    [DataRow(new[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 }, true)]
    [DataRow(new[] { 1 }, false)]
    [DataRow(new[] { 2 }, false)]
    [DataRow(new[] { 1, 3 }, false)]
    [DataRow(new[] { 1, 3, 5 }, true)]
    [DataRow(new[] { 2, 1, 3, 5 }, true)]
    [DataRow(new[] { 1, 3, 2, 5, 7 }, false)]
    [DataRow(new[] { 1, 3, 2, 5, 7, 9 }, true)]
    [DataRow(new[] { 2, 4, 6, 8 }, false)]
    [DataRow(new[] { 1, 1, 1 }, true)]
    [DataRow(new[] { 999, 1000, 999, 1000, 999 }, false)]
    [DataRow(new[] { 1000, 999, 997, 995 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, false)]
    [DataRow(new[] { 2, 1, 3, 4, 5, 7, 9 }, true)]
    [DataRow(new[] { 3, 5, 7, 2 }, true)]
    [DataRow(new[] { 2, 3, 5, 7 }, true)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2, 1, 3 }, false)]
    [DataRow(new[] { 11, 13, 14, 15, 17, 19, 21 }, true)]
    [DataRow(new[] { 1000, 1000, 1000 }, false)]
    [DynamicData(nameof(GetLargeTestData))]
    public void ThreeConsecutiveOdds_WithIntegerArray_ReturnsTrueIfThreeConsecutiveOddsExist(int[] arr, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ThreeConsecutiveOdds(arr);

        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [BuildAlternating(1000, 1), false];

        yield return [BuildAlternating(1000, 0), false];

        yield return [BuildAllOdd(1000), true];
    }

    private static int[] BuildAlternating(int length, int firstValue)
    {
        var arr = new int[length];

        for (var i = 0; i < length; i++)
        {
            arr[i] = (i + firstValue) % 2 == 0 ? 2 : 1;
        }

        return arr;
    }

    private static int[] BuildAllOdd(int length)
    {
        var arr = new int[length];

        for (var i = 0; i < length; i++)
        {
            arr[i] = 999;
        }

        return arr;
    }
}