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

using LeetCode.Algorithms.InsertDeleteGetRandom;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.InsertDeleteGetRandom;

public abstract class InsertDeleteGetRandomTestsBase<T> where T : IInsertDeleteGetRandom, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void InsertDeleteGetRandom_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IInsertDeleteGetRandom> scenario)
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

    private static IEnumerable<IScenario<IInsertDeleteGetRandom>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(1),
                    new RemoveOperation(2),
                    new InsertOperation(2),
                    new GetRandomOperation(),
                    new RemoveOperation(1),
                    new InsertOperation(2),
                    new GetRandomOperation(),
                    new RemoveOperation(1),
                    new RemoveOperation(2),
                    new InsertOperation(3),
                    new GetRandomOperation()
                ],
                [
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([1, 2]),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([2]),
                    new RemoveOperation.Result(false),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([3])
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [new InsertOperation(5), new InsertOperation(5), new GetRandomOperation()],
                [new InsertOperation.Result(true), new InsertOperation.Result(false), new GetRandomOperation.Result([5])])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [new InsertOperation(1), new RemoveOperation(99), new GetRandomOperation()],
                [new InsertOperation.Result(true), new RemoveOperation.Result(false), new GetRandomOperation.Result([1])])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [new InsertOperation(42), new GetRandomOperation(), new GetRandomOperation()],
                [new InsertOperation.Result(true), new GetRandomOperation.Result([42]), new GetRandomOperation.Result([42])])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new RemoveOperation(5),
                    new InsertOperation(3),
                    new InsertOperation(1),
                    new RemoveOperation(3),
                    new InsertOperation(4)
                ],
                [
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(2),
                    new InsertOperation(1),
                    new GetRandomOperation(),
                    new RemoveOperation(3),
                    new InsertOperation(2),
                    new InsertOperation(4)
                ],
                [
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([1, 2]),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(3),
                    new GetRandomOperation(),
                    new RemoveOperation(3),
                    new RemoveOperation(2),
                    new InsertOperation(5),
                    new InsertOperation(4),
                    new InsertOperation(2),
                    new InsertOperation(3)
                ],
                [
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([3]),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new RemoveOperation(5),
                    new InsertOperation(3),
                    new GetRandomOperation(),
                    new InsertOperation(4),
                    new InsertOperation(1),
                    new InsertOperation(1),
                    new RemoveOperation(5),
                    new InsertOperation(4),
                    new InsertOperation(4),
                    new InsertOperation(1)
                ],
                [
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([3]),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(1),
                    new GetRandomOperation(),
                    new RemoveOperation(4),
                    new InsertOperation(3),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new RemoveOperation(4),
                    new InsertOperation(1),
                    new GetRandomOperation(),
                    new InsertOperation(1),
                    new GetRandomOperation()
                ],
                [
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([1]),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([1, 3]),
                    new GetRandomOperation.Result([1, 3]),
                    new GetRandomOperation.Result([1, 3]),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([1, 3]),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([1, 3])
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new RemoveOperation(3),
                    new InsertOperation(5),
                    new RemoveOperation(3),
                    new RemoveOperation(3),
                    new GetRandomOperation(),
                    new InsertOperation(4),
                    new RemoveOperation(3),
                    new GetRandomOperation(),
                    new RemoveOperation(1),
                    new GetRandomOperation(),
                    new InsertOperation(1),
                    new InsertOperation(4),
                    new GetRandomOperation(),
                    new InsertOperation(2),
                    new RemoveOperation(5)
                ],
                [
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([5]),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([4, 5]),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([4, 5]),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([1, 4, 5]),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(5),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new RemoveOperation(4),
                    new InsertOperation(2),
                    new RemoveOperation(5),
                    new RemoveOperation(1),
                    new RemoveOperation(4),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new InsertOperation(4),
                    new RemoveOperation(2),
                    new RemoveOperation(3),
                    new RemoveOperation(5),
                    new RemoveOperation(2),
                    new RemoveOperation(3),
                    new InsertOperation(5),
                    new GetRandomOperation(),
                    new InsertOperation(5),
                    new RemoveOperation(1)
                ],
                [
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([5]),
                    new GetRandomOperation.Result([5]),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([2]),
                    new GetRandomOperation.Result([2]),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([4, 5]),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(2),
                    new RemoveOperation(3),
                    new GetRandomOperation(),
                    new InsertOperation(5),
                    new InsertOperation(5),
                    new InsertOperation(4),
                    new InsertOperation(2),
                    new InsertOperation(4),
                    new InsertOperation(5),
                    new GetRandomOperation(),
                    new RemoveOperation(2),
                    new RemoveOperation(5),
                    new InsertOperation(1),
                    new RemoveOperation(5),
                    new InsertOperation(3),
                    new InsertOperation(3),
                    new InsertOperation(3),
                    new RemoveOperation(5),
                    new GetRandomOperation(),
                    new RemoveOperation(3),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new InsertOperation(3),
                    new RemoveOperation(4),
                    new RemoveOperation(5)
                ],
                [
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([2]),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([2, 4, 5]),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([1, 3, 4]),
                    new RemoveOperation.Result(true),
                    new GetRandomOperation.Result([1, 4]),
                    new GetRandomOperation.Result([1, 4]),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new RemoveOperation(2),
                    new InsertOperation(2),
                    new InsertOperation(1),
                    new InsertOperation(2),
                    new InsertOperation(3),
                    new GetRandomOperation(),
                    new InsertOperation(3),
                    new InsertOperation(5),
                    new GetRandomOperation(),
                    new RemoveOperation(4),
                    new InsertOperation(1),
                    new RemoveOperation(3),
                    new InsertOperation(2),
                    new RemoveOperation(1),
                    new InsertOperation(1),
                    new GetRandomOperation(),
                    new InsertOperation(1),
                    new InsertOperation(3),
                    new InsertOperation(2),
                    new GetRandomOperation(),
                    new RemoveOperation(4),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new InsertOperation(1),
                    new RemoveOperation(2),
                    new GetRandomOperation(),
                    new RemoveOperation(5),
                    new RemoveOperation(5),
                    new InsertOperation(1),
                    new InsertOperation(2)
                ],
                [
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([1, 2, 3]),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([1, 2, 3, 5]),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([1, 2, 5]),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([1, 2, 3, 5]),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([1, 2, 3, 5]),
                    new GetRandomOperation.Result([1, 2, 3, 5]),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(true),
                    new GetRandomOperation.Result([1, 3, 5]),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(-2147483648),
                    new GetRandomOperation(),
                    new InsertOperation(-2147483648),
                    new RemoveOperation(2147483647),
                    new RemoveOperation(2147483647),
                    new InsertOperation(-2147483648),
                    new InsertOperation(2147483647),
                    new InsertOperation(2147483647),
                    new GetRandomOperation(),
                    new InsertOperation(-1),
                    new GetRandomOperation(),
                    new RemoveOperation(0),
                    new RemoveOperation(2147483647),
                    new RemoveOperation(2147483647),
                    new GetRandomOperation()
                ],
                [
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([-2147483648]),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([-2147483648, 2147483647]),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([-2147483648, -1, 2147483647]),
                    new RemoveOperation.Result(false),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([-2147483648, -1])
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new RemoveOperation(2147483647),
                    new InsertOperation(-2147483648),
                    new InsertOperation(-2147483648),
                    new InsertOperation(7),
                    new RemoveOperation(2147483647),
                    new InsertOperation(0),
                    new RemoveOperation(-1),
                    new InsertOperation(-1),
                    new RemoveOperation(-2147483648),
                    new RemoveOperation(1),
                    new InsertOperation(2147483647),
                    new RemoveOperation(0),
                    new GetRandomOperation(),
                    new InsertOperation(7),
                    new RemoveOperation(2147483647),
                    new InsertOperation(2147483647),
                    new RemoveOperation(1),
                    new GetRandomOperation(),
                    new InsertOperation(1),
                    new GetRandomOperation()
                ],
                [
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new GetRandomOperation.Result([-1, 7, 2147483647]),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([-1, 7, 2147483647]),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([-1, 1, 7, 2147483647])
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new RemoveOperation(-1),
                    new InsertOperation(2),
                    new InsertOperation(-3),
                    new InsertOperation(-1),
                    new GetRandomOperation(),
                    new InsertOperation(-3),
                    new InsertOperation(0),
                    new GetRandomOperation(),
                    new RemoveOperation(0),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new InsertOperation(1),
                    new GetRandomOperation(),
                    new InsertOperation(0),
                    new RemoveOperation(0),
                    new InsertOperation(1),
                    new RemoveOperation(-2),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new GetRandomOperation()
                ],
                [
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([-3, -1, 2]),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([-3, -1, 0, 2]),
                    new RemoveOperation.Result(true),
                    new GetRandomOperation.Result([-3, -1, 2]),
                    new GetRandomOperation.Result([-3, -1, 2]),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([-3, -1, 1, 2]),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([-3, -1, 1, 2]),
                    new GetRandomOperation.Result([-3, -1, 1, 2]),
                    new GetRandomOperation.Result([-3, -1, 1, 2])
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(12),
                    new GetRandomOperation(),
                    new RemoveOperation(15),
                    new InsertOperation(12),
                    new RemoveOperation(10),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new InsertOperation(11),
                    new InsertOperation(10),
                    new InsertOperation(13),
                    new RemoveOperation(16),
                    new InsertOperation(10),
                    new InsertOperation(13),
                    new RemoveOperation(16),
                    new InsertOperation(12),
                    new GetRandomOperation(),
                    new InsertOperation(18),
                    new InsertOperation(17),
                    new InsertOperation(12),
                    new GetRandomOperation(),
                    new InsertOperation(15),
                    new RemoveOperation(13),
                    new InsertOperation(19),
                    new InsertOperation(10),
                    new InsertOperation(16)
                ],
                [
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([12]),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([12]),
                    new GetRandomOperation.Result([12]),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([10, 11, 12, 13]),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([10, 11, 12, 13, 17, 18]),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(6),
                    new RemoveOperation(6),
                    new InsertOperation(7),
                    new RemoveOperation(6),
                    new GetRandomOperation(),
                    new InsertOperation(4),
                    new GetRandomOperation(),
                    new InsertOperation(1),
                    new InsertOperation(5),
                    new InsertOperation(1),
                    new GetRandomOperation(),
                    new InsertOperation(4),
                    new InsertOperation(7),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new InsertOperation(2),
                    new RemoveOperation(4),
                    new InsertOperation(3),
                    new InsertOperation(4),
                    new GetRandomOperation(),
                    new RemoveOperation(4),
                    new RemoveOperation(4),
                    new GetRandomOperation(),
                    new RemoveOperation(6),
                    new InsertOperation(5),
                    new RemoveOperation(3),
                    new RemoveOperation(4),
                    new InsertOperation(5),
                    new InsertOperation(1),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new RemoveOperation(6),
                    new InsertOperation(6),
                    new GetRandomOperation(),
                    new GetRandomOperation(),
                    new RemoveOperation(7),
                    new InsertOperation(5),
                    new RemoveOperation(7),
                    new GetRandomOperation(),
                    new GetRandomOperation()
                ],
                [
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([7]),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([4, 7]),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([1, 4, 5, 7]),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([1, 4, 5, 7]),
                    new GetRandomOperation.Result([1, 4, 5, 7]),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([1, 2, 3, 4, 5, 7]),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([1, 2, 3, 5, 7]),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(false),
                    new InsertOperation.Result(false),
                    new GetRandomOperation.Result([1, 2, 5, 7]),
                    new GetRandomOperation.Result([1, 2, 5, 7]),
                    new RemoveOperation.Result(false),
                    new InsertOperation.Result(true),
                    new GetRandomOperation.Result([1, 2, 5, 6, 7]),
                    new GetRandomOperation.Result([1, 2, 5, 6, 7]),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(false),
                    new RemoveOperation.Result(false),
                    new GetRandomOperation.Result([1, 2, 5, 6]),
                    new GetRandomOperation.Result([1, 2, 5, 6])
                ])
        ];

        yield return
        [
            new Scenario<IInsertDeleteGetRandom>(
                [
                    new InsertOperation(1),
                    new InsertOperation(2),
                    new InsertOperation(3),
                    new InsertOperation(4),
                    new InsertOperation(5),
                    new InsertOperation(6),
                    new InsertOperation(7),
                    new InsertOperation(8),
                    new InsertOperation(9),
                    new InsertOperation(10),
                    new RemoveOperation(1),
                    new RemoveOperation(2),
                    new RemoveOperation(3),
                    new RemoveOperation(4),
                    new RemoveOperation(5),
                    new RemoveOperation(6),
                    new RemoveOperation(7),
                    new RemoveOperation(8),
                    new RemoveOperation(9),
                    new GetRandomOperation(),
                    new RemoveOperation(10),
                    new InsertOperation(10)
                ],
                [
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new InsertOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new RemoveOperation.Result(true),
                    new GetRandomOperation.Result([10]),
                    new RemoveOperation.Result(true),
                    new InsertOperation.Result(true)
                ])
        ];
    }

    private sealed class InsertOperation : IOperation<IInsertDeleteGetRandom>
    {
        private readonly int _value;

        public InsertOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IInsertDeleteGetRandom insertDeleteGetRandom)
        {
            var result = insertDeleteGetRandom.Insert(_value);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _inserted;

            public Result(bool inserted)
            {
                _inserted = inserted;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _inserted == other._inserted;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_inserted);
            }
        }
    }

    private sealed class RemoveOperation : IOperation<IInsertDeleteGetRandom>
    {
        private readonly int _value;

        public RemoveOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IInsertDeleteGetRandom insertDeleteGetRandom)
        {
            var result = insertDeleteGetRandom.Remove(_value);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _removed;

            public Result(bool removed)
            {
                _removed = removed;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _removed == other._removed;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_removed);
            }
        }
    }

    private sealed class GetRandomOperation : IOperation<IInsertDeleteGetRandom>
    {
        public IOperationResult Execute(IInsertDeleteGetRandom insertDeleteGetRandom)
        {
            var value = insertDeleteGetRandom.GetRandom();

            return new Result([value]);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int[] _validOptions;

            public Result(int[] validOptions)
            {
                _validOptions = validOptions;
            }

            public bool Equals(Result? other)
            {
                if (other is null)
                {
                    return false;
                }

                var otherValidOptions = other._validOptions;

                for (var i = 0; i < otherValidOptions.Length; i++)
                {
                    var option = otherValidOptions[i];

                    for (var j = 0; j < _validOptions.Length; j++)
                    {
                        if (_validOptions[j] == option)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }
    }
}