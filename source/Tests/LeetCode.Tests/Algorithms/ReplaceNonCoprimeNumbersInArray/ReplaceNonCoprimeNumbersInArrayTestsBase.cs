// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ReplaceNonCoprimeNumbersInArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ReplaceNonCoprimeNumbersInArray;

public abstract class ReplaceNonCoprimeNumbersInArrayTestsBase<T> where T : IReplaceNonCoprimeNumbersInArray, new()
{
    [TestMethod]
    [DataRow("[6,4,3,2,7,6,2]", "[12,7,6]")]
    [DataRow("[2,2,1,1,3,3,3]", "[2,1,1,3]")]
    public void ReplaceNonCoprimes_WithNumsArray_ReplacesWithLCMUntilNoMorePairs(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ReplaceNonCoprimes(nums).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}