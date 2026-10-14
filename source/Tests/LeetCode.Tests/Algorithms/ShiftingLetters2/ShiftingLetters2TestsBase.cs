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

using LeetCode.Algorithms.ShiftingLetters2;

namespace LeetCode.Tests.Algorithms.ShiftingLetters2;

public abstract class ShiftingLetters2TestsBase<T> where T : IShiftingLetters2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ShiftingLetters_WithStringAndShiftArray_ReturnsShiftedString(string s, int[][] shifts, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ShiftingLetters(s, shifts);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return ["abc", new[] { new[] { 0, 1, 0 }, new[] { 1, 2, 1 }, new[] { 0, 2, 1 } }, "ace"];

        yield return ["dztz", new[] { new[] { 0, 0, 0 }, new[] { 1, 1, 1 } }, "catz"];

        yield return
        [
            "xuwdbdqik",
            new[]
            {
                new[] { 4, 8, 0 },
                new[] { 4, 4, 0 },
                new[] { 2, 4, 0 },
                new[] { 2, 4, 0 },
                new[] { 6, 7, 1 },
                new[] { 2, 2, 1 },
                new[] { 0, 2, 1 },
                new[] { 8, 8, 0 },
                new[] { 1, 3, 1 }
            },
            "ywxcxcqii"
        ];

        yield return ["a", new[] { new[] { 0, 0, 0 } }, "z"];

        yield return ["a", new[] { new[] { 0, 0, 1 } }, "b"];

        yield return ["z", new[] { new[] { 0, 0, 1 } }, "a"];

        yield return ["z", new[] { new[] { 0, 0, 0 } }, "y"];

        yield return ["abc", new[] { new[] { 0, 2, 1 } }, "bcd"];

        yield return ["abc", new[] { new[] { 0, 2, 0 } }, "zab"];

        yield return ["zzz", new[] { new[] { 0, 2, 1 }, new[] { 1, 1, 1 } }, "aba"];

        yield return ["aaa", new[] { new[] { 0, 2, 0 }, new[] { 0, 0, 0 } }, "yzz"];

        yield return ["hello", new[] { new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 }, new[] { 0, 4, 1 } }, "hello"];

        yield return ["hello", new[] { new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 }, new[] { 0, 4, 0 } }, "gdkkn"];

        yield return ["abcdef", new[] { new[] { 1, 3, 1 }, new[] { 2, 4, 0 }, new[] { 0, 5, 1 } }, "bddeeg"];

        yield return ["abcdef", new[] { new[] { 5, 5, 1 }, new[] { 0, 0, 0 } }, "zbcdeg"];

        yield return ["xyz", new[] { new[] { 0, 0, 1 }, new[] { 1, 1, 1 }, new[] { 2, 2, 1 }, new[] { 0, 2, 1 } }, "zab"];

        yield return ["leetcode", new[] { new[] { 0, 7, 1 }, new[] { 2, 5, 0 }, new[] { 3, 3, 1 }, new[] { 7, 7, 0 } }, "mfeucoee"];

        yield return ["mnop", new[] { new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 }, new[] { 2, 3, 1 } }, "zabc"];

        yield return ["ab", new[] { new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 } }, "yz"];

        yield return ["zy", new[] { new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 }, new[] { 1, 1, 1 } }, "bb"];
    }
}