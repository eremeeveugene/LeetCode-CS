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

using LeetCode.Algorithms.FindSumOfArrayProductOfMagicalSequences;

namespace LeetCode.Tests.Algorithms.FindSumOfArrayProductOfMagicalSequences;

public abstract class FindSumOfArrayProductOfMagicalSequencesTestsBase<T> where T : IFindSumOfArrayProductOfMagicalSequences, new()
{
    [TestMethod]
    [DataRow(5, 5, new[] { 1, 10, 100, 10000, 1000000 }, 991600007)]
    [DataRow(2, 2, new[] { 5, 4, 3, 2, 1 }, 170)]
    [DataRow(1, 1, new[] { 28 }, 28)]
    [DataRow(1, 1, new[] { 1, 2, 3 }, 6)]
    [DataRow(2, 1, new[] { 3 }, 9)]
    [DataRow(2, 1, new[] { 2, 3 }, 13)]
    [DataRow(3, 1, new[] { 2, 3 }, 36)]
    [DataRow(3, 2, new[] { 1, 1, 1 }, 15)]
    [DataRow(3, 3, new[] { 1, 1, 1 }, 6)]
    [DataRow(4, 1, new[] { 1, 1, 1, 1 }, 28)]
    [DataRow(4, 2, new[] { 2, 3, 5, 7 }, 30062)]
    [DataRow(5, 3, new[] { 1, 2, 3, 4, 5, 6 }, 1556450)]
    [DataRow(6, 2, new[] { 7 }, 117649)]
    [DataRow(6, 2, new[] { 3, 1 }, 1405)]
    [DataRow(7, 3, new[] { 1, 2, 3, 4 }, 4008658)]
    [DataRow(10, 1, new[] { 2, 3, 4 }, 148891680)]
    [DataRow(10, 4, new[] { 100000000, 99999999, 12345678 }, 468649303)]
    [DataRow(12, 5, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 737580478)]
    [DataRow(15, 7, new[] { 31, 41, 59, 26, 53, 58, 97, 93, 23, 84 }, 323157391)]
    [DataRow(20, 10, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, 782754435)]
    [DataRow(30, 1, new[] { 1, 1 }, 435)]
    [DataRow(30, 4, new[] { 100000000, 100000000, 100000000, 100000000, 100000000 }, 272777468)]
    [DataRow(
        25,
        12,
        new[]
        {
            8,
            15,
            34,
            71,
            132,
            223,
            350,
            519,
            736,
            1007,
            1338,
            1735,
            2204,
            2751,
            3382,
            4103,
            4920,
            5839,
            6866,
            8007,
            9268,
            10655,
            12174,
            13831,
            15632,
            17583,
            19690,
            21959,
            24396,
            27007,
            29798,
            32775,
            35944,
            39311,
            42882,
            46663,
            50660,
            54879,
            59326,
            64007
        },
        643217199)]
    [DataRow(
        30,
        15,
        new[]
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31,
            32,
            33,
            34,
            35,
            36,
            37,
            38,
            39,
            40,
            41,
            42,
            43,
            44,
            45,
            46,
            47,
            48,
            49,
            50
        },
        512639461)]
    [DataRow(
        30,
        30,
        new[]
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31,
            32,
            33,
            34,
            35,
            36,
            37,
            38,
            39,
            40,
            41,
            42,
            43,
            44,
            45,
            46,
            47,
            48,
            49,
            50
        },
        179289557)]
    public void MagicalSum_WithMKAndNums_ReturnsSumOfArrayProductsOfMagicalSequences(int m, int k, int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MagicalSum(m, k, nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}