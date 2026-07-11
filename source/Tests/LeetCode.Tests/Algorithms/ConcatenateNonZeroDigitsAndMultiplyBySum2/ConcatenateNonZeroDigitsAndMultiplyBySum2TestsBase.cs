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

using LeetCode.Algorithms.ConcatenateNonZeroDigitsAndMultiplyBySum2;

namespace LeetCode.Tests.Algorithms.ConcatenateNonZeroDigitsAndMultiplyBySum2;

public abstract class ConcatenateNonZeroDigitsAndMultiplyBySum2TestsBase<T> where T : IConcatenateNonZeroDigitsAndMultiplyBySum2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SumAndMultiply_WithStringAndQueries_ReturnsProductsOfNonZeroDigitConcatenationAndDigitSum(string s, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumAndMultiply(s, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return ["10203004", new[] { new[] { 0, 7 }, new[] { 1, 3 }, new[] { 4, 6 } }, new[] { 12340, 4, 9 }];

        yield return ["1000", new[] { new[] { 0, 3 }, new[] { 1, 1 } }, new[] { 1, 0 }];

        yield return ["9876543210", new[] { new[] { 0, 9 } }, new[] { 444444137 }];

        yield return ["0", new[] { new[] { 0, 0 } }, new[] { 0 }];

        yield return ["5", new[] { new[] { 0, 0 } }, new[] { 25 }];

        yield return ["9", new[] { new[] { 0, 0 } }, new[] { 81 }];

        yield return ["12", new[] { new[] { 0, 1 } }, new[] { 36 }];

        yield return ["12", new[] { new[] { 0, 0 }, new[] { 1, 1 } }, new[] { 1, 4 }];

        yield return ["000", new[] { new[] { 0, 2 } }, new[] { 0 }];

        yield return ["102", new[] { new[] { 0, 2 }, new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 36, 1, 4 }];

        yield return ["111", new[] { new[] { 0, 2 } }, new[] { 333 }];

        yield return ["90", new[] { new[] { 0, 1 }, new[] { 1, 1 } }, new[] { 81, 0 }];

        yield return ["123456789", new[] { new[] { 0, 8 } }, new[] { 555555470 }];

        yield return ["10", new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 1 } }, new[] { 1, 1, 0 }];

        yield return ["404", new[] { new[] { 0, 2 } }, new[] { 352 }];

        yield return ["007", new[] { new[] { 0, 2 }, new[] { 0, 1 } }, new[] { 49, 0 }];

        yield return ["2222", new[] { new[] { 0, 3 }, new[] { 1, 2 } }, new[] { 17776, 88 }];

        yield return ["505050", new[] { new[] { 0, 5 } }, new[] { 8325 }];

        yield return ["31415926", new[] { new[] { 2, 5 } }, new[] { 79021 }];

        yield return ["606", new[] { new[] { 1, 1 } }, new[] { 0 }];

        yield return ["1203", new[] { new[] { 0, 3 }, new[] { 2, 3 }, new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 738, 9, 36, 4 }];

        yield return ["99999", new[] { new[] { 0, 4 } }, new[] { 4499955 }];

        yield return ["8", new[] { new[] { 0, 0 }, new[] { 0, 0 } }, new[] { 64, 64 }];

        yield return ["1010101", new[] { new[] { 0, 6 }, new[] { 2, 4 } }, new[] { 4444, 22 }];

        yield return ["1234567891", new[] { new[] { 1, 9 } }, new[] { 555555025 }];

        yield return ["9999999999", new[] { new[] { 5, 9 } }, new[] { 4499955 }];
    }
}