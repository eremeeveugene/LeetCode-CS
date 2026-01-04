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

using LeetCode.Algorithms.FindAllKDistantIndicesInAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindAllKDistantIndicesInAnArray;

public abstract class FindAllKDistantIndicesInAnArrayTestsBase<T> where T : IFindAllKDistantIndicesInAnArray, new()
{
    [TestMethod]
    [DataRow("[3,4,9,1,3,9,5]", 9, 1, "[1,2,3,4,5,6]")]
    [DataRow("[2,2,2,2,2]", 2, 2, "[0,1,2,3,4]")]
    public void FindKDistantIndices_WithKeyAndDistance_ReturnsAllIndicesWithinKDistanceOfKey(string numsJson, int key,
        int k, string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindKDistantIndices(nums, key, k).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}