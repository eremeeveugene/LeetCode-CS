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

using LeetCode.Algorithms.CheckIfArrayIsGood;

namespace LeetCode.Tests.Algorithms.CheckIfArrayIsGood;

public abstract class CheckIfArrayIsGoodTestsBase<T> where T : ICheckIfArrayIsGood, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 3 }, false)]
    [DataRow(new[] { 1, 3, 3, 2 }, true)]
    [DataRow(new[] { 1, 1 }, true)]
    [DataRow(new[] { 3, 4, 4, 1, 2, 1 }, false)]
    [DataRow(new[] { 1 }, false)]
    [DataRow(new[] { 2, 2 }, false)]
    [DataRow(new[] { 1, 2 }, false)]
    [DataRow(new[] { 2, 1, 2 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 4 }, true)]
    [DataRow(new[] { 4, 2, 1, 4, 3 }, true)]
    [DataRow(new[] { 5, 1, 4, 2, 3, 5 }, true)]
    [DataRow(new[] { 1, 3, 3, 3 }, false)]
    [DataRow(new[] { 1, 2, 4, 4, 4 }, false)]
    [DataRow(new[] { 1, 2, 2, 4, 4 }, false)]
    [DataRow(new[] { 1, 2, 3, 4 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, false)]
    [DataRow(new[] { 1, 2, 3, 3, 3 }, false)]
    [DataRow(new[] { 1, 1, 1 }, false)]
    [DataRow(new[] { 1, 1, 2, 2 }, false)]
    [DataRow(new[] { 1, 2, 2, 3, 3 }, false)]
    [DataRow(new[] { 1, 2, 3, 3, 4, 4 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 4, 5, 5 }, false)]
    [DataRow(new[] { 1, 2, 3, 5, 5 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 20 }, true)]
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
            64
        },
        true)]
    public void IsGood_WithGivenNums_ReturnsTrueForValidBasePermutation(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsGood(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}