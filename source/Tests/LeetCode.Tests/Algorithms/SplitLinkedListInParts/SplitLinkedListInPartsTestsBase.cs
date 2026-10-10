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

using LeetCode.Algorithms.SplitLinkedListInParts;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SplitLinkedListInParts;

public abstract class SplitLinkedListInPartsTestsBase<T> where T : ISplitLinkedListInParts, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SplitListToParts_WithLinkedListAndPartCount_ReturnsEquallyDividedParts(int[] headArray, int k, int[][] expectedResultNestedArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);

        var expectedResult = new ListNode?[k];

        for (var i = 0; i < expectedResultNestedArray.Length; i++)
        {
            expectedResult[i] = ListNode.ToListNode(expectedResultNestedArray[i]);
        }

        var solution = new T();

        // Act
        var actualResult = solution.SplitListToParts(head, k);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            Array.Empty<int>(), 5, new[] { Array.Empty<int>(), Array.Empty<int>(), Array.Empty<int>(), Array.Empty<int>(), Array.Empty<int>() }
        ];

        yield return [new[] { 1, 2, 3 }, 5, new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, Array.Empty<int>(), Array.Empty<int>() }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7 }, new[] { 8, 9, 10 } }];

        yield return [Array.Empty<int>(), 1, Array.Empty<int[]>()];

        yield return [new[] { 5 }, 1, new[] { new[] { 5 } }];

        yield return [new[] { 5 }, 3, new[] { new[] { 5 } }];

        yield return [new[] { 5, 42 }, 5, new[] { new[] { 5 }, new[] { 42 } }];

        yield return [new[] { 5, 42, 79, 116 }, 2, new[] { new[] { 5, 42 }, new[] { 79, 116 } }];

        yield return [new[] { 5, 42, 79, 116, 153 }, 3, new[] { new[] { 5, 42 }, new[] { 79, 116 }, new[] { 153 } }];

        yield return [new[] { 5, 42, 79, 116, 153, 190, 227 }, 3, new[] { new[] { 5, 42, 79 }, new[] { 116, 153 }, new[] { 190, 227 } }];

        yield return [new[] { 5, 42, 79, 116, 153, 190 }, 6, new[] { new[] { 5 }, new[] { 42 }, new[] { 79 }, new[] { 116 }, new[] { 153 }, new[] { 190 } }];

        yield return [new[] { 5, 42, 79, 116, 153, 190, 227, 264, 301, 338 }, 4, new[] { new[] { 5, 42, 79 }, new[] { 116, 153, 190 }, new[] { 227, 264 }, new[] { 301, 338 } }];

        yield return [new[] { 5, 42, 79, 116, 153, 190, 227, 264 }, 1, new[] { new[] { 5, 42, 79, 116, 153, 190, 227, 264 } }];

        yield return [new[] { 5, 42, 79, 116, 153, 190, 227, 264, 301, 338, 375, 412, 449 }, 5, new[] { new[] { 5, 42, 79 }, new[] { 116, 153, 190 }, new[] { 227, 264, 301 }, new[] { 338, 375 }, new[] { 412, 449 } }];

        yield return [new[] { 5, 42, 79, 116, 153, 190, 227, 264, 301 }, 9, new[] { new[] { 5 }, new[] { 42 }, new[] { 79 }, new[] { 116 }, new[] { 153 }, new[] { 190 }, new[] { 227 }, new[] { 264 }, new[] { 301 } }];

        yield return [new[] { 5, 42, 79 }, 2, new[] { new[] { 5, 42 }, new[] { 79 } }];

        yield return [new[] { 5, 42, 79, 116, 153, 190, 227, 264, 301, 338, 375 }, 7, new[] { new[] { 5, 42 }, new[] { 79, 116 }, new[] { 153, 190 }, new[] { 227, 264 }, new[] { 301 }, new[] { 338 }, new[] { 375 } }];

        yield return [new[] { 5, 42, 79, 116, 153, 190, 227, 264, 301, 338, 375, 412, 449, 486, 523, 560, 597, 634, 671, 708 }, 3, new[] { new[] { 5, 42, 79, 116, 153, 190, 227 }, new[] { 264, 301, 338, 375, 412, 449, 486 }, new[] { 523, 560, 597, 634, 671, 708 } }];

        yield return [new[] { 5, 42, 79, 116, 153, 190, 227, 264, 301, 338, 375, 412, 449, 486, 523 }, 50, new[] { new[] { 5 }, new[] { 42 }, new[] { 79 }, new[] { 116 }, new[] { 153 }, new[] { 190 }, new[] { 227 }, new[] { 264 }, new[] { 301 }, new[] { 338 }, new[] { 375 }, new[] { 412 }, new[] { 449 }, new[] { 486 }, new[] { 523 } }];

        yield return [new[] { 5, 42, 79, 116, 153, 190, 227, 264, 301, 338, 375, 412, 449, 486, 523, 560, 597, 634, 671, 708, 745, 782, 819, 856, 893, 930, 967, 3, 40, 77, 114, 151, 188, 225, 262, 299, 336, 373, 410, 447, 484, 521, 558, 595, 632, 669, 706, 743, 780, 817 }, 50, new[] { new[] { 5 }, new[] { 42 }, new[] { 79 }, new[] { 116 }, new[] { 153 }, new[] { 190 }, new[] { 227 }, new[] { 264 }, new[] { 301 }, new[] { 338 }, new[] { 375 }, new[] { 412 }, new[] { 449 }, new[] { 486 }, new[] { 523 }, new[] { 560 }, new[] { 597 }, new[] { 634 }, new[] { 671 }, new[] { 708 }, new[] { 745 }, new[] { 782 }, new[] { 819 }, new[] { 856 }, new[] { 893 }, new[] { 930 }, new[] { 967 }, new[] { 3 }, new[] { 40 }, new[] { 77 }, new[] { 114 }, new[] { 151 }, new[] { 188 }, new[] { 225 }, new[] { 262 }, new[] { 299 }, new[] { 336 }, new[] { 373 }, new[] { 410 }, new[] { 447 }, new[] { 484 }, new[] { 521 }, new[] { 558 }, new[] { 595 }, new[] { 632 }, new[] { 669 }, new[] { 706 }, new[] { 743 }, new[] { 780 }, new[] { 817 } }];

        yield return [CreateSequence(1000), 50, CreateParts(50, 20)];
    }

    private static int[] CreateSequence(int count)
    {
        var sequence = new int[count];

        for (var i = 0; i < count; i++)
        {
            sequence[i] = i + 1;
        }

        return sequence;
    }

    private static int[][] CreateParts(int partCount, int partSize)
    {
        var parts = new int[partCount][];

        for (var i = 0; i < partCount; i++)
        {
            parts[i] = new int[partSize];

            for (var j = 0; j < partSize; j++)
            {
                parts[i][j] = (i * partSize) + j + 1;
            }
        }

        return parts;
    }
}