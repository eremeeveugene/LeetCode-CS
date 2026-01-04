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

using LeetCode.Algorithms.CheckIfAnyElementHasPrimeFrequency;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CheckIfAnyElementHasPrimeFrequency;

public abstract class CheckIfAnyElementHasPrimeFrequencyTestsBase<T>
    where T : ICheckIfAnyElementHasPrimeFrequency, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4,5,4]", true)]
    [DataRow("[1,2,3,4,5]", false)]
    [DataRow("[2,2,2,4,4]", true)]
    public void CheckPrimeFrequency_WithIntegerArray_ReturnsTrueIfAnyElementHasPrimeFrequency(string numsJson,
        bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CheckPrimeFrequency(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}