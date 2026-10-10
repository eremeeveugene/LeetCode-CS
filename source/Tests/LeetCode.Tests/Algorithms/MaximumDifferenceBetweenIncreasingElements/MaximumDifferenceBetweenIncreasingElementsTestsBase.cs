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

using LeetCode.Algorithms.MaximumDifferenceBetweenIncreasingElements;

namespace LeetCode.Tests.Algorithms.MaximumDifferenceBetweenIncreasingElements;

public abstract class MaximumDifferenceBetweenIncreasingElementsTestsBase<T> where T : IMaximumDifferenceBetweenIncreasingElements, new()
{
    [TestMethod]
    [DataRow(new[] { 7, 1, 5, 4 }, 4)]
    [DataRow(new[] { 9, 4, 3, 2 }, -1)]
    [DataRow(new[] { 1, 5, 2, 10 }, 9)]
    [DataRow(
        new[]
        {
            999,
            997,
            980,
            976,
            948,
            940,
            938,
            928,
            924,
            917,
            907,
            907,
            881,
            878,
            864,
            862,
            859,
            857,
            848,
            840,
            824,
            824,
            824,
            805,
            802,
            798,
            788,
            777,
            775,
            766,
            755,
            748,
            735,
            732,
            727,
            705,
            700,
            697,
            693,
            679,
            676,
            644,
            634,
            624,
            599,
            596,
            588,
            583,
            562,
            558,
            553,
            539,
            537,
            536,
            509,
            491,
            485,
            483,
            454,
            449,
            438,
            425,
            403,
            368,
            345,
            327,
            287,
            285,
            270,
            263,
            255,
            248,
            235,
            234,
            224,
            221,
            201,
            189,
            187,
            183,
            179,
            168,
            155,
            153,
            150,
            144,
            107,
            102,
            102,
            87,
            80,
            57,
            55,
            49,
            48,
            45,
            26,
            26,
            23,
            15
        },
        -1)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, -1)]
    [DataRow(new[] { 5, 5 }, -1)]
    [DataRow(new[] { 1, 1000000000 }, 999999999)]
    [DataRow(new[] { 1000000000, 1 }, -1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, -1)]
    [DataRow(new[] { 3, 3, 3, 3 }, -1)]
    [DataRow(new[] { 10, 1, 2, 3, 100, 1 }, 99)]
    [DataRow(new[] { 8, 2, 4, 1, 9, 3 }, 8)]
    [DataRow(new[] { 1, 5, 1, 5, 1, 5 }, 4)]
    [DataRow(new[] { 100, 90, 80, 85 }, 5)]
    [DataRow(new[] { 4, 9, 2, 7, 1, 8 }, 7)]
    [DataRow(new[] { 1000000000, 999999999, 1000000000 }, 1)]
    [DataRow(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [DataRow(new[] { 2, 2, 1, 1, 3, 3 }, 2)]
    [DataRow(new[] { 6, 1, 6, 1, 7, 2, 8 }, 7)]
    public void MaximumDifference_WithValidIncreasingPairs_ReturnsMaximumDifference(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumDifference(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}