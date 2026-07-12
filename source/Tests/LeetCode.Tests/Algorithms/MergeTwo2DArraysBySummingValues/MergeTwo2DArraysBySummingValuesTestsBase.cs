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

using LeetCode.Algorithms.MergeTwo2DArraysBySummingValues;

namespace LeetCode.Tests.Algorithms.MergeTwo2DArraysBySummingValues;

public abstract class MergeTwo2DArraysBySummingValuesTestsBase<T> where T : IMergeTwo2DArraysBySummingValues, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MergeArrays_WithTwoKeyValuePairArrays_ReturnsMergedArrayWithSummedValues(int[][] nums1, int[][] nums2, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MergeArrays(nums1, nums2);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 4, 5 } }, new[] { new[] { 1, 4 }, new[] { 3, 2 }, new[] { 4, 1 } },
            new[] { new[] { 1, 6 }, new[] { 2, 3 }, new[] { 3, 2 }, new[] { 4, 6 } }
        ];

        yield return
        [
            new[] { new[] { 2, 4 }, new[] { 3, 6 }, new[] { 5, 5 } }, new[] { new[] { 1, 3 }, new[] { 4, 3 } },
            new[] { new[] { 1, 3 }, new[] { 2, 4 }, new[] { 3, 6 }, new[] { 4, 3 }, new[] { 5, 5 } }
        ];

        // Single element each, no overlap
        yield return [new[] { new[] { 1, 5 } }, new[] { new[] { 2, 7 } }, new[] { new[] { 1, 5 }, new[] { 2, 7 } }];

        // Single element each, same key
        yield return [new[] { new[] { 1, 10 } }, new[] { new[] { 1, 20 } }, new[] { new[] { 1, 30 } }];

        // All keys overlap
        yield return
        [
            new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, new[] { new[] { 1, 4 }, new[] { 2, 5 }, new[] { 3, 6 } },
            new[] { new[] { 1, 5 }, new[] { 2, 7 }, new[] { 3, 9 } }
        ];

        // nums1 has all keys, nums2 has none
        yield return
        [
            new[] { new[] { 1, 3 }, new[] { 2, 4 } }, new[] { new[] { 3, 1 }, new[] { 4, 2 } },
            new[] { new[] { 1, 3 }, new[] { 2, 4 }, new[] { 3, 1 }, new[] { 4, 2 } }
        ];

        // Large values
        yield return [new[] { new[] { 1, 1000 } }, new[] { new[] { 1, 1000 } }, new[] { new[] { 1, 2000 } }];

        // Interleaved keys, all overlap
        yield return
        [
            new[] { new[] { 2, 10 }, new[] { 4, 20 } }, new[] { new[] { 2, 5 }, new[] { 4, 15 } }, new[] { new[] { 2, 15 }, new[] { 4, 35 } }
        ];

        // nums2 keys all before nums1 keys
        yield return
        [
            new[] { new[] { 5, 1 }, new[] { 6, 2 } }, new[] { new[] { 1, 3 }, new[] { 2, 4 } },
            new[] { new[] { 1, 3 }, new[] { 2, 4 }, new[] { 5, 1 }, new[] { 6, 2 } }
        ];

        // Multiple pairs, mixed overlap
        yield return
        [
            new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } }, new[] { new[] { 2, 1 }, new[] { 3, 2 }, new[] { 6, 3 } },
            new[] { new[] { 1, 2 }, new[] { 2, 1 }, new[] { 3, 6 }, new[] { 5, 6 }, new[] { 6, 3 } }
        ];

        // Single pair each with gap
        yield return [new[] { new[] { 3, 7 } }, new[] { new[] { 3, 3 } }, new[] { new[] { 3, 10 } }];

        // Both have same two keys
        yield return
        [
            new[] { new[] { 10, 5 }, new[] { 20, 10 } }, new[] { new[] { 10, 5 }, new[] { 20, 10 } }, new[] { new[] { 10, 10 }, new[] { 20, 20 } }
        ];

        // Many keys, partial overlap
        yield return
        [
            new[] { new[] { 1, 1 }, new[] { 3, 3 }, new[] { 5, 5 } }, new[] { new[] { 2, 2 }, new[] { 3, 3 }, new[] { 4, 4 } },
            new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 6 }, new[] { 4, 4 }, new[] { 5, 5 } }
        ];

        // nums2 entirely comes after nums1 keys with overlap on first
        yield return
        [
            new[] { new[] { 1, 100 }, new[] { 2, 200 } }, new[] { new[] { 1, 50 }, new[] { 3, 300 } },
            new[] { new[] { 1, 150 }, new[] { 2, 200 }, new[] { 3, 300 } }
        ];

        // Four keys, all overlap
        yield return
        [
            new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 }, new[] { 4, 4 } },
            new[] { new[] { 1, 10 }, new[] { 2, 20 }, new[] { 3, 30 }, new[] { 4, 40 } },
            new[] { new[] { 1, 11 }, new[] { 2, 22 }, new[] { 3, 33 }, new[] { 4, 44 } }
        ];

        // Three keys, no overlap
        yield return
        [
            new[] { new[] { 1, 5 }, new[] { 3, 15 }, new[] { 5, 25 } }, new[] { new[] { 2, 10 }, new[] { 4, 20 }, new[] { 6, 30 } },
            new[] { new[] { 1, 5 }, new[] { 2, 10 }, new[] { 3, 15 }, new[] { 4, 20 }, new[] { 5, 25 }, new[] { 6, 30 } }
        ];

        // First array has one element matching last of second
        yield return
        [
            new[] { new[] { 5, 9 } }, new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } },
            new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 15 } }
        ];

        // Both arrays have value 1 for all keys
        yield return
        [
            new[] { new[] { 1, 1 }, new[] { 2, 1 }, new[] { 3, 1 } }, new[] { new[] { 1, 1 }, new[] { 2, 1 }, new[] { 3, 1 } },
            new[] { new[] { 1, 2 }, new[] { 2, 2 }, new[] { 3, 2 } }
        ];
    }
}