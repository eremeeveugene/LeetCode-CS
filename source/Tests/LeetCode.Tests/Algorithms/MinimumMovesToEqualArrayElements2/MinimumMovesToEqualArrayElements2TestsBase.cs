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

using LeetCode.Algorithms.MinimumMovesToEqualArrayElements2;

namespace LeetCode.Tests.Algorithms.MinimumMovesToEqualArrayElements2;

public abstract class MinimumMovesToEqualArrayElements2TestsBase<T> where T : IMinimumMovesToEqualArrayElements2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, 2)]
    [DataRow(new[] { 1, 10, 2, 9 }, 16)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { -5 }, 0)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 0)]
    [DataRow(new[] { 1, 0, 0, 8, 6 }, 14)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 6)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 6)]
    [DataRow(new[] { -1, 0, 1 }, 2)]
    [DataRow(new[] { -3, -2, -1 }, 2)]
    [DataRow(new[] { 10, 20, 30 }, 20)]
    [DataRow(new[] { 1, 1, 1, 100 }, 99)]
    [DataRow(new[] { 100, 1, 1, 1 }, 99)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, 17)]
    [DataRow(new[] { 64, 12, 77, 3, 45 }, 126)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 18)]
    [DataRow(new[] { 7, -7, 7, -7 }, 28)]
    [DataRow(new[] { -10, 10 }, 20)]
    [DataRow(new[] { 5, 5, 5, 5, 5, 1 }, 4)]
    [DataRow(new[] { 1, 0, 0, 0, 0 }, 1)]
    [DataRow(new[] { 1, 1000000000 }, 999999999)]
    [DataRow(new[] { 1000000000, 1000000000 }, 0)]
    [DataRow(new[] { -1000000000, 1000000000 }, 2000000000)]
    [DataRow(new[] { -1000000000, 1000000000, 0 }, 2000000000)]
    [DataRow(new[] { -1000000000, 0, 147483647, 1000000000 }, 2147483647)]
    [DataRow(
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
            50,
            51,
            52,
            53,
            54,
            55,
            56,
            57,
            58,
            59,
            60,
            61,
            62,
            63,
            64,
            65,
            66,
            67,
            68,
            69,
            70,
            71,
            72,
            73,
            74,
            75,
            76,
            77,
            78,
            79,
            80,
            81,
            82,
            83,
            84,
            85,
            86,
            87,
            88,
            89,
            90,
            91,
            92,
            93,
            94,
            95,
            96,
            97,
            98,
            99,
            100
        },
        2500)]
    public void MinMoves2_WithNumsArray_ReturnsMinimumMovesToEqualArrayElements(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinMoves2(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}