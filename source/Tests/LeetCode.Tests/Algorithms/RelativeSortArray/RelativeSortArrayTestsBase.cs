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

using LeetCode.Algorithms.RelativeSortArray;

namespace LeetCode.Tests.Algorithms.RelativeSortArray;

public abstract class RelativeSortArrayTestsBase<T> where T : IRelativeSortArray, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new[] { 2, 1, 4, 3, 9, 6 }, new[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 })]
    [DataRow(new[] { 28, 6, 22, 8, 44, 17 }, new[] { 22, 28, 8, 6 }, new[] { 22, 28, 8, 6, 17, 44 })]
    [DataRow(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 1000 }, new[] { 1000 }, new[] { 1000 })]
    [DataRow(new[] { 5, 5, 5 }, new[] { 5 }, new[] { 5, 5, 5 })]
    [DataRow(new[] { 3, 1, 2 }, new[] { 2 }, new[] { 2, 1, 3 })]
    [DataRow(new[] { 3, 1, 2 }, new[] { 3, 2, 1 }, new[] { 3, 2, 1 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, new[] { 3, 2, 1 })]
    [DataRow(new[] { 0, 1000, 0, 1000 }, new[] { 1000, 0 }, new[] { 1000, 1000, 0, 0 })]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, new[] { 5 }, new[] { 5, 6, 7, 8, 9 })]
    [DataRow(new[] { 4, 4, 3, 3, 2, 2, 1, 1 }, new[] { 2, 4 }, new[] { 2, 2, 4, 4, 1, 1, 3, 3 })]
    [DataRow(new[] { 1000, 999, 998, 0, 1, 2 }, new[] { 0, 1000 }, new[] { 0, 1000, 1, 2, 998, 999 })]
    [DataRow(new[] { 7, 3, 7, 3, 7, 1 }, new[] { 3 }, new[] { 3, 3, 1, 7, 7, 7 })]
    [DataRow(new[] { 10, 20, 30, 40, 50 }, new[] { 50, 40, 30, 20, 10 }, new[] { 50, 40, 30, 20, 10 })]
    [DataRow(new[] { 2, 2, 2, 1, 1, 3 }, new[] { 3, 1 }, new[] { 3, 1, 1, 2, 2, 2 })]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, new[] { 1 }, new[] { 1, 1, 1, 1, 1 })]
    [DataRow(new[] { 0, 0, 5, 5, 9, 9 }, new[] { 9, 5 }, new[] { 9, 9, 5, 5, 0, 0 })]
    [DataRow(new[] { 100, 50, 100, 50, 25 }, new[] { 50 }, new[] { 50, 50, 25, 100, 100 })]
    [DataRow(new[] { 6, 4, 2, 0, 8, 10 }, new[] { 10, 0 }, new[] { 10, 0, 2, 4, 6, 8 })]
    public void RelativeSortArray_WithReferenceOrderArray_SortsArr1AccordingToArr2AndAppendsRemainingInAscendingOrder(
        int[] arr1,
        int[] arr2,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RelativeSortArray(arr1, arr2);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void RelativeSortArray_WithMaxLengthArray_SortsArr1AccordingToArr2AndAppendsRemainingInAscendingOrder()
    {
        // Arrange
        var solution = new T();

        var arr1 = new int[1000];
        var expectedResult = new int[1000];

        for (var i = 0; i < arr1.Length; i++)
        {
            arr1[i] = 1000 - i;
            expectedResult[i] = i;
        }

        expectedResult[0] = 1000;

        // Act
        var actualResult = solution.RelativeSortArray(arr1, [1000]);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}