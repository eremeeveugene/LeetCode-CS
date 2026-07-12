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

using LeetCode.Algorithms.FindTheDegreeOfEachVertex;

namespace LeetCode.Tests.Algorithms.FindTheDegreeOfEachVertex;

public abstract class FindTheDegreeOfEachVertexTestsBase<T> where T : IFindTheDegreeOfEachVertex, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindDegrees_WithAdjacencyMatrix_ReturnsDegreeOfEachVertex(int[][] matrix, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDegrees(matrix);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1, 1 }, new[] { 1, 0, 1 }, new[] { 1, 1, 0 } }, new[] { 2, 2, 2 }];

        yield return [new[] { new[] { 0, 1, 0 }, new[] { 1, 0, 0 }, new[] { 0, 0, 0 } }, new[] { 1, 1, 0 }];

        yield return [new[] { new[] { 0 } }, new[] { 0 }];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, new[] { 0, 0 }];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 0 } }, new[] { 1, 1 }];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, new[] { 0, 0, 0 }];

        yield return [new[] { new[] { 0, 1, 0, 1 }, new[] { 1, 0, 1, 0 }, new[] { 0, 1, 0, 1 }, new[] { 1, 0, 1, 0 } }, new[] { 2, 2, 2, 2 }];

        yield return [new[] { new[] { 0, 1, 1 }, new[] { 1, 0, 0 }, new[] { 1, 0, 0 } }, new[] { 2, 1, 1 }];

        yield return [new[] { new[] { 0, 0, 1 }, new[] { 0, 0, 1 }, new[] { 1, 1, 0 } }, new[] { 1, 1, 2 }];

        yield return [new[] { new[] { 0, 1, 1, 1 }, new[] { 1, 0, 1, 1 }, new[] { 1, 1, 0, 1 }, new[] { 1, 1, 1, 0 } }, new[] { 3, 3, 3, 3 }];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 0 } }, new[] { 1, 1 }];

        yield return [new[] { new[] { 0, 1, 0, 0 }, new[] { 1, 0, 1, 0 }, new[] { 0, 1, 0, 1 }, new[] { 0, 0, 1, 0 } }, new[] { 1, 2, 2, 1 }];

        yield return [new[] { new[] { 0, 0, 0, 1 }, new[] { 0, 0, 0, 1 }, new[] { 0, 0, 0, 1 }, new[] { 1, 1, 1, 0 } }, new[] { 1, 1, 1, 3 }];

        yield return
        [
            new[] { new[] { 0, 1, 1, 0, 0 }, new[] { 1, 0, 0, 0, 0 }, new[] { 1, 0, 0, 1, 0 }, new[] { 0, 0, 1, 0, 1 }, new[] { 0, 0, 0, 1, 0 } },
            new[] { 2, 1, 2, 2, 1 }
        ];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, new[] { 0, 0 }];

        yield return [new[] { new[] { 0, 1, 0 }, new[] { 1, 0, 1 }, new[] { 0, 1, 0 } }, new[] { 1, 2, 1 }];

        yield return
        [
            new[] { new[] { 0, 1, 1, 1, 1 }, new[] { 1, 0, 0, 0, 0 }, new[] { 1, 0, 0, 0, 0 }, new[] { 1, 0, 0, 0, 0 }, new[] { 1, 0, 0, 0, 0 } },
            new[] { 4, 1, 1, 1, 1 }
        ];

        yield return
        [
            new[] { new[] { 0, 1, 0, 0, 0 }, new[] { 1, 0, 1, 0, 0 }, new[] { 0, 1, 0, 1, 0 }, new[] { 0, 0, 1, 0, 1 }, new[] { 0, 0, 0, 1, 0 } },
            new[] { 1, 2, 2, 2, 1 }
        ];

        yield return [new[] { new[] { 0, 1, 0, 1 }, new[] { 1, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 1, 0, 0, 0 } }, new[] { 2, 1, 0, 1 }];

        yield return [new[] { new[] { 0, 1, 1, 0 }, new[] { 1, 0, 1, 0 }, new[] { 1, 1, 0, 0 }, new[] { 0, 0, 0, 0 } }, new[] { 2, 2, 2, 0 }];

        yield return
        [
            new[]
            {
                new[] { 0, 0, 1, 0, 1, 0 },
                new[] { 0, 0, 0, 1, 0, 1 },
                new[] { 1, 0, 0, 0, 1, 0 },
                new[] { 0, 1, 0, 0, 0, 1 },
                new[] { 1, 0, 1, 0, 0, 0 },
                new[] { 0, 1, 0, 1, 0, 0 }
            },
            new[] { 2, 2, 2, 2, 2, 2 }
        ];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 0 } }, new[] { 1, 1 }];

        yield return [new[] { new[] { 0, 1, 1, 1 }, new[] { 1, 0, 0, 0 }, new[] { 1, 0, 0, 1 }, new[] { 1, 0, 1, 0 } }, new[] { 3, 1, 2, 2 }];
    }
}