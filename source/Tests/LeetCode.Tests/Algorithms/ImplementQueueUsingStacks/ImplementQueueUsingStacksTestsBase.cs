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

using LeetCode.Algorithms.ImplementQueueUsingStacks;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.ImplementQueueUsingStacks;

public abstract class ImplementQueueUsingStacksTestsBase<T> where T : IImplementQueueUsingStacks, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void ImplementQueueUsingStacks_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        IScenario<IImplementQueueUsingStacks> scenario)
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

    [TestMethod]
    public void Pop_OnEmptyQueue_ThrowsInvalidOperationException()
    {
        // Arrange
        var solution = new T();

        // Act & Assert
        Assert.ThrowsExactly<InvalidOperationException>(() => solution.Pop());
    }

    [TestMethod]
    public void Peek_OnEmptyQueue_ThrowsInvalidOperationException()
    {
        // Arrange
        var solution = new T();

        // Act & Assert
        Assert.ThrowsExactly<InvalidOperationException>(() => solution.Peek());
    }

    private static IEnumerable<IScenario<IImplementQueueUsingStacks>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
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
                    new PopOperation.Result(1),
                    new PopOperation.Result(2),
                    new PopOperation.Result(3),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
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
                    new PopOperation.Result(5),
                    new PopOperation.Result(10),
                    new PopOperation.Result(15),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return [new Scenario<IImplementQueueUsingStacks>([new EmptyOperation()], [new EmptyOperation.Result(true)])];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(42), new PopOperation(), new EmptyOperation()],
                [VoidOperationResult.Instance, new PopOperation.Result(42), new EmptyOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [
                    new PushOperation(0),
                    new PushOperation(0),
                    new PushOperation(0),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(0),
                    new PopOperation.Result(0),
                    new PopOperation.Result(0),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [
                    new PushOperation(-1),
                    new PushOperation(-2),
                    new PushOperation(-3),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(-1),
                    new PopOperation.Result(-2),
                    new PopOperation.Result(-3),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [
                    new PushOperation(1),
                    new PushOperation(2),
                    new PushOperation(3),
                    new PushOperation(4),
                    new PushOperation(5),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(1),
                    new PopOperation.Result(2),
                    new PopOperation.Result(3),
                    new PopOperation.Result(4),
                    new PopOperation.Result(5),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [
                    new PushOperation(100),
                    new PushOperation(200),
                    new PushOperation(300),
                    new PushOperation(400),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(100),
                    new PopOperation.Result(200),
                    new PopOperation.Result(300),
                    new PopOperation.Result(400),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(7), new PopOperation(), new EmptyOperation()],
                [VoidOperationResult.Instance, new PopOperation.Result(7), new EmptyOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [
                    new PushOperation(1),
                    new PushOperation(1),
                    new PushOperation(1),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new EmptyOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(1),
                    new PopOperation.Result(1),
                    new PopOperation.Result(1),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(1), new PushOperation(2), new PushOperation(3), new PeekOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PeekOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(5), new PushOperation(10), new PushOperation(15), new PeekOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PeekOperation.Result(5)])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(42), new PeekOperation()],
                [VoidOperationResult.Instance, new PeekOperation.Result(42)])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(-1), new PushOperation(-2), new PushOperation(-3), new PeekOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PeekOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(0), new PushOperation(1), new PushOperation(2), new PeekOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new PeekOperation.Result(0)])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(100), new PushOperation(200), new PeekOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new PeekOperation.Result(100)])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(7), new PushOperation(8), new PushOperation(9), new PushOperation(10), new PeekOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PeekOperation.Result(7)
                ])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(1), new PushOperation(2), new PeekOperation(), new PeekOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new PeekOperation.Result(1), new PeekOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new EmptyOperation(), new PushOperation(1), new EmptyOperation(), new PopOperation(), new EmptyOperation()],
                [
                    new EmptyOperation.Result(true),
                    VoidOperationResult.Instance,
                    new EmptyOperation.Result(false),
                    new PopOperation.Result(1),
                    new EmptyOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementQueueUsingStacks>(
                [new PushOperation(0), new EmptyOperation()],
                [VoidOperationResult.Instance, new EmptyOperation.Result(false)])
        ];
    }

    private sealed class PushOperation : IOperation<IImplementQueueUsingStacks>
    {
        private readonly int _value;

        public PushOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IImplementQueueUsingStacks solution)
        {
            solution.Push(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class PopOperation : IOperation<IImplementQueueUsingStacks>
    {
        public IOperationResult Execute(IImplementQueueUsingStacks solution)
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

    private sealed class PeekOperation : IOperation<IImplementQueueUsingStacks>
    {
        public IOperationResult Execute(IImplementQueueUsingStacks solution)
        {
            var result = solution.Peek();

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

    private sealed class EmptyOperation : IOperation<IImplementQueueUsingStacks>
    {
        public IOperationResult Execute(IImplementQueueUsingStacks solution)
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