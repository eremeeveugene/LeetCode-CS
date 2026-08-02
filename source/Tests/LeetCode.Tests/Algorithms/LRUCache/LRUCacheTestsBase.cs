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

using LeetCode.Algorithms.LRUCache;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.LRUCache;

public abstract class LRUCacheTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void LRUCache_WithMixedOperations_ProcessesOperationsAccordingToSpecification(LRUCacheScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Capacity);

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

    protected abstract ILRUCache GetSolution(int capacity);

    private static IEnumerable<LRUCacheScenario[]> GetScenarios()
    {
        yield return
        [
            new LRUCacheScenario(
                2,
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new GetOperation(1),
                    new PutOperation(3, 3),
                    new GetOperation(2),
                    new PutOperation(4, 4),
                    new GetOperation(1),
                    new GetOperation(3),
                    new GetOperation(4)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(3),
                    new GetOperation.Result(4)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                1,
                [new PutOperation(1, 1), new GetOperation(1), new PutOperation(2, 2), new GetOperation(1), new GetOperation(2)],
                [
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(2)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                3,
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new PutOperation(3, 3),
                    new GetOperation(1),
                    new PutOperation(4, 4),
                    new GetOperation(2),
                    new GetOperation(3),
                    new GetOperation(4)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(3),
                    new GetOperation.Result(4)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                2,
                [new PutOperation(1, 10), new PutOperation(2, 20), new PutOperation(1, 100), new GetOperation(1), new GetOperation(2)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(100),
                    new GetOperation.Result(20)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                1,
                [new PutOperation(5, 50), new PutOperation(5, 60), new GetOperation(5), new PutOperation(5, 70), new GetOperation(5)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(60),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(70)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                2,
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new GetOperation(1),
                    new PutOperation(3, 3),
                    new PutOperation(1, 1),
                    new GetOperation(2),
                    new GetOperation(3),
                    new GetOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(3),
                    new GetOperation.Result(1)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                4,
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new PutOperation(3, 3),
                    new PutOperation(4, 4),
                    new GetOperation(1),
                    new GetOperation(2),
                    new GetOperation(3),
                    new GetOperation(4)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(2),
                    new GetOperation.Result(3),
                    new GetOperation.Result(4)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                2,
                [new GetOperation(1), new GetOperation(2), new PutOperation(1, 1), new GetOperation(1), new GetOperation(2)],
                [
                    new GetOperation.Result(-1),
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                3,
                [
                    new PutOperation(1, 0),
                    new PutOperation(2, -5),
                    new PutOperation(3, 100),
                    new GetOperation(1),
                    new GetOperation(2),
                    new GetOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(0),
                    new GetOperation.Result(-5),
                    new GetOperation.Result(100)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                2,
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new PutOperation(3, 3),
                    new PutOperation(4, 4),
                    new GetOperation(1),
                    new GetOperation(2),
                    new GetOperation(3),
                    new GetOperation(4)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(-1),
                    new GetOperation.Result(3),
                    new GetOperation.Result(4)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                1,
                [
                    new GetOperation(10),
                    new PutOperation(10, 100),
                    new GetOperation(10),
                    new PutOperation(20, 200),
                    new GetOperation(10),
                    new GetOperation(20)
                ],
                [
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(100),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(200)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                3,
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new PutOperation(3, 3),
                    new GetOperation(1),
                    new PutOperation(4, 4),
                    new GetOperation(2),
                    new PutOperation(5, 5),
                    new GetOperation(1),
                    new GetOperation(3),
                    new GetOperation(4),
                    new GetOperation(5)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(-1),
                    new GetOperation.Result(4),
                    new GetOperation.Result(5)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                2,
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new PutOperation(1, 10),
                    new PutOperation(3, 3),
                    new GetOperation(1),
                    new GetOperation(2),
                    new GetOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(10),
                    new GetOperation.Result(-1),
                    new GetOperation.Result(3)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                2,
                [new PutOperation(1, 1), new PutOperation(1, 2), new PutOperation(1, 3), new PutOperation(1, 4), new GetOperation(1)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(4)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                3,
                [
                    new PutOperation(1, 1),
                    new GetOperation(2),
                    new PutOperation(2, 2),
                    new GetOperation(3),
                    new PutOperation(3, 3),
                    new GetOperation(1),
                    new GetOperation(2),
                    new GetOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(2),
                    new GetOperation.Result(3)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                4,
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new PutOperation(3, 3),
                    new PutOperation(4, 4),
                    new PutOperation(5, 5),
                    new PutOperation(6, 6),
                    new PutOperation(7, 7),
                    new GetOperation(1),
                    new GetOperation(2),
                    new GetOperation(3),
                    new GetOperation(4),
                    new GetOperation(5),
                    new GetOperation(6),
                    new GetOperation(7)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(-1),
                    new GetOperation.Result(-1),
                    new GetOperation.Result(4),
                    new GetOperation.Result(5),
                    new GetOperation.Result(6),
                    new GetOperation.Result(7)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                2,
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new GetOperation(1),
                    new PutOperation(3, 3),
                    new GetOperation(1),
                    new PutOperation(4, 4),
                    new GetOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                1,
                [
                    new PutOperation(1, 1),
                    new PutOperation(1, 2),
                    new PutOperation(2, 3),
                    new GetOperation(1),
                    new GetOperation(2),
                    new PutOperation(1, 4),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(3),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(4),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                3,
                [
                    new PutOperation(10, 1),
                    new PutOperation(20, 2),
                    new PutOperation(30, 3),
                    new GetOperation(10),
                    new GetOperation(20),
                    new PutOperation(40, 4),
                    new GetOperation(30),
                    new PutOperation(50, 5),
                    new GetOperation(10),
                    new GetOperation(20),
                    new GetOperation(40),
                    new GetOperation(50)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(2),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(2),
                    new GetOperation.Result(4),
                    new GetOperation.Result(5)
                ])
        ];

        yield return
        [
            new LRUCacheScenario(
                2,
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new PutOperation(3, 3),
                    new GetOperation(1),
                    new PutOperation(2, 20),
                    new GetOperation(3),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(3),
                    new GetOperation.Result(20)
                ])
        ];
    }

    public sealed class LRUCacheScenario : IScenario<ILRUCache>
    {
        public LRUCacheScenario(int capacity, IOperation<ILRUCache>[] operations, IOperationResult[] operationResults)
        {
            Capacity = capacity;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int Capacity { get; }

        public IOperation<ILRUCache>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class GetOperation : IOperation<ILRUCache>
    {
        private readonly int _key;

        public GetOperation(int key)
        {
            _key = key;
        }

        public IOperationResult Execute(ILRUCache lruCache)
        {
            var value = lruCache.Get(_key);

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

    private sealed class PutOperation : IOperation<ILRUCache>
    {
        private readonly int _key;
        private readonly int _value;

        public PutOperation(int key, int value)
        {
            _key = key;
            _value = value;
        }

        public IOperationResult Execute(ILRUCache lruCache)
        {
            lruCache.Put(_key, _value);

            return VoidOperationResult.Instance;
        }
    }
}