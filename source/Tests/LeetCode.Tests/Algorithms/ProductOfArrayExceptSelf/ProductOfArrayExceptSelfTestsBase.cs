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

using LeetCode.Algorithms.ProductOfArrayExceptSelf;

namespace LeetCode.Tests.Algorithms.ProductOfArrayExceptSelf;

public abstract class ProductOfArrayExceptSelfTestsBase<T> where T : IProductOfArrayExceptSelf, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [DataRow(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    [DataRow(new[] { 1, 2 }, new[] { 2, 1 })]
    [DataRow(new[] { 2, 3 }, new[] { 3, 2 })]
    [DataRow(new[] { 0, 0 }, new[] { 0, 0 })]
    [DataRow(new[] { 0, 5 }, new[] { 5, 0 })]
    [DataRow(new[] { 5, 0 }, new[] { 0, 5 })]
    [DataRow(new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 })]
    [DataRow(new[] { -1, -1 }, new[] { -1, -1 })]
    [DataRow(new[] { -2, 3, -4 }, new[] { -12, 8, -6 })]
    [DataRow(new[] { 0, 0, 3 }, new[] { 0, 0, 0 })]
    [DataRow(new[] { 7, 0, 2, 0 }, new[] { 0, 0, 0, 0 })]
    [DataRow(new[] { 1, 0, 3, 4 }, new[] { 0, 12, 0, 0 })]
    [DataRow(new[] { -1, 0, -1 }, new[] { 0, 1, 0 })]
    [DataRow(new[] { 10, -10, 10 }, new[] { -100, 100, -100 })]
    [DataRow(new[] { 2, 2, 2, 2, 2 }, new[] { 16, 16, 16, 16, 16 })]
    [DataRow(new[] { 30, 1, -1 }, new[] { -1, -30, 30 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 720, 360, 240, 180, 144, 120 })]
    [DataRow(new[] { 0, 1, -1, 2 }, new[] { -2, 0, 0, 0 })]
    [DataRow(new[] { -5, 5 }, new[] { 5, -5 })]
    [DataRow(new[] { 100, 100, 100, 100 }, new[] { 1000000, 1000000, 1000000, 1000000 })]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1, 1, 1, 1 })]
    [DataRow(new[] { -1, -1, -1, -1, -1, -1, -1 }, new[] { 1, 1, 1, 1, 1, 1, 1 })]
    [DataRow(new[] { 3, -3, 3, -3, 3 }, new[] { 81, -81, 81, -81, 81 })]
    public void ProductExceptSelf_WithIntegerArray_ReturnsArrayWithProductsExcludingCurrentIndex(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ProductExceptSelf(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void ProductExceptSelf_WithMaxLengthArrayOfOnes_ReturnsArrayOfOnes()
    {
        // Arrange
        var solution = new T();

        var nums = new int[100000];
        var expectedResult = new int[100000];

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = 1;
            expectedResult[i] = 1;
        }

        // Act
        var actualResult = solution.ProductExceptSelf(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void ProductExceptSelf_WithMaxLengthArrayOfNegativeOnes_ReturnsArrayOfNegativeOnes()
    {
        // Arrange
        var solution = new T();

        var nums = new int[100000];
        var expectedResult = new int[100000];

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = -1;
            expectedResult[i] = -1;
        }

        // Act
        var actualResult = solution.ProductExceptSelf(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void ProductExceptSelf_WithMaxLengthArrayContainingSingleZero_ReturnsOnlyOneNonZeroValue()
    {
        // Arrange
        var solution = new T();

        var nums = new int[100000];
        var expectedResult = new int[100000];

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = 1;
        }

        nums[50000] = 0;
        expectedResult[50000] = 1;

        // Act
        var actualResult = solution.ProductExceptSelf(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}