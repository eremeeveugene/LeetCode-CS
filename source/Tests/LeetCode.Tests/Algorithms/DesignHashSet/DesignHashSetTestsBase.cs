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

using LeetCode.Algorithms.DesignHashSet;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignHashSet;

public abstract class DesignHashSetTestsBase<T> where T : IDesignHashSet, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignHashSet_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IDesignHashSet> scenario)
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

    private static IEnumerable<IScenario<IDesignHashSet>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(1),
                    new AddOperation(2),
                    new ContainsOperation(1),
                    new ContainsOperation(3),
                    new AddOperation(2),
                    new ContainsOperation(2),
                    new RemoveOperation(2),
                    new ContainsOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true),
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true),
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new ContainsOperation(0)
                ],
                [
                    new ContainsOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(0),
                    new ContainsOperation(0)
                ],
                [
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(1000000),
                    new ContainsOperation(1000000),
                    new RemoveOperation(1000000),
                    new ContainsOperation(1000000)
                ],
                [
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true),
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new RemoveOperation(5),
                    new ContainsOperation(5)
                ],
                [
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(1),
                    new AddOperation(1),
                    new RemoveOperation(1),
                    new ContainsOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(1001),
                    new AddOperation(1),
                    new ContainsOperation(1001),
                    new ContainsOperation(1),
                    new RemoveOperation(1),
                    new ContainsOperation(1001)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true),
                    new ContainsOperation.Result(true),
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(65536),
                    new AddOperation(0),
                    new ContainsOperation(65536),
                    new ContainsOperation(0),
                    new RemoveOperation(0),
                    new ContainsOperation(65536)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true),
                    new ContainsOperation.Result(true),
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(3),
                    new RemoveOperation(3),
                    new RemoveOperation(3),
                    new ContainsOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(2),
                    new ContainsOperation(2),
                    new RemoveOperation(2),
                    new AddOperation(2),
                    new ContainsOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new ContainsOperation(1001),
                    new RemoveOperation(3),
                    new RemoveOperation(1000),
                    new ContainsOperation(2),
                    new ContainsOperation(2001),
                    new RemoveOperation(5),
                    new AddOperation(1),
                    new RemoveOperation(999999),
                    new ContainsOperation(1),
                    new ContainsOperation(2),
                    new AddOperation(2),
                    new AddOperation(3)
                ],
                [
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true),
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new ContainsOperation(999999),
                    new AddOperation(1000000),
                    new AddOperation(2),
                    new RemoveOperation(0),
                    new RemoveOperation(1),
                    new RemoveOperation(1),
                    new AddOperation(1),
                    new RemoveOperation(0),
                    new AddOperation(2),
                    new RemoveOperation(1000000)
                ],
                [
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(1000000),
                    new ContainsOperation(3),
                    new AddOperation(10),
                    new AddOperation(1000000),
                    new AddOperation(999999),
                    new ContainsOperation(0),
                    new AddOperation(1001),
                    new RemoveOperation(0),
                    new RemoveOperation(1000)
                ],
                [
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new RemoveOperation(1001),
                    new AddOperation(2),
                    new AddOperation(1001),
                    new AddOperation(999999),
                    new ContainsOperation(1001),
                    new ContainsOperation(999999),
                    new AddOperation(0),
                    new AddOperation(3),
                    new AddOperation(1),
                    new AddOperation(100),
                    new RemoveOperation(1000000)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true),
                    new ContainsOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(999999),
                    new AddOperation(2),
                    new RemoveOperation(5),
                    new RemoveOperation(3),
                    new RemoveOperation(2),
                    new AddOperation(0),
                    new AddOperation(0),
                    new ContainsOperation(1000000),
                    new RemoveOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new ContainsOperation(2001),
                    new AddOperation(1001),
                    new AddOperation(2),
                    new RemoveOperation(0),
                    new AddOperation(1000000),
                    new ContainsOperation(2),
                    new ContainsOperation(1),
                    new ContainsOperation(1001),
                    new AddOperation(1000000),
                    new ContainsOperation(999999),
                    new AddOperation(10),
                    new RemoveOperation(2)
                ],
                [
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(true),
                    new ContainsOperation.Result(false),
                    new ContainsOperation.Result(true),
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(0),
                    new RemoveOperation(1000),
                    new AddOperation(2),
                    new AddOperation(1),
                    new ContainsOperation(3),
                    new RemoveOperation(1000000),
                    new ContainsOperation(1000),
                    new AddOperation(999999),
                    new AddOperation(1000000),
                    new AddOperation(2),
                    new RemoveOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(999999),
                    new AddOperation(1),
                    new ContainsOperation(100),
                    new AddOperation(1000),
                    new RemoveOperation(1000),
                    new AddOperation(1),
                    new AddOperation(3),
                    new RemoveOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(5),
                    new ContainsOperation(2001),
                    new AddOperation(2),
                    new RemoveOperation(2),
                    new AddOperation(1),
                    new AddOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new ContainsOperation(1000000),
                    new AddOperation(3),
                    new RemoveOperation(3),
                    new RemoveOperation(1000),
                    new ContainsOperation(0),
                    new AddOperation(2),
                    new AddOperation(5),
                    new AddOperation(1000000),
                    new AddOperation(1000),
                    new AddOperation(999999),
                    new AddOperation(2),
                    new RemoveOperation(1000000)
                ],
                [
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashSet>(
                [
                    new AddOperation(1000000),
                    new ContainsOperation(1),
                    new AddOperation(2001),
                    new RemoveOperation(2),
                    new RemoveOperation(0),
                    new RemoveOperation(3),
                    new AddOperation(3),
                    new AddOperation(1001)
                ],
                [
                    VoidOperationResult.Instance,
                    new ContainsOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];
    }

    private sealed class AddOperation : IOperation<IDesignHashSet>
    {
        private readonly int _key;

        public AddOperation(int key)
        {
            _key = key;
        }

        public IOperationResult Execute(IDesignHashSet solution)
        {
            solution.Add(_key);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class RemoveOperation : IOperation<IDesignHashSet>
    {
        private readonly int _key;

        public RemoveOperation(int key)
        {
            _key = key;
        }

        public IOperationResult Execute(IDesignHashSet solution)
        {
            solution.Remove(_key);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class ContainsOperation : IOperation<IDesignHashSet>
    {
        private readonly int _key;

        public ContainsOperation(int key)
        {
            _key = key;
        }

        public IOperationResult Execute(IDesignHashSet solution)
        {
            var result = solution.Contains(_key);

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