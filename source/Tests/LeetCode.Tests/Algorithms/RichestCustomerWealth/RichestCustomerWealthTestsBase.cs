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

using LeetCode.Algorithms.RichestCustomerWealth;

namespace LeetCode.Tests.Algorithms.RichestCustomerWealth;

public abstract class RichestCustomerWealthTestsBase<T> where T : IRichestCustomerWealth, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaximumWealth_WithJsonAccounts_ReturnsMaximumWealth(int[][] accounts, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumWealth(accounts);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 } }, 6];

        yield return [new[] { new[] { 1, 5 }, new[] { 7, 3 }, new[] { 3, 5 } }, 10];

        yield return [new[] { new[] { 2, 8, 7 }, new[] { 7, 1, 3 }, new[] { 1, 9, 5 } }, 17];
        yield return [new[] { new[] { 1 } }, 1];
        yield return [new[] { new[] { 100 } }, 100];
        yield return [new[] { new[] { 1, 1 } }, 2];
        yield return [new[] { new[] { 1 }, new[] { 1 } }, 1];
        yield return [new[] { new[] { 1 }, new[] { 2 } }, 2];
        yield return [new[] { new[] { 2 }, new[] { 1 } }, 2];
        yield return [new[] { new[] { 5, 5 }, new[] { 10, 1 } }, 11];
        yield return [new[] { new[] { 1, 2, 3, 4, 5 } }, 15];
        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 }, new[] { 5 } }, 5];
        yield return [new[] { new[] { 100, 100, 100 }, new[] { 1, 1, 1 } }, 300];
        yield return [new[] { new[] { 50, 50 }, new[] { 50, 50 }, new[] { 50, 50 } }, 100];
        yield return [new[] { new[] { 1, 100 }, new[] { 100, 1 } }, 101];
        yield return [new[] { new[] { 3, 3, 3 }, new[] { 4, 4, 1 }, new[] { 2, 2, 2 } }, 9];
        yield return [new[] { new[] { 29, 29, 46, 60, 32, 74, 24, 63, 46, 3 }, new[] { 73, 85, 19, 21, 31, 93, 56, 45, 14, 28 }, new[] { 30, 96, 36, 70, 95, 51, 35, 41, 97, 48 }, new[] { 19, 6, 26, 19, 49, 2, 84, 5, 52, 77 }, new[] { 55, 98, 89, 83, 17, 62, 52, 88, 8, 21 }, new[] { 87, 31, 22, 3, 57, 80, 18, 37, 48, 82 }, new[] { 28, 60, 79, 18, 79, 92, 100, 71, 29, 73 }, new[] { 92, 42, 36, 39, 72, 81, 45, 88, 95, 39 }, new[] { 54, 37, 66, 24, 10, 72, 10, 75, 22, 58 }, new[] { 86, 57, 89, 24, 93, 97, 36, 89, 97, 89 } }, 757];
        yield return [new[] { new[] { 1, 64, 48, 49, 39, 47, 85, 3, 21, 37, 93, 68, 56, 29, 45, 58, 27, 83, 26, 26, 45, 81, 19, 65, 95, 69, 22, 63, 29, 91, 7, 96, 19, 52, 11, 45, 32, 24, 67, 64, 11, 59, 87, 99, 8, 39, 2, 49, 89, 80 } }, 2424];
        yield return [new[] { new[] { 69 }, new[] { 8 }, new[] { 30 }, new[] { 16 }, new[] { 99 }, new[] { 4 }, new[] { 74 }, new[] { 58 }, new[] { 50 }, new[] { 82 }, new[] { 13 }, new[] { 49 }, new[] { 86 }, new[] { 90 }, new[] { 15 }, new[] { 2 }, new[] { 29 }, new[] { 79 }, new[] { 99 }, new[] { 80 }, new[] { 56 }, new[] { 89 }, new[] { 78 }, new[] { 63 }, new[] { 4 }, new[] { 20 }, new[] { 52 }, new[] { 28 }, new[] { 31 }, new[] { 59 }, new[] { 21 }, new[] { 44 }, new[] { 55 }, new[] { 94 }, new[] { 83 }, new[] { 58 }, new[] { 91 }, new[] { 14 }, new[] { 7 }, new[] { 50 }, new[] { 63 }, new[] { 99 }, new[] { 35 }, new[] { 64 }, new[] { 36 }, new[] { 18 }, new[] { 84 }, new[] { 31 }, new[] { 33 }, new[] { 44 } }, 99];
        yield return [new[] { new[] { 86, 95, 44, 86, 65, 77, 40, 6, 94, 57, 3, 59, 99, 26, 91 }, new[] { 51, 51, 47, 64, 28, 89, 30, 77, 80, 49, 4, 48, 24, 81, 29 }, new[] { 23, 44, 19, 2, 71, 63, 85, 12, 40, 52, 45, 83, 35, 34, 41 }, new[] { 24, 80, 60, 32, 64, 26, 22, 64, 97, 42, 28, 67, 12, 19, 19 }, new[] { 69, 64, 81, 92, 13, 42, 6, 48, 92, 11, 84, 63, 25, 82, 12 }, new[] { 48, 44, 22, 97, 45, 79, 8, 94, 61, 34, 61, 61, 24, 33, 57 }, new[] { 33, 57, 98, 12, 50, 17, 12, 31, 56, 63, 88, 63, 68, 21, 36 }, new[] { 40, 39, 22, 16, 50, 93, 59, 83, 70, 26, 27, 34, 15, 86, 78 }, new[] { 35, 80, 67, 20, 31, 83, 4, 58, 95, 47, 53, 8, 98, 59, 29 }, new[] { 47, 67, 59, 5, 69, 64, 51, 70, 33, 40, 21, 46, 92, 42, 53 }, new[] { 79, 49, 50, 35, 72, 98, 39, 63, 38, 5, 69, 12, 54, 19, 30 }, new[] { 94, 73, 70, 89, 29, 18, 41, 2, 39, 59, 25, 70, 34, 81, 60 }, new[] { 13, 55, 54, 66, 44, 2, 98, 64, 90, 84, 92, 11, 30, 34, 3 }, new[] { 48, 29, 8, 25, 88, 52, 65, 49, 43, 16, 32, 93, 55, 95, 44 }, new[] { 21, 80, 86, 66, 9, 13, 18, 68, 4, 71, 58, 63, 64, 13, 24 }, new[] { 61, 57, 82, 28, 5, 96, 40, 5, 30, 73, 37, 26, 77, 31, 20 }, new[] { 23, 79, 53, 51, 10, 60, 77, 77, 57, 57, 35, 98, 13, 74, 1 }, new[] { 31, 77, 50, 11, 63, 10, 55, 67, 2, 39, 8, 80, 67, 35, 35 }, new[] { 71, 75, 73, 11, 33, 31, 80, 80, 28, 65, 52, 22, 73, 20, 68 }, new[] { 15, 75, 24, 22, 89, 5, 69, 50, 27, 61, 47, 93, 78, 32, 10 } }, 928];
    }
}