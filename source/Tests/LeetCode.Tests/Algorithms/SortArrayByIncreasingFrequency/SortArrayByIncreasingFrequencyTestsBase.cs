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

using LeetCode.Algorithms.SortArrayByIncreasingFrequency;

namespace LeetCode.Tests.Algorithms.SortArrayByIncreasingFrequency;

public abstract class SortArrayByIncreasingFrequencyTestsBase<T> where T : ISortArrayByIncreasingFrequency, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2, 2, 2, 3 }, new[] { 3, 1, 1, 2, 2, 2 })]
    [DataRow(new[] { 2, 3, 1, 3, 2 }, new[] { 1, 3, 3, 2, 2 })]
    [DataRow(new[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 }, new[] { 5, -1, 4, 4, -6, -6, 1, 1, 1 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { -100 }, new[] { -100 })]
    [DataRow(new[] { 100 }, new[] { 100 })]
    [DataRow(new[] { 5, 5, 5 }, new[] { 5, 5, 5 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 3, 2, 1 })]
    [DataRow(new[] { 1, 1, 2, 2 }, new[] { 2, 2, 1, 1 })]
    [DataRow(new[] { -1, -1, -2, -2, -3 }, new[] { -3, -1, -1, -2, -2 })]
    [DataRow(new[] { 100, -100, 100, -100, 0 }, new[] { 0, 100, 100, -100, -100 })]
    [DataRow(new[] { 4, 4, 4, 3, 3, 2, 1 }, new[] { 2, 1, 3, 3, 4, 4, 4 })]
    [DataRow(new[] { 0, 0, 0, 0, 1, 1, 1, 2, 2, 3 }, new[] { 3, 2, 2, 1, 1, 1, 0, 0, 0, 0 })]
    [DataRow(new[] { 9, 8, 7, 9, 8, 9 }, new[] { 7, 8, 8, 9, 9, 9 })]
    [DataRow(new[] { -5, -5, -5, -4, -4, -3 }, new[] { -3, -4, -4, -5, -5, -5 })]
    [DataRow(new[] { 2, 2, 3, 3, 1, 1, 4 }, new[] { 4, 3, 3, 2, 2, 1, 1 })]
    [DataRow(new[] { 100, 100, 100, 100, 100, -100, -100, -100, 0 }, new[] { 0, -100, -100, -100, 100, 100, 100, 100, 100 })]
    [DataRow(new[] { 10, 20, 20, 30, 30, 30, 40, 40, 40, 40 }, new[] { 10, 20, 20, 30, 30, 30, 40, 40, 40, 40 })]
    [DataRow(new[] { -82, -21, 11, -37, 14, -25, -35, 100, 43, -76, 90, 26, -53, 19, 33, -68, 100, 83, -83, 82, -7, 86, -58, 4, 86, 80, 17, 63, 29, -93, 35, -72, -2, -66, -6, -94, -98, 81, -48, 78, 19, 57, -48, 71, -19, 54, 23, -22, -49, -26, -83, -49, 93, -18, 70, -10, 3, -81, -21, -78, 3, -31, -96, 56, -70, -11, 21, 54, 6, -86, 67, 1, 43, 80, -75, 89, 54, 9, -20, 22, -5, -7, 84, -45, -53, -99, -20, -21, -97, -28, 21, -18, 49, 90, 17, -14, -92, 55, 32, 61 }, new[] { 93, 89, 84, 83, 82, 81, 78, 71, 70, 67, 63, 61, 57, 56, 55, 49, 35, 33, 32, 29, 26, 23, 22, 14, 11, 9, 6, 4, 1, -2, -5, -6, -10, -11, -14, -19, -22, -25, -26, -28, -31, -35, -37, -45, -58, -66, -68, -70, -72, -75, -76, -78, -81, -82, -86, -92, -93, -94, -96, -97, -98, -99, 100, 100, 90, 90, 86, 86, 80, 80, 43, 43, 21, 21, 19, 19, 17, 17, 3, 3, -7, -7, -18, -18, -20, -20, -48, -48, -49, -49, -53, -53, -83, -83, 54, 54, 54, -21, -21, -21 })]
    public void FrequencySort_GivenNumsArray_ReturnsArraySortedByFrequency(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FrequencySort(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}