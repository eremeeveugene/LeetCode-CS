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

using LeetCode.Algorithms.PrimeSubtractionOperation;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.PrimeSubtractionOperation;

public abstract class PrimeSubtractionOperationTestsBase<T> where T : IPrimeSubtractionOperation, new()
{
    [TestMethod]
    [DataRow("[4,9,6,10]", true)]
    [DataRow("[6,8,11,12]", true)]
    [DataRow("[5,8,3]", false)]
    public void PrimeSubOperation_WithInputArray_ReturnsTrueIfPrimeSubsequencePossible(string numsJson,
        bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.PrimeSubOperation(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}