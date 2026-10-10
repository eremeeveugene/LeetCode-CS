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

using LeetCode.Algorithms.SplitTheArray;

namespace LeetCode.Tests.Algorithms.SplitTheArray;

public abstract class SplitTheArrayTestsBase<T> where T : ISplitTheArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 2, 2, 3, 4 }, true)]
    [DataRow(new[] { 1, 1, 1, 1 }, false)]
    [DataRow(new[] { 1, 2 }, true)]
    [DataRow(new[] { 1, 1 }, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, true)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, true)]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2 }, false)]
    [DataRow(new[] { 100, 100, 1, 1 }, true)]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5, 5, 5 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, true)]
    [DataRow(new[] { 3, 3, 3, 1 }, false)]
    [DataRow(new[] { 7, 7, 8, 8, 9, 9, 10, 10 }, true)]
    [DataRow(new[] { 2, 2, 2, 2, 3, 3 }, false)]
    [DataRow(new[] { 100, 99, 98, 100, 99, 98 }, true)]
    [DataRow(new[] { 1, 1, 1, 2, 3, 4, 5, 6 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 1 }, false)]
    [DataRow(new[] { 1, 1, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97 }, false)]
    [DataRow(new[] { 4, 4, 9, 9, 4, 4 }, false)]
    [DataRow(new[] { 10, 20, 30, 10, 20, 30, 40, 50 }, true)]
    public void IsPossibleToSplit_WithNumsArray_ReturnsTrueIfSplitIsValid(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsPossibleToSplit(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}