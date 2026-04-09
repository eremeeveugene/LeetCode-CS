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

using LeetCode.Algorithms.ConstructTheMinimumBitwiseArray2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ConstructTheMinimumBitwiseArray2;

public abstract class ConstructTheMinimumBitwiseArray2TestsBase<T> where T : IConstructTheMinimumBitwiseArray2, new()
{
    [TestMethod]
    [DataRow("[2,3,5,7]", "[-1,1,4,3]")]
    [DataRow("[11,13,31]", "[9,12,15]")]
    public void MinBitwiseArray_WithPrimeInputs_ConstructsMinimalBitwiseArrayOrSetsToNegativeOne(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinBitwiseArray(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}