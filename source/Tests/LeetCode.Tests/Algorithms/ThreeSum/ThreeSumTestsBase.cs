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

using LeetCode.Algorithms.ThreeSum;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ThreeSum;

public abstract class ThreeSumTestsBase<T> where T : IThreeSum, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ThreeSum_WithIntArray_ReturnsTripletsThatSumToZero(int[] nums, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ThreeSum(nums);

        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { -1, 0, 1, 2, -1, -4 }, new[] { new[] { -1, -1, 2 }, new[] { -1, 0, 1 } }];

        yield return [new[] { 0, 1, 1 }, Array.Empty<int[]>()];

        yield return [new[] { 0, 0, 0 }, new[] { new[] { 0, 0, 0 } }];

        yield return [new[] { -3, -2, 1, 1, 2 }, new[] { new[] { -3, 1, 2 }, new[] { -2, 1, 1 } }];

        yield return [new[] { 3, 0, -2, -1, 1, 2 }, new[] { new[] { -2, -1, 3 }, new[] { -2, 0, 2 }, new[] { -1, 0, 1 } }];

        yield return [new[] { 0, 0, 0, 0 }, new[] { new[] { 0, 0, 0 } }];

        yield return [new[] { -2, 0, 0, 2, 2 }, new[] { new[] { -2, 0, 2 } }];

        yield return [new[] { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 }, new[] { new[] { -4, -2, 6 }, new[] { -4, 0, 4 }, new[] { -4, 1, 3 }, new[] { -4, 2, 2 }, new[] { -2, -2, 4 }, new[] { -2, 0, 2 } }];

        yield return [new[] { 1, 2, 3 }, Array.Empty<int[]>()];

        yield return [new[] { -1, -1, -1 }, Array.Empty<int[]>()];

        yield return [new[] { -5, 0, 5 }, new[] { new[] { -5, 0, 5 } }];

        yield return [new[] { 1, -1, -1, 0 }, new[] { new[] { -1, 0, 1 } }];

        yield return [new[] { -1, 0, 1, 0 }, new[] { new[] { -1, 0, 1 } }];

        yield return [new[] { -2, 0, 1, 1, 2 }, new[] { new[] { -2, 0, 2 }, new[] { -2, 1, 1 } }];

        yield return [new[] { -1, -1, 2 }, new[] { new[] { -1, -1, 2 } }];

        yield return [new[] { 0, 0, 0, 0, 0 }, new[] { new[] { 0, 0, 0 } }];

        yield return [new[] { -4, 2, 2 }, new[] { new[] { -4, 2, 2 } }];

        yield return [new[] { 1000000, -500000, -500000 }, new[] { new[] { -500000, -500000, 1000000 } }];

        yield return [new[] { -1, 0, 0, 1 }, new[] { new[] { -1, 0, 1 } }];

        yield return [new[] { -4, -1, -1, 0, 1, 2 }, new[] { new[] { -1, -1, 2 }, new[] { -1, 0, 1 } }];
    }
}