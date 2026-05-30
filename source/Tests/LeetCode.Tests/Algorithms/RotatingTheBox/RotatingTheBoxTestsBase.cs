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

using LeetCode.Algorithms.RotatingTheBox;

namespace LeetCode.Tests.Algorithms.RotatingTheBox;

public abstract class RotatingTheBoxTestsBase<T> where T : IRotatingTheBox, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void RotateTheBox_WithBoxMatrix_ReturnsBoxAfterRotationAndGravityApplied(char[][] box,
        char[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RotateTheBox(box);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { '#', '.', '#' } }, new[] { new[] { '.' }, new[] { '#' }, new[] { '#' } }];

        yield return
        [
            new[] { new[] { '#', '.', '*', '.' }, new[] { '#', '#', '*', '.' } },
            new[] { new[] { '#', '.' }, new[] { '#', '#' }, new[] { '*', '*' }, new[] { '.', '.' } }
        ];

        yield return
        [
            new[]
            {
                new[] { '#', '#', '*', '.', '*', '.' }, new[] { '#', '#', '#', '*', '.', '.' },
                new[] { '#', '#', '#', '.', '#', '.' }
            },
            new[]
            {
                new[] { '.', '#', '#' }, new[] { '.', '#', '#' }, new[] { '#', '#', '*' }, new[] { '#', '*', '.' },
                new[] { '#', '.', '*' }, new[] { '#', '.', '.' }
            }
        ];
    }
}