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

using LeetCode.Algorithms.DesignLinkedList;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignLinkedList;

public abstract class DesignLinkedListTestsBase<T> where T : IDesignLinkedList, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignLinkedList_WithMixedOperations_ReturnsExpectedValues(IScenario<IDesignLinkedList> scenario)
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

    private static IEnumerable<IScenario<IDesignLinkedList>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(10),
                    new AddAtTailOperation(20),
                    new AddAtTailOperation(30),
                    new AddAtTailOperation(40),
                    new AddAtTailOperation(50),
                    new AddAtTailOperation(60),
                    new AddAtIndexOperation(3, 35),
                    new DeleteAtIndexOperation(5),
                    new AddAtIndexOperation(5, 50),
                    new GetOperation(5),
                    new GetOperation(1),
                    new GetOperation(4),
                    new GetOperation(2),
                    new GetOperation(6),
                    new GetOperation(0),
                    new GetOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(50),
                    new GetOperation.Result(20),
                    new GetOperation.Result(40),
                    new GetOperation.Result(30),
                    new GetOperation.Result(60),
                    new GetOperation.Result(10),
                    new GetOperation.Result(35)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtIndexOperation(0, 0),
                    new DeleteAtIndexOperation(0),
                    new AddAtIndexOperation(0, 1000),
                    new DeleteAtIndexOperation(0),
                    new AddAtTailOperation(7),
                    new DeleteAtIndexOperation(0),
                    new AddAtHeadOperation(8),
                    new AddAtTailOperation(9),
                    new GetOperation(0),
                    new GetOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(8),
                    new GetOperation.Result(9)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtHeadOperation(0),
                    new AddAtTailOperation(1000),
                    new AddAtIndexOperation(1, 0),
                    new AddAtIndexOperation(2, 1000),
                    new DeleteAtIndexOperation(1),
                    new DeleteAtIndexOperation(2),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(0),
                    new GetOperation.Result(1000),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(50),
                    new AddAtIndexOperation(0, 40),
                    new AddAtIndexOperation(0, 30),
                    new AddAtIndexOperation(0, 20),
                    new AddAtIndexOperation(0, 10),
                    new DeleteAtIndexOperation(2),
                    new AddAtIndexOperation(2, 25),
                    new GetOperation(4),
                    new GetOperation(3),
                    new GetOperation(2),
                    new GetOperation(1),
                    new GetOperation(0)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(50),
                    new GetOperation.Result(40),
                    new GetOperation.Result(25),
                    new GetOperation.Result(20),
                    new GetOperation.Result(10)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(0),
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(2),
                    new AddAtTailOperation(3),
                    new AddAtTailOperation(4),
                    new AddAtTailOperation(5),
                    new AddAtTailOperation(6),
                    new AddAtTailOperation(7),
                    new DeleteAtIndexOperation(6),
                    new DeleteAtIndexOperation(4),
                    new DeleteAtIndexOperation(2),
                    new DeleteAtIndexOperation(0),
                    new AddAtIndexOperation(2, 4),
                    new GetOperation(0),
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
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(3),
                    new GetOperation.Result(4),
                    new GetOperation.Result(5),
                    new GetOperation.Result(7)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    .. Enumerable.Range(0, 1000).Select(value => new AddAtTailOperation(value)),
                    .. Enumerable.Range(0, 1000).Select(index => new GetOperation(index))
                ],
                [
                    .. Enumerable.Repeat(VoidOperationResult.Instance, 1000),
                    .. Enumerable.Range(0, 1000).Select(value => new GetOperation.Result(value))
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    .. Enumerable.Range(0, 1000).Select(value => new AddAtHeadOperation(value)),
                    .. Enumerable.Range(0, 1000).Select(index => new GetOperation(index))
                ],
                [
                    .. Enumerable.Repeat(VoidOperationResult.Instance, 1000),
                    .. Enumerable.Range(0, 1000).Select(index => new GetOperation.Result(999 - index))
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    .. Enumerable.Range(0, 1000).Select(value => new AddAtTailOperation(value)),
                    new AddAtIndexOperation(1000, 1000),
                    new GetOperation(1000),
                    new DeleteAtIndexOperation(1000),
                    new AddAtTailOperation(999),
                    new GetOperation(1000)
                ],
                [
                    .. Enumerable.Repeat(VoidOperationResult.Instance, 1001),
                    new GetOperation.Result(1000),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(999)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtHeadOperation(1),
                    new AddAtTailOperation(3),
                    new AddAtIndexOperation(1, 2),
                    new GetOperation(1),
                    new DeleteAtIndexOperation(1),
                    new GetOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(2),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [new GetOperation(0), new GetOperation(1), new GetOperation(1000)],
                [new GetOperation.Result(-1), new GetOperation.Result(-1), new GetOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [new DeleteAtIndexOperation(0), new GetOperation(0)],
                [VoidOperationResult.Instance, new GetOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [new DeleteAtIndexOperation(1000), new AddAtHeadOperation(7), new GetOperation(0)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetOperation.Result(7)])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [new AddAtHeadOperation(0), new GetOperation(0), new GetOperation(1)],
                [VoidOperationResult.Instance, new GetOperation.Result(0), new GetOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [new AddAtTailOperation(1000), new GetOperation(0), new GetOperation(1)],
                [VoidOperationResult.Instance, new GetOperation.Result(1000), new GetOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [new AddAtIndexOperation(0, 5), new GetOperation(0)],
                [VoidOperationResult.Instance, new GetOperation.Result(5)])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtHeadOperation(1),
                    new AddAtHeadOperation(2),
                    new AddAtHeadOperation(3),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2),
                    new GetOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(3),
                    new GetOperation.Result(2),
                    new GetOperation.Result(1),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(2),
                    new AddAtTailOperation(3),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2),
                    new GetOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(2),
                    new GetOperation.Result(3),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtHeadOperation(1),
                    new AddAtTailOperation(2),
                    new AddAtHeadOperation(3),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(3),
                    new GetOperation.Result(1),
                    new GetOperation.Result(2)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [new AddAtHeadOperation(1), new AddAtIndexOperation(0, 2), new GetOperation(0), new GetOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetOperation.Result(2), new GetOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtHeadOperation(1),
                    new AddAtIndexOperation(1, 2),
                    new AddAtTailOperation(3),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(2),
                    new GetOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(3),
                    new AddAtIndexOperation(1, 2),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(2),
                    new GetOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(4),
                    new AddAtIndexOperation(1, 3),
                    new AddAtIndexOperation(1, 2),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2),
                    new GetOperation(3)
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
            new Scenario<IDesignLinkedList>(
                [new AddAtHeadOperation(5), new DeleteAtIndexOperation(0), new GetOperation(0), new GetOperation(1)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new GetOperation.Result(-1), new GetOperation.Result(-1)])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [new AddAtTailOperation(5), new DeleteAtIndexOperation(0), new AddAtTailOperation(6), new GetOperation(0), new GetOperation(1)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(6),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [new AddAtHeadOperation(5), new DeleteAtIndexOperation(0), new AddAtHeadOperation(6), new GetOperation(0), new GetOperation(1)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(6),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtIndexOperation(0, 5),
                    new DeleteAtIndexOperation(0),
                    new AddAtIndexOperation(0, 6),
                    new AddAtTailOperation(7),
                    new GetOperation(0),
                    new GetOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(6),
                    new GetOperation.Result(7)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(2),
                    new AddAtTailOperation(3),
                    new DeleteAtIndexOperation(0),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(2),
                    new GetOperation.Result(3),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(2),
                    new AddAtTailOperation(3),
                    new DeleteAtIndexOperation(1),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(3),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(2),
                    new AddAtTailOperation(3),
                    new DeleteAtIndexOperation(2),
                    new AddAtTailOperation(4),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2),
                    new GetOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(2),
                    new GetOperation.Result(4),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(2),
                    new DeleteAtIndexOperation(2),
                    new DeleteAtIndexOperation(1000),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(2),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(2),
                    new AddAtTailOperation(3),
                    new DeleteAtIndexOperation(0),
                    new DeleteAtIndexOperation(0),
                    new DeleteAtIndexOperation(0),
                    new DeleteAtIndexOperation(0),
                    new AddAtTailOperation(4),
                    new GetOperation(0),
                    new GetOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(4),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(2),
                    new AddAtTailOperation(3),
                    new DeleteAtIndexOperation(2),
                    new DeleteAtIndexOperation(1),
                    new DeleteAtIndexOperation(0),
                    new AddAtHeadOperation(4),
                    new AddAtTailOperation(5),
                    new GetOperation(0),
                    new GetOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(4),
                    new GetOperation.Result(5)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtHeadOperation(7),
                    new AddAtHeadOperation(7),
                    new AddAtTailOperation(7),
                    new DeleteAtIndexOperation(1),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(7),
                    new GetOperation.Result(7),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtIndexOperation(0, 0),
                    new AddAtIndexOperation(1, 1000),
                    new AddAtIndexOperation(1, 0),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(0),
                    new GetOperation.Result(0),
                    new GetOperation.Result(1000)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(2),
                    new DeleteAtIndexOperation(1),
                    new AddAtIndexOperation(1, 3),
                    new AddAtTailOperation(4),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(3),
                    new GetOperation.Result(4)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtTailOperation(1),
                    new AddAtTailOperation(2),
                    new GetOperation(0),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(1),
                    new GetOperation(1000)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(1),
                    new GetOperation.Result(2),
                    new GetOperation.Result(2),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtIndexOperation(0, 1),
                    new AddAtIndexOperation(1, 2),
                    new AddAtIndexOperation(2, 3),
                    new AddAtIndexOperation(3, 4),
                    new DeleteAtIndexOperation(1),
                    new AddAtIndexOperation(2, 5),
                    new GetOperation(0),
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
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(3),
                    new GetOperation.Result(5),
                    new GetOperation.Result(4),
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignLinkedList>(
                [
                    new AddAtHeadOperation(1000),
                    new AddAtTailOperation(0),
                    new AddAtIndexOperation(1, 500),
                    new DeleteAtIndexOperation(0),
                    new DeleteAtIndexOperation(1),
                    new AddAtIndexOperation(1, 999),
                    new AddAtHeadOperation(1),
                    new GetOperation(0),
                    new GetOperation(1),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(500),
                    new GetOperation.Result(999)
                ])
        ];
    }

    private sealed class GetOperation : IOperation<IDesignLinkedList>
    {
        private readonly int _index;

        public GetOperation(int index)
        {
            _index = index;
        }

        public IOperationResult Execute(IDesignLinkedList solution)
        {
            var result = solution.Get(_index);

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

    private sealed class AddAtHeadOperation : IOperation<IDesignLinkedList>
    {
        private readonly int _value;

        public AddAtHeadOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignLinkedList solution)
        {
            solution.AddAtHead(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class AddAtTailOperation : IOperation<IDesignLinkedList>
    {
        private readonly int _value;

        public AddAtTailOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignLinkedList solution)
        {
            solution.AddAtTail(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class AddAtIndexOperation : IOperation<IDesignLinkedList>
    {
        private readonly int _index;
        private readonly int _value;

        public AddAtIndexOperation(int index, int value)
        {
            _index = index;
            _value = value;
        }

        public IOperationResult Execute(IDesignLinkedList solution)
        {
            solution.AddAtIndex(_index, _value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class DeleteAtIndexOperation : IOperation<IDesignLinkedList>
    {
        private readonly int _index;

        public DeleteAtIndexOperation(int index)
        {
            _index = index;
        }

        public IOperationResult Execute(IDesignLinkedList solution)
        {
            solution.DeleteAtIndex(_index);

            return VoidOperationResult.Instance;
        }
    }
}