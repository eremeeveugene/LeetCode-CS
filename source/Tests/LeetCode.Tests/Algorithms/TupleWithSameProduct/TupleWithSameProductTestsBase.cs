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

using LeetCode.Algorithms.TupleWithSameProduct;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.TupleWithSameProduct;

public abstract class TupleWithSameProductTestsBase<T> where T : ITupleWithSameProduct, new()
{
    [TestMethod]
    [DataRow("[2,3,4,6]", 8)]
    [DataRow("[1,2,4,5,10]", 16)]
    [DataRow("[2,3,4,6,8,12]", 40)]
    public void TupleSameProduct_GivenArrayOfNumbers_ReturnsTupleCount(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.TupleSameProduct(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}