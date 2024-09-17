// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.NextGreaterElement1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NextGreaterElement1;

public abstract class NextGreaterElement1TestsBase<T> where T : INextGreaterElement1, new()
{
    [TestMethod]
    [DataRow("[4,1,2]", "[1,3,4,2]", "[-1,3,-1]")]
    [DataRow("[2,4]", "[1,2,3,4]", "[3,-1]")]
    public void NextGreaterElement_GivenNums1AndNums2_ReturnsExpectedArray(string nums1JsonArray, string nums2JsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var nums1 = JsonHelper<int>.DeserializeToArray(nums1JsonArray);
        var nums2 = JsonHelper<int>.DeserializeToArray(nums2JsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.NextGreaterElement(nums1, nums2);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}