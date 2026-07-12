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

using LeetCode.Algorithms.RangeSumQueryMutable;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.RangeSumQueryMutable;

public abstract class RangeSumQueryMutableTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void RangeSumQueryMutable_WithGivenArrayAndRangeQueries_ProcessesOperationsAccordingToSpecification(RangeSumQueryMutableScenario scenario)
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

    protected abstract IRangeSumQueryMutable GetSolution(int[] nums);

    private static IEnumerable<RangeSumQueryMutableScenario[]> GetScenarios()
    {
        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 3, 5],
                [new SumRangeOperation(0, 2), new UpdateOperation(1, 2), new SumRangeOperation(0, 2)],
                [new SumRangeOperation.Result(9), VoidOperationResult.Instance, new SumRangeOperation.Result(8)])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 2, 3],
                [new UpdateOperation(1, 10), new UpdateOperation(1, 5), new SumRangeOperation(0, 2)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new SumRangeOperation.Result(9)])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 2, 3, 4, 5],
                [new SumRangeOperation(0, 4), new UpdateOperation(0, 10), new UpdateOperation(4, 10), new SumRangeOperation(0, 4)],
                [new SumRangeOperation.Result(15), VoidOperationResult.Instance, VoidOperationResult.Instance, new SumRangeOperation.Result(29)])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [7],
                [new SumRangeOperation(0, 0), new UpdateOperation(0, 3), new SumRangeOperation(0, 0)],
                [new SumRangeOperation.Result(7), VoidOperationResult.Instance, new SumRangeOperation.Result(3)])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 2, 3],
                [new SumRangeOperation(1, 1), new UpdateOperation(0, 100), new SumRangeOperation(1, 1)],
                [new SumRangeOperation.Result(2), VoidOperationResult.Instance, new SumRangeOperation.Result(2)])
        ];
    }

    public sealed class RangeSumQueryMutableScenario : IScenario<IRangeSumQueryMutable>
    {
        public RangeSumQueryMutableScenario(int[] nums, IOperation<IRangeSumQueryMutable>[] operations, IOperationResult[] operationResults)
        {
            Nums = nums;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int[] Nums { get; }

        public IOperation<IRangeSumQueryMutable>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class UpdateOperation : IOperation<IRangeSumQueryMutable>
    {
        private readonly int _index;
        private readonly int _value;

        public UpdateOperation(int index, int value)
        {
            _index = index;
            _value = value;
        }

        public IOperationResult Execute(IRangeSumQueryMutable rangeSumQueryMutable)
        {
            rangeSumQueryMutable.Update(_index, _value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class SumRangeOperation : IOperation<IRangeSumQueryMutable>
    {
        private readonly int _left;
        private readonly int _right;

        public SumRangeOperation(int left, int right)
        {
            _left = left;
            _right = right;
        }

        public IOperationResult Execute(IRangeSumQueryMutable rangeSumQueryMutable)
        {
            var sum = rangeSumQueryMutable.SumRange(_left, _right);

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