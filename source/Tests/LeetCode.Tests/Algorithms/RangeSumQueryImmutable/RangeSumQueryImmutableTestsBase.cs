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

using LeetCode.Algorithms.RangeSumQueryImmutable;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.RangeSumQueryImmutable;

public abstract class RangeSumQueryImmutableTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void RangeSumQueryImmutable_WithGivenArrayAndRangeQueries_ProcessesOperationsAccordingToSpecification(
        RangeSumQueryScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Nums);

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
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IRangeSumQueryImmutable GetSolution(int[] nums);

    private static IEnumerable<RangeSumQueryScenario[]> GetScenarios()
    {
        yield return
        [
            new RangeSumQueryScenario([-2, 0, 3, -5, 2, -1],
                [
                    new SumRangeOperation(0, 2),
                    new SumRangeOperation(2, 5),
                    new SumRangeOperation(0, 5)
                ],
                [
                    new SumRangeOperation.Result(1),
                    new SumRangeOperation.Result(-1),
                    new SumRangeOperation.Result(-3)
                ])
        ];

        yield return
        [
            new RangeSumQueryScenario([5],
                [
                    new SumRangeOperation(0, 0)
                ],
                [
                    new SumRangeOperation.Result(5)
                ])
        ];

        yield return
        [
            new RangeSumQueryScenario([1, 2, 3, 4, 5],
                [
                    new SumRangeOperation(0, 4),
                    new SumRangeOperation(1, 3),
                    new SumRangeOperation(2, 2)
                ],
                [
                    new SumRangeOperation.Result(15),
                    new SumRangeOperation.Result(9),
                    new SumRangeOperation.Result(3)
                ])
        ];

        yield return
        [
            new RangeSumQueryScenario([-3, -2, -1],
                [
                    new SumRangeOperation(0, 2),
                    new SumRangeOperation(0, 1),
                    new SumRangeOperation(1, 2)
                ],
                [
                    new SumRangeOperation.Result(-6),
                    new SumRangeOperation.Result(-5),
                    new SumRangeOperation.Result(-3)
                ])
        ];

        yield return
        [
            new RangeSumQueryScenario([10, 20, 30],
                [
                    new SumRangeOperation(0, 0),
                    new SumRangeOperation(1, 1),
                    new SumRangeOperation(2, 2)
                ],
                [
                    new SumRangeOperation.Result(10),
                    new SumRangeOperation.Result(20),
                    new SumRangeOperation.Result(30)
                ])
        ];
    }

    public sealed class RangeSumQueryScenario : Scenario<IRangeSumQueryImmutable>
    {
        public RangeSumQueryScenario(int[] nums, IOperation<IRangeSumQueryImmutable>[] operations,
            IOperationResult[] operationResults) : base(operations, operationResults)
        {
            Nums = nums;
        }

        public int[] Nums { get; }
    }

    private sealed class SumRangeOperation : IOperation<IRangeSumQueryImmutable>
    {
        private readonly int _left;
        private readonly int _right;

        public SumRangeOperation(int left, int right)
        {
            _left = left;
            _right = right;
        }

        public IOperationResult Execute(IRangeSumQueryImmutable rangeSumQueryImmutable)
        {
            var sum = rangeSumQueryImmutable.SumRange(_left, _right);

            return new Result(sum);
        }

        public sealed class Result : IOperationResult, IEquatable<Result>
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