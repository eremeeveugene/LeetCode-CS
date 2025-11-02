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

using LeetCode.Algorithms.FindMissingElements;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindMissingElements;

public abstract class FindMissingElementsTestsBase<T> where T : IFindMissingElements, new()
{
    [TestMethod]
    [DataRow("[1,4,2,5]", "[3]")]
    [DataRow("[7,8,6,9]", "[]")]
    [DataRow("[5,1]", "[2,3,4]")]
    public void FindMissingElements_WithArrayContainingGaps_ReturnsMissingSequentialElements(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindMissingElements(nums).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}