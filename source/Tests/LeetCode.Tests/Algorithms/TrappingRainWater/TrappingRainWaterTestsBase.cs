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

using LeetCode.Algorithms.TrappingRainWater;

namespace LeetCode.Tests.Algorithms.TrappingRainWater;

public abstract class TrappingRainWaterTestsBase<T> where T : ITrappingRainWater, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    [DataRow(new[] { 4, 2, 0, 3, 2, 5 }, 9)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 5 }, 0)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 3, 0, 3 }, 3)]
    [DataRow(new[] { 3, 0, 0, 3 }, 6)]
    [DataRow(new[] { 0, 5, 0 }, 0)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 5, 1, 5, 1, 5 }, 8)]
    [DataRow(new[] { 2, 0, 2 }, 2)]
    [DataRow(new[] { 3, 0, 1, 0, 3 }, 8)]
    [DataRow(new[] { 4, 2, 3 }, 1)]
    [DataRow(new[] { 0, 7, 1, 4, 6 }, 7)]
    [DataRow(new[] { 6, 4, 2, 0, 3, 2, 0, 3, 1, 4, 5, 3, 2, 7, 5, 3, 0, 1, 2, 1, 3, 4, 6, 8, 1, 3 }, 83)]
    [DataRow(new[] { 100000, 0, 100000 }, 100000)]
    [DataRow(new[] { 1, 0, 2, 0, 1, 0, 3, 0, 1, 0, 2, 0, 1 }, 12)]
    [DynamicData(nameof(GetLargeTestData))]
    public void Trap_WithHeightArray_ReturnsTrappedWaterAmount(int[] height, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Trap(height);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [BuildHeights(20000, 0), 1999800000];

        yield return [BuildHeights(20000, 1), 985050];

        yield return [BuildHeights(20000, 2), 499900005];

        yield return [BuildHeights(20000, 3), 0];
    }

    private static int[] BuildHeights(int length, int shape)
    {
        var height = new int[length];

        for (var i = 0; i < length; i++)
        {
            switch (shape)
            {
                case 0:
                    height[i] = i == 0 || i == length - 1 ? 100000 : 0;

                    break;
                case 1:
                    height[i] = i % 100;

                    break;
                case 2:
                    height[i] = Math.Abs((length / 2) - i) * 5;

                    break;
                default:
                    height[i] = 100000;

                    break;
            }
        }

        return height;
    }
}