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

using LeetCode.Algorithms.SpecialArray2;

namespace LeetCode.Tests.Algorithms.SpecialArray2;

public abstract class SpecialArray2TestsBase<T> where T : ISpecialArray2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IsArraySpecial_WithSubarrayQueries_ReturnsWhetherEachSubarrayHasAlternatingParity(int[] nums, int[][] queries, bool[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsArraySpecial(nums, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 3, 4, 1, 2, 6 }, new[] { new[] { 0, 4 } }, new[] { false }];

        yield return [new[] { 4, 3, 1, 6 }, new[] { new[] { 0, 2 }, new[] { 2, 3 } }, new[] { false, true }];
        yield return [new[] { 1 }, new[] { new[] { 0, 0 } }, new[] { true }];
        yield return [new[] { 5, 5 }, new[] { new[] { 0, 0 }, new[] { 1, 1 }, new[] { 0, 1 } }, new[] { true, true, false }];
        yield return [new[] { 1, 2 }, new[] { new[] { 0, 1 } }, new[] { true }];
        yield return [new[] { 2, 2, 2 }, new[] { new[] { 0, 2 }, new[] { 1, 2 }, new[] { 0, 0 } }, new[] { false, false, true }];
        yield return [new[] { 1, 2, 3, 4, 5 }, new[] { new[] { 0, 4 }, new[] { 1, 3 }, new[] { 2, 2 } }, new[] { true, true, true }];
        yield return [new[] { 1, 2, 3, 3, 4, 5 }, new[] { new[] { 0, 5 }, new[] { 0, 2 }, new[] { 3, 5 }, new[] { 2, 3 } }, new[] { false, true, true, false }];
        yield return [new[] { 100, 99, 98, 97, 96, 97 }, new[] { new[] { 0, 5 }, new[] { 0, 4 }, new[] { 4, 5 } }, new[] { true, true, true }];
        yield return [new[] { 2, 4, 6, 8 }, new[] { new[] { 0, 3 }, new[] { 1, 2 }, new[] { 3, 3 } }, new[] { false, false, true }];
        yield return [new[] { 1, 3, 2, 4, 1, 3 }, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, new[] { false, true, false, true, false }];
        yield return [new[] { 7, 8, 9, 10, 11, 12, 13, 14 }, new[] { new[] { 0, 7 }, new[] { 2, 6 }, new[] { 7, 7 }, new[] { 0, 0 } }, new[] { true, true, true, true }];
        yield return [new[] { 2, 1, 2, 1, 1, 2, 1, 2 }, new[] { new[] { 0, 3 }, new[] { 3, 4 }, new[] { 4, 7 }, new[] { 0, 7 }, new[] { 2, 5 } }, new[] { true, false, true, false, false }];
        yield return [new[] { 57, 18, 51, 21, 16, 20, 32, 66 }, new[] { new[] { 1, 1 } }, new[] { true }];
        yield return [new[] { 69, 55, 36, 67, 47, 100, 54, 64, 11, 31, 98, 29, 33, 50 }, new[] { new[] { 4, 11 }, new[] { 7, 8 }, new[] { 10, 13 }, new[] { 2, 2 }, new[] { 1, 5 } }, new[] { false, true, false, true, false }];
        yield return [new[] { 88, 67, 3, 67, 72, 22, 64, 10, 40 }, new[] { new[] { 1, 5 }, new[] { 8, 8 }, new[] { 0, 4 }, new[] { 5, 5 }, new[] { 4, 6 } }, new[] { false, true, false, true, false }];
        yield return [new[] { 61, 26, 83, 96, 60, 34, 10 }, new[] { new[] { 5, 5 }, new[] { 2, 3 } }, new[] { true, true }];
        yield return [new[] { 23, 41, 80, 27, 63, 1, 57, 28, 10, 49, 32, 12 }, new[] { new[] { 3, 3 } }, new[] { true }];
        yield return
        [
            BuildAlternatingNums(100000, -1),
            new[] { new[] { 0, 99999 }, new[] { 0, 0 }, new[] { 50000, 99999 } },
            new[] { true, true, true }
        ];
        yield return
        [
            BuildAlternatingNums(100000, 50000),
            new[] { new[] { 0, 99999 }, new[] { 0, 49999 }, new[] { 50000, 99999 }, new[] { 49999, 50000 } },
            new[] { false, true, true, false }
        ];
    }

    private static int[] BuildAlternatingNums(int length, int repeatedParityIndex)
    {
        var nums = new int[length];

        for (var i = 0; i < length; i++)
        {
            if (i == repeatedParityIndex)
            {
                nums[i] = nums[i - 1] + 2;
            }
            else if (i > 0)
            {
                nums[i] = nums[i - 1] % 2 == 0 ? 1 : 2;
            }
            else
            {
                nums[i] = 2;
            }
        }

        return nums;
    }
}