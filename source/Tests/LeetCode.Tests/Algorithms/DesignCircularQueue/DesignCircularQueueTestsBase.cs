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

using LeetCode.Algorithms.DesignCircularQueue;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignCircularQueue;

public abstract class DesignCircularQueueTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignCircularQueue_WithMixedOperations_ProcessesOperationsAccordingToSpecification(CircularQueueScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.K);

        // Act
        var operations = scenario.Operations;
        var operationsLength = operations.Length;

        var actualResult = new IOperationResult?[operationsLength];

        for (var i = 0; i < operationsLength; i++)
        {
            var operation = operations[i];

            actualResult[i] = operation.Execute(solution);
        }

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    protected abstract IDesignCircularQueue GetSolution(int k);

    private static IEnumerable<CircularQueueScenario[]> GetScenarios()
    {
        yield return
        [
            new CircularQueueScenario(
                3,
                [
                    new EnQueueOperation(1),
                    new EnQueueOperation(2),
                    new EnQueueOperation(3),
                    new EnQueueOperation(4),
                    new RearOperation(),
                    new IsFullOperation(),
                    new DeQueueOperation(),
                    new EnQueueOperation(4),
                    new RearOperation()
                ],
                [
                    new EnQueueOperation.Result(true),
                    new EnQueueOperation.Result(true),
                    new EnQueueOperation.Result(true),
                    new EnQueueOperation.Result(false),
                    new RearOperation.Result(3),
                    new IsFullOperation.Result(true),
                    new DeQueueOperation.Result(true),
                    new EnQueueOperation.Result(true),
                    new RearOperation.Result(4)
                ])
        ];

        yield return
        [
            new CircularQueueScenario(
                1,
                [new EnQueueOperation(1), new EnQueueOperation(2), new FrontOperation(), new DeQueueOperation(), new IsEmptyOperation()],
                [
                    new EnQueueOperation.Result(true),
                    new EnQueueOperation.Result(false),
                    new FrontOperation.Result(1),
                    new DeQueueOperation.Result(true),
                    new IsEmptyOperation.Result(true)
                ])
        ];

        yield return
        [
            new CircularQueueScenario(
                2,
                [
                    new IsEmptyOperation(),
                    new EnQueueOperation(5),
                    new EnQueueOperation(6),
                    new IsFullOperation(),
                    new RearOperation(),
                    new FrontOperation(),
                    new DeQueueOperation(),
                    new RearOperation()
                ],
                [
                    new IsEmptyOperation.Result(true),
                    new EnQueueOperation.Result(true),
                    new EnQueueOperation.Result(true),
                    new IsFullOperation.Result(true),
                    new RearOperation.Result(6),
                    new FrontOperation.Result(5),
                    new DeQueueOperation.Result(true),
                    new RearOperation.Result(6)
                ])
        ];

        yield return
        [
            new CircularQueueScenario(
                3,
                [new FrontOperation(), new RearOperation(), new DeQueueOperation()],
                [new FrontOperation.Result(-1), new RearOperation.Result(-1), new DeQueueOperation.Result(false)])
        ];
    }

    public sealed class CircularQueueScenario : IScenario<IDesignCircularQueue>
    {
        public CircularQueueScenario(int k, IOperation<IDesignCircularQueue>[] operations, IOperationResult[] operationResults)
        {
            K = k;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int K { get; }

        public IOperation<IDesignCircularQueue>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class EnQueueOperation : IOperation<IDesignCircularQueue>
    {
        private readonly int _value;

        public EnQueueOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignCircularQueue designCircularQueue)
        {
            var result = designCircularQueue.EnQueue(_value);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _success;

            public Result(bool success)
            {
                _success = success;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _success == other._success;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_success);
            }
        }
    }

    private sealed class DeQueueOperation : IOperation<IDesignCircularQueue>
    {
        public IOperationResult Execute(IDesignCircularQueue designCircularQueue)
        {
            var result = designCircularQueue.DeQueue();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _success;

            public Result(bool success)
            {
                _success = success;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _success == other._success;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_success);
            }
        }
    }

    private sealed class FrontOperation : IOperation<IDesignCircularQueue>
    {
        public IOperationResult Execute(IDesignCircularQueue designCircularQueue)
        {
            var value = designCircularQueue.Front();

            return new Result(value);
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

    private sealed class RearOperation : IOperation<IDesignCircularQueue>
    {
        public IOperationResult Execute(IDesignCircularQueue designCircularQueue)
        {
            var value = designCircularQueue.Rear();

            return new Result(value);
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

    private sealed class IsEmptyOperation : IOperation<IDesignCircularQueue>
    {
        public IOperationResult Execute(IDesignCircularQueue designCircularQueue)
        {
            var result = designCircularQueue.IsEmpty();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _isEmpty;

            public Result(bool isEmpty)
            {
                _isEmpty = isEmpty;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _isEmpty == other._isEmpty;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_isEmpty);
            }
        }
    }

    private sealed class IsFullOperation : IOperation<IDesignCircularQueue>
    {
        public IOperationResult Execute(IDesignCircularQueue designCircularQueue)
        {
            var result = designCircularQueue.IsFull();

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _isFull;

            public Result(bool isFull)
            {
                _isFull = isFull;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _isFull == other._isFull;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_isFull);
            }
        }
    }
}