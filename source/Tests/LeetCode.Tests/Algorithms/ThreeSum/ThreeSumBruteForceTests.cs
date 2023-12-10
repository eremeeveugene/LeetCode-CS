// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ThreeSum;
using LeetCode.Core.EqualityComparers;
using Newtonsoft.Json;

namespace LeetCode.Tests.Algorithms.ThreeSum;

[TestClass]
public class ThreeSumBruteForceTests
{
    [TestMethod]
    [DataRow(new[] { -1, 0, 1, 2, -1, -4 }, "[[-1, -1, 2], [-1, 0, 1]]")]
    [DataRow(new[] { 0, 1, 1 }, "[]")]
    [DataRow(new[] { 0, 0, 0 }, "[[0, 0, 0]]")]
    [DataRow(new[] { -3, -2, 1, 1, 2 }, "[[-3, 1, 2], [-2, 1, 1]]")]
    [DataRow(new[] { 3, 0, -2, -1, 1, 2 }, "[[-2, -1, 3],[-2, 0, 2],[-1, 0, 1]]")]
    public void ThreeSumBruteForce_GetResult_ShouldReturnCorrectTripletsSet(int[] nums, string expectedResultJson)
    {
        // Arrange
        int[][]? expectedResult = JsonConvert.DeserializeObject<int[][]>(expectedResultJson);

        // Act
        IList<IList<int>> actualResult = ThreeSumBruteForce.GetResult(nums);

        // Assert
        HashSet<int[]> expectedSet = new(expectedResult!.Select(e => e.ToArray()),
            new OrderInsensitiveIntArrayEqualityComparer());
        HashSet<int[]> actualSet = new(actualResult.Select(a => a.ToArray()),
            new OrderInsensitiveIntArrayEqualityComparer());

        Assert.AreEqual(expectedResult!.Length, actualResult.Count);
        Assert.IsTrue(expectedSet.SetEquals(actualSet));
    }
}