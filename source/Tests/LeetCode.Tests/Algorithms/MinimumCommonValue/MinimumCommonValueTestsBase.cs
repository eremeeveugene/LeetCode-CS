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

using LeetCode.Algorithms.MinimumCommonValue;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumCommonValue;

public abstract class MinimumCommonValueTestsBase<T> where T : IMinimumCommonValue, new()
{
    [TestMethod]
    [DataRow("[1,2,3]", "[2,4]", 2)]
    [DataRow("[1,2,3,6]", "[2,3,4,5]", 2)]
    [DataRow("[1,3,5]", "[2,4,6]", -1)]
    [DataRow("[1,2,3,4]", "[5,6,7,8]", -1)]
    [DataRow("[1,2,3,4]", "[1,2,3,4]", 1)]
    [DataRow("[5,6,7]", "[5,8,9]", 5)]
    [DataRow("[1]", "[1]", 1)]
    [DataRow("[1,3,4,5]", "[2,3,6,7]", 3)]
    [DataRow("[-5,-3,-1]", "[-4,-3,0]", -3)]
    [DataRow("[]", "[1,2,3]", -1)]
    [DataRow("[1,2,3]", "[]", -1)]
    [DataRow("[]", "[]", -1)]
    public void GetCommon_WithTwoArrays_ReturnsCountOfCommonElements(string nums1JsonArray, string nums2JsonArray,
        int expectedResult)
    {
        // Arrange
        var nums1 = JsonHelper<int>.DeserializeToArray(nums1JsonArray);
        var nums2 = JsonHelper<int>.DeserializeToArray(nums2JsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.GetCommon(nums1, nums2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}