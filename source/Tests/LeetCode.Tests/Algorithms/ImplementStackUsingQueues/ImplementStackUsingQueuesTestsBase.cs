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

using LeetCode.Algorithms.ImplementStackUsingQueues;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.ImplementStackUsingQueues;

public abstract class ImplementStackUsingQueuesTestsBase<T> where T : IImplementStackUsingQueues, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void ImplementStackUsingQueues_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        IScenario<IImplementStackUsingQueues> scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = new T();

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

    private static IEnumerable<IScenario<IImplementStackUsingQueues>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [new PushOperation(1), new PushOperation(2), new PushOperation(3), new TopOperation(), new PopOperation(), new TopOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(3),
                    new PopOperation.Result(3),
                    new TopOperation.Result(2)
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(5),
                    new PushOperation(10),
                    new PushOperation(15),
                    new PushOperation(20),
                    new TopOperation(),
                    new PopOperation(),
                    new TopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TopOperation.Result(20),
                    new PopOperation.Result(20),
                    new TopOperation.Result(15)
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [new PushOperation(42), new TopOperation(), new PopOperation()],
                [VoidOperationResult.Instance, new TopOperation.Result(42), new PopOperation.Result(42)])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [new PushOperation(0), new EmptyOperation()],
                [VoidOperationResult.Instance, new EmptyOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(1),
                    new PushOperation(2),
                    new PushOperation(3),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(3),
                    new PopOperation.Result(2),
                    new PopOperation.Result(1),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementStackUsingQueues>(
                [
                    new PushOperation(5),
                    new PushOperation(10),
                    new PushOperation(15),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(15),
                    new PopOperation.Result(10),
                    new PopOperation.Result(5),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return [new Scenario<IImplementStackUsingQueues>([new EmptyOperation()], [new EmptyOperation.Result(true)])];
    }

    private sealed class PushOperation : IOperation<IImplementStackUsingQueues>
    {
        private readonly int _value;

        public PushOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IImplementStackUsingQueues solution)
        {
            solution.Push(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class PopOperation : IOperation<IImplementStackUsingQueues>
    {
        public IOperationResult Execute(IImplementStackUsingQueues solution)
        {
            var result = solution.Pop();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _value;

            public Result(int value)
            {
                _value = value;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _value == other._value;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_value);
            }
        }
    }

    private sealed class TopOperation : IOperation<IImplementStackUsingQueues>
    {
        public IOperationResult Execute(IImplementStackUsingQueues solution)
        {
            var result = solution.Top();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _value;

            public Result(int value)
            {
                _value = value;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _value == other._value;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_value);
            }
        }
    }

    private sealed class EmptyOperation : IOperation<IImplementStackUsingQueues>
    {
        public IOperationResult Execute(IImplementStackUsingQueues solution)
        {
            var result = solution.Empty();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _value;

            public Result(bool value)
            {
                _value = value;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _value == other._value;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_value);
            }
        }
    }
}