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

using LeetCode.Algorithms.DesignHashMap;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignHashMap;

public abstract class DesignHashMapTestsBase<T> where T : IDesignHashMap, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignHashMap_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IDesignHashMap> scenario)
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

    private static IEnumerable<IScenario<IDesignHashMap>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(1, 1),
                    new PutOperation(2, 2),
                    new GetOperation(1),
                    new GetOperation(3),
                    new PutOperation(2, 1),
                    new GetOperation(2),
                    new RemoveOperation(2),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new GetOperation(0)
                ],
                [
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(0, 0),
                    new GetOperation(0)
                ],
                [
                    VoidOperationResult.Instance,
                    new GetOperation.Result(0)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(1000000, 1000000),
                    new GetOperation(1000000),
                    new RemoveOperation(1000000),
                    new GetOperation(1000000)
                ],
                [
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1000000),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new RemoveOperation(5),
                    new GetOperation(5)
                ],
                [
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(1, 1),
                    new PutOperation(1, 2),
                    new PutOperation(1, 3),
                    new GetOperation(1)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(1001, 7),
                    new PutOperation(1, 8),
                    new GetOperation(1001),
                    new GetOperation(1),
                    new RemoveOperation(1),
                    new GetOperation(1001)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(7),
                    new GetOperation.Result(8),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(7)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(65536, 1),
                    new PutOperation(0, 2),
                    new GetOperation(65536),
                    new GetOperation(0),
                    new RemoveOperation(0),
                    new GetOperation(65536)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1),
                    new GetOperation.Result(2),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(3, 9),
                    new RemoveOperation(3),
                    new RemoveOperation(3),
                    new GetOperation(3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(2, 0),
                    new GetOperation(2),
                    new RemoveOperation(2),
                    new PutOperation(2, 5),
                    new GetOperation(2)
                ],
                [
                    VoidOperationResult.Instance,
                    new GetOperation.Result(0),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(5)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(3, 252175),
                    new PutOperation(2, 499370),
                    new RemoveOperation(3),
                    new PutOperation(10, 693235),
                    new RemoveOperation(2),
                    new PutOperation(2, 830932),
                    new PutOperation(1000, 191757),
                    new PutOperation(1, 91417),
                    new RemoveOperation(1001),
                    new PutOperation(1, 75374),
                    new PutOperation(999999, 587311),
                    new GetOperation(100)
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
                    new GetOperation.Result(-1)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(1, 779232),
                    new PutOperation(0, 604912),
                    new GetOperation(1000000),
                    new PutOperation(1001, 657529),
                    new RemoveOperation(2),
                    new RemoveOperation(3),
                    new RemoveOperation(2001),
                    new PutOperation(1000000, 495230),
                    new GetOperation(2),
                    new GetOperation(0)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(604912)
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new GetOperation(0),
                    new PutOperation(1, 268476),
                    new RemoveOperation(100),
                    new GetOperation(3),
                    new PutOperation(2, 556977),
                    new PutOperation(3, 959719)
                ],
                [
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new GetOperation(0),
                    new PutOperation(2, 797576),
                    new PutOperation(0, 251559),
                    new PutOperation(1001, 118966),
                    new GetOperation(1),
                    new PutOperation(2, 220130),
                    new PutOperation(1, 156402),
                    new PutOperation(1, 702984)
                ],
                [
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new GetOperation(100),
                    new RemoveOperation(1001),
                    new RemoveOperation(1),
                    new GetOperation(1000),
                    new PutOperation(1000000, 301606),
                    new GetOperation(0),
                    new RemoveOperation(1),
                    new PutOperation(1, 9250),
                    new PutOperation(1, 535187),
                    new PutOperation(1, 816895)
                ],
                [
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(3, 297585),
                    new GetOperation(2001),
                    new GetOperation(1000),
                    new GetOperation(1000000),
                    new PutOperation(999999, 330315),
                    new PutOperation(999999, 791522),
                    new GetOperation(65536),
                    new RemoveOperation(2001),
                    new RemoveOperation(1000000)
                ],
                [
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    new GetOperation.Result(-1),
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new RemoveOperation(10),
                    new PutOperation(2, 707933),
                    new PutOperation(1, 377026),
                    new PutOperation(1000, 617469),
                    new RemoveOperation(5),
                    new RemoveOperation(0),
                    new RemoveOperation(1),
                    new PutOperation(999999, 359696),
                    new PutOperation(2001, 767965)
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
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new RemoveOperation(1),
                    new PutOperation(2, 475848),
                    new RemoveOperation(65537),
                    new PutOperation(3, 784847),
                    new PutOperation(1000, 826573),
                    new RemoveOperation(3),
                    new PutOperation(0, 394133),
                    new PutOperation(2, 857313),
                    new RemoveOperation(2),
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
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IDesignHashMap>(
                [
                    new PutOperation(100, 406984),
                    new RemoveOperation(1),
                    new PutOperation(1001, 213903),
                    new RemoveOperation(65536),
                    new PutOperation(1001, 240801),
                    new PutOperation(5, 457359)
                ],
                [
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
            new Scenario<IDesignHashMap>(
                [
                    new GetOperation(10),
                    new RemoveOperation(3),
                    new PutOperation(1000, 643694),
                    new PutOperation(10, 346779),
                    new PutOperation(1000, 200615),
                    new RemoveOperation(999999),
                    new PutOperation(999999, 835117),
                    new PutOperation(2, 702723),
                    new PutOperation(1001, 306639),
                    new PutOperation(3, 729802)
                ],
                [
                    new GetOperation.Result(-1),
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
            new Scenario<IDesignHashMap>(
                [
                    new GetOperation(10),
                    new PutOperation(1000000, 181465),
                    new PutOperation(1000, 452979),
                    new RemoveOperation(5),
                    new GetOperation(1000),
                    new PutOperation(1001, 843868)
                ],
                [
                    new GetOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new GetOperation.Result(452979),
                    VoidOperationResult.Instance
                ])
        ];
    }

    private sealed class PutOperation : IOperation<IDesignHashMap>
    {
        private readonly int _key;
        private readonly int _value;

        public PutOperation(int key, int value)
        {
            _key = key;
            _value = value;
        }

        public IOperationResult Execute(IDesignHashMap solution)
        {
            solution.Put(_key, _value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class GetOperation : IOperation<IDesignHashMap>
    {
        private readonly int _key;

        public GetOperation(int key)
        {
            _key = key;
        }

        public IOperationResult Execute(IDesignHashMap solution)
        {
            var result = solution.Get(_key);

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

    private sealed class RemoveOperation : IOperation<IDesignHashMap>
    {
        private readonly int _key;

        public RemoveOperation(int key)
        {
            _key = key;
        }

        public IOperationResult Execute(IDesignHashMap solution)
        {
            solution.Remove(_key);

            return VoidOperationResult.Instance;
        }
    }
}