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

using LeetCode.Algorithms.DesignNeighborSumService;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignNeighborSumService;

public abstract class DesignNeighborSumServiceTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignNeighborSumService_WithMixedOperations_ProcessesOperationsAccordingToSpecification(NeighborSumServiceScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Grid);

        // Act
        var operations = scenario.Operations;
        var operationsLength = operations.Length;

        var actualResult = new IOperationResult[operationsLength];

        for (var i = 0; i < operationsLength; i++)
        {
            var operation = operations[i];

            actualResult[i] = operation.Execute(solution);
        }

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    protected abstract IDesignNeighborSumService GetSolution(int[][] grid);

    private static IEnumerable<NeighborSumServiceScenario[]> GetScenarios()
    {
        yield return
        [
            new NeighborSumServiceScenario(
                [[0, 1, 2], [3, 4, 5], [6, 7, 8]],
                [new AdjacentSumOperation(1), new AdjacentSumOperation(4), new DiagonalSumOperation(4), new DiagonalSumOperation(8)],
                [
                    new AdjacentSumOperation.Result(6),
                    new AdjacentSumOperation.Result(16),
                    new DiagonalSumOperation.Result(16),
                    new DiagonalSumOperation.Result(4)
                ])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[0, 1, 2], [3, 4, 5], [6, 7, 8]],
                [new AdjacentSumOperation(0), new DiagonalSumOperation(0)],
                [new AdjacentSumOperation.Result(4), new DiagonalSumOperation.Result(4)])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[5]],
                [new AdjacentSumOperation(5), new DiagonalSumOperation(5)],
                [new AdjacentSumOperation.Result(0), new DiagonalSumOperation.Result(0)])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[0, 1], [2, 3]],
                [new AdjacentSumOperation(0), new DiagonalSumOperation(0), new AdjacentSumOperation(3), new DiagonalSumOperation(3)],
                [
                    new AdjacentSumOperation.Result(3),
                    new DiagonalSumOperation.Result(3),
                    new AdjacentSumOperation.Result(3),
                    new DiagonalSumOperation.Result(0)
                ])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new AdjacentSumOperation(0)], [new AdjacentSumOperation.Result(4)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new AdjacentSumOperation(2)], [new AdjacentSumOperation.Result(6)])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[0, 1, 2], [3, 4, 5], [6, 7, 8]],
                [new AdjacentSumOperation(6)],
                [new AdjacentSumOperation.Result(10)])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[0, 1, 2], [3, 4, 5], [6, 7, 8]],
                [new AdjacentSumOperation(8)],
                [new AdjacentSumOperation.Result(12)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new DiagonalSumOperation(0)], [new DiagonalSumOperation.Result(4)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new DiagonalSumOperation(2)], [new DiagonalSumOperation.Result(4)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new DiagonalSumOperation(6)], [new DiagonalSumOperation.Result(4)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new DiagonalSumOperation(8)], [new DiagonalSumOperation.Result(4)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new AdjacentSumOperation(1)], [new AdjacentSumOperation.Result(6)])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[0, 1, 2], [3, 4, 5], [6, 7, 8]],
                [new AdjacentSumOperation(3)],
                [new AdjacentSumOperation.Result(10)])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[0, 1, 2], [3, 4, 5], [6, 7, 8]],
                [new AdjacentSumOperation(5)],
                [new AdjacentSumOperation.Result(14)])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[0, 1, 2], [3, 4, 5], [6, 7, 8]],
                [new AdjacentSumOperation(7)],
                [new AdjacentSumOperation.Result(18)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new DiagonalSumOperation(1)], [new DiagonalSumOperation.Result(8)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new DiagonalSumOperation(3)], [new DiagonalSumOperation.Result(8)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new DiagonalSumOperation(5)], [new DiagonalSumOperation.Result(8)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[0, 1, 2], [3, 4, 5], [6, 7, 8]], [new DiagonalSumOperation(7)], [new DiagonalSumOperation.Result(8)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[10, 20], [30, 40]], [new AdjacentSumOperation(10)], [new AdjacentSumOperation.Result(50)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[10, 20], [30, 40]], [new DiagonalSumOperation(10)], [new DiagonalSumOperation.Result(40)])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]],
                [new AdjacentSumOperation(6)],
                [new AdjacentSumOperation.Result(28)])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]],
                [new DiagonalSumOperation(6)],
                [new DiagonalSumOperation.Result(24)])
        ];

        yield return
        [
            new NeighborSumServiceScenario(
                [[1000, 2000, 3000], [4000, 5000, 6000], [7000, 8000, 9000]],
                [new AdjacentSumOperation(5000), new DiagonalSumOperation(5000)],
                [new AdjacentSumOperation.Result(28000), new DiagonalSumOperation.Result(20000)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[100, 200]], [new AdjacentSumOperation(100), new DiagonalSumOperation(100)], [new AdjacentSumOperation.Result(200), new DiagonalSumOperation.Result(0)])
        ];

        yield return
        [
            new NeighborSumServiceScenario([[100], [200]], [new AdjacentSumOperation(100), new DiagonalSumOperation(100)], [new AdjacentSumOperation.Result(200), new DiagonalSumOperation.Result(0)])
        ];
    }

    public sealed class NeighborSumServiceScenario : IScenario<IDesignNeighborSumService>
    {
        public NeighborSumServiceScenario(int[][] grid, IOperation<IDesignNeighborSumService>[] operations, IOperationResult[] operationResults)
        {
            Grid = grid;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int[][] Grid { get; }

        public IOperation<IDesignNeighborSumService>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class AdjacentSumOperation : IOperation<IDesignNeighborSumService>
    {
        private readonly int _value;

        public AdjacentSumOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignNeighborSumService designNeighborSumService)
        {
            var sum = designNeighborSumService.AdjacentSum(_value);

            return new Result(sum);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _sum;

            public Result(int sum)
            {
                _sum = sum;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _sum == other._sum;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_sum);
            }
        }
    }

    private sealed class DiagonalSumOperation : IOperation<IDesignNeighborSumService>
    {
        private readonly int _value;

        public DiagonalSumOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignNeighborSumService designNeighborSumService)
        {
            var sum = designNeighborSumService.DiagonalSum(_value);

            return new Result(sum);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _sum;

            public Result(int sum)
            {
                _sum = sum;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _sum == other._sum;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_sum);
            }
        }
    }
}