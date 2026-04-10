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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ProductOfArrayExceptSelf;

public abstract class ProductOfArrayExceptSelfTestsBase<T> where T : IProductOfArrayExceptSelf, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4]", "[24,12,8,6]")]
    [DataRow("[-1,1,0,-3,3]", "[0,0,9,0,0]")]
    public void ProductExceptSelf_WithIntegerArray_ReturnsArrayWithProductsExcludingCurrentIndex(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ProductExceptSelf(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}