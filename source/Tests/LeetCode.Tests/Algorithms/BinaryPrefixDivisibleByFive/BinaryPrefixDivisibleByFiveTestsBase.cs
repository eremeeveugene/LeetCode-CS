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

using LeetCode.Algorithms.BinaryPrefixDivisibleByFive;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.BinaryPrefixDivisibleByFive;

public abstract class BinaryPrefixDivisibleByFiveTestsBase<T> where T : IBinaryPrefixDivisibleByFive, new()
{
    [TestMethod]
    [DataRow("[0,1,1]", "[true,false,false]")]
    [DataRow("[1,1,1]", "[false,false,false]")]
    public void PrefixesDivBy5_WithNumsArray_ReturnsTrueIfPrefixDivisibleBy5(string numsJson, string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<bool[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.PrefixesDivBy5(nums).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}