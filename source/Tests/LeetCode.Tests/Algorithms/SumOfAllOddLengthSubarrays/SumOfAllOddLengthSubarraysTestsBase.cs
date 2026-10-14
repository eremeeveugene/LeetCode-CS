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

using LeetCode.Algorithms.SumOfAllOddLengthSubarrays;

namespace LeetCode.Tests.Algorithms.SumOfAllOddLengthSubarrays;

public abstract class SumOfAllOddLengthSubarraysTestsBase<T> where T : ISumOfAllOddLengthSubarrays, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2 }, 3)]
    [DataRow(new[] { 1, 4, 2, 5, 3 }, 58)]
    [DataRow(new[] { 10, 11, 12 }, 66)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 1000 }, 1000)]
    [DataRow(new[] { 1, 1, 1 }, 6)]
    [DataRow(new[] { 1, 2, 3, 4 }, 25)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 95)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 98)]
    [DataRow(new[] { 7, 0, 7 }, 28)]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60, 70 }, 1760)]
    [DataRow(new[] { 1000, 1000 }, 2000)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, 234)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18 }, 850)]
    [DataRow(new[] { 1, 1000, 1, 1000, 1 }, 8011)]
    [DataRow(new[] { 1, 38, 75, 112, 149, 186, 223, 260, 297, 334, 371, 408, 445, 482, 519, 556, 593, 630, 667, 704, 741, 778, 815, 852, 889, 926, 963, 1000, 37, 74, 111, 148, 185, 222, 259, 296, 333, 370, 407, 444, 481, 518, 555, 592, 629, 666, 703, 740, 777, 814, 851, 888, 925, 962, 999, 36, 73, 110, 147, 184, 221, 258, 295, 332, 369, 406, 443, 480, 517, 554, 591, 628, 665, 702, 739, 776, 813, 850, 887, 924, 961, 998, 35, 72, 109, 146, 183, 220, 257, 294, 331, 368, 405, 442, 479, 516, 553, 590, 627, 664 }, 43965125)]
    [DataRow(new[] { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 }, 85850000)]
    [DataRow(new[] { 4, 8 }, 12)]
    [DataRow(new[] { 9, 9, 9, 9, 9, 9, 9 }, 396)]
    [DataRow(new[] { 100, 1, 100, 1, 100, 1, 100, 1 }, 3030)]
    public void SumOddLengthSubarrays_WithIntegersArray_ReturnsSumOfAllOddLengthSubarrays(int[] arr, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumOddLengthSubarrays(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}