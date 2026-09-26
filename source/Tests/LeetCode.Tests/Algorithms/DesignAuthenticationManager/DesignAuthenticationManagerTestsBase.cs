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

using LeetCode.Algorithms.DesignAuthenticationManager;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignAuthenticationManager;

public abstract class DesignAuthenticationManagerTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignAuthenticationManager_WithMixedOperations_ProcessesOperationsAccordingToSpecification(AuthenticationManagerScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.TimeToLive);

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

    protected abstract IDesignAuthenticationManager GetSolution(int timeToLive);

    private static IEnumerable<AuthenticationManagerScenario[]> GetScenarios()
    {
        yield return
        [
            new AuthenticationManagerScenario(
                3,
                [
                    new GenerateOperation("a", 1),
                    new GenerateOperation("b", 2),
                    new GenerateOperation("c", 6),
                    new RenewOperation("a", 7),
                    new CountUnexpiredTokensOperation(8),
                    new RenewOperation("c", 9),
                    new CountUnexpiredTokensOperation(10)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                10,
                [
                    new GenerateOperation("a", 1),
                    new GenerateOperation("b", 2),
                    new RenewOperation("a", 3),
                    new CountUnexpiredTokensOperation(12),
                    new CountUnexpiredTokensOperation(13)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new RenewOperation("aaa", 1),
                    new GenerateOperation("aaa", 2),
                    new CountUnexpiredTokensOperation(6),
                    new GenerateOperation("bbb", 7),
                    new RenewOperation("aaa", 8),
                    new RenewOperation("bbb", 10),
                    new CountUnexpiredTokensOperation(15)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return [new AuthenticationManagerScenario(5, [new CountUnexpiredTokensOperation(1)], [new CountUnexpiredTokensOperation.Result(0)])];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [new RenewOperation("a", 1), new CountUnexpiredTokensOperation(2)],
                [VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(0)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [new GenerateOperation("a", 1), new CountUnexpiredTokensOperation(2)],
                [VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(1)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [new GenerateOperation("a", 1), new CountUnexpiredTokensOperation(5)],
                [VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(1)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [new GenerateOperation("a", 1), new CountUnexpiredTokensOperation(6)],
                [VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(0)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [new GenerateOperation("a", 1), new CountUnexpiredTokensOperation(7)],
                [VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(0)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new GenerateOperation("a", 1),
                    new RenewOperation("a", 5),
                    new CountUnexpiredTokensOperation(6),
                    new CountUnexpiredTokensOperation(10)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [new GenerateOperation("a", 1), new RenewOperation("a", 6), new CountUnexpiredTokensOperation(7)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(0)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [new GenerateOperation("a", 1), new RenewOperation("a", 7), new CountUnexpiredTokensOperation(8)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(0)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new GenerateOperation("a", 1),
                    new RenewOperation("b", 2),
                    new CountUnexpiredTokensOperation(3),
                    new CountUnexpiredTokensOperation(6)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                1,
                [new GenerateOperation("a", 1), new CountUnexpiredTokensOperation(2)],
                [VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(0)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                1,
                [new GenerateOperation("a", 1), new RenewOperation("a", 2), new CountUnexpiredTokensOperation(3)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(0)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                1,
                [new GenerateOperation("a", 1), new GenerateOperation("b", 2), new CountUnexpiredTokensOperation(3)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(0)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                2,
                [
                    new GenerateOperation("a", 1),
                    new RenewOperation("a", 2),
                    new RenewOperation("a", 3),
                    new RenewOperation("a", 4),
                    new CountUnexpiredTokensOperation(5),
                    new CountUnexpiredTokensOperation(6)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new GenerateOperation("a", 1),
                    new GenerateOperation("b", 2),
                    new GenerateOperation("c", 3),
                    new CountUnexpiredTokensOperation(4)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(3)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new GenerateOperation("a", 1),
                    new GenerateOperation("b", 2),
                    new GenerateOperation("c", 3),
                    new CountUnexpiredTokensOperation(6),
                    new CountUnexpiredTokensOperation(7),
                    new CountUnexpiredTokensOperation(8)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(2),
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new GenerateOperation("a", 1),
                    new GenerateOperation("b", 2),
                    new GenerateOperation("c", 3),
                    new RenewOperation("a", 4),
                    new CountUnexpiredTokensOperation(7),
                    new CountUnexpiredTokensOperation(8),
                    new CountUnexpiredTokensOperation(9)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(2),
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new GenerateOperation("a", 1),
                    new GenerateOperation("b", 2),
                    new RenewOperation("b", 3),
                    new RenewOperation("a", 4),
                    new CountUnexpiredTokensOperation(8),
                    new CountUnexpiredTokensOperation(9)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [new GenerateOperation("a", 1), new RenewOperation("a", 3), new CountUnexpiredTokensOperation(8)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(0)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                10,
                [
                    new GenerateOperation("a", 1),
                    new GenerateOperation("aa", 2),
                    new GenerateOperation("aaa", 3),
                    new CountUnexpiredTokensOperation(4),
                    new RenewOperation("aa", 5),
                    new CountUnexpiredTokensOperation(13),
                    new CountUnexpiredTokensOperation(15)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(3),
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new GenerateOperation("abcde", 1),
                    new RenewOperation("abcde", 2),
                    new CountUnexpiredTokensOperation(6),
                    new CountUnexpiredTokensOperation(7)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new GenerateOperation("a", 1),
                    new CountUnexpiredTokensOperation(6),
                    new GenerateOperation("b", 7),
                    new CountUnexpiredTokensOperation(8),
                    new CountUnexpiredTokensOperation(12)
                ],
                [
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(0),
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new GenerateOperation("a", 1),
                    new CountUnexpiredTokensOperation(2),
                    new CountUnexpiredTokensOperation(3),
                    new CountUnexpiredTokensOperation(4),
                    new CountUnexpiredTokensOperation(6)
                ],
                [
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                5,
                [
                    new GenerateOperation("a", 1),
                    new CountUnexpiredTokensOperation(6),
                    new RenewOperation("a", 7),
                    new RenewOperation("a", 8),
                    new CountUnexpiredTokensOperation(9)
                ],
                [
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(0),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                100000000,
                [new GenerateOperation("a", 1), new CountUnexpiredTokensOperation(100000000)],
                [VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(1)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                1,
                [new GenerateOperation("a", 99999999), new CountUnexpiredTokensOperation(100000000)],
                [VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(0)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                100000000,
                [new GenerateOperation("a", 99999998), new RenewOperation("a", 99999999), new CountUnexpiredTokensOperation(100000000)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new CountUnexpiredTokensOperation.Result(1)])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                10,
                [
                    new GenerateOperation("a", 1),
                    new GenerateOperation("b", 2),
                    new RenewOperation("c", 3),
                    new CountUnexpiredTokensOperation(4),
                    new RenewOperation("a", 10),
                    new CountUnexpiredTokensOperation(12),
                    new CountUnexpiredTokensOperation(20)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(2),
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        yield return
        [
            new AuthenticationManagerScenario(
                3,
                [
                    new GenerateOperation("a", 1),
                    new GenerateOperation("b", 2),
                    new RenewOperation("a", 3),
                    new RenewOperation("b", 4),
                    new CountUnexpiredTokensOperation(5),
                    new CountUnexpiredTokensOperation(6),
                    new CountUnexpiredTokensOperation(7)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new CountUnexpiredTokensOperation.Result(2),
                    new CountUnexpiredTokensOperation.Result(1),
                    new CountUnexpiredTokensOperation.Result(0)
                ])
        ];

        const int tokenCount = 1000;

        var generateAndCountOperations = new IOperation<IDesignAuthenticationManager>[tokenCount * 2];
        var generateAndCountResults = new IOperationResult[tokenCount * 2];

        for (var i = 0; i < tokenCount; i++)
        {
            var tokenId = new string([(char)('a' + (i / (26 * 26))), (char)('a' + (i / 26 % 26)), (char)('a' + (i % 26))]);

            generateAndCountOperations[i] = new GenerateOperation(tokenId, i + 1);
            generateAndCountResults[i] = VoidOperationResult.Instance;

            generateAndCountOperations[tokenCount + i] = new CountUnexpiredTokensOperation(tokenCount + i + 1);
            generateAndCountResults[tokenCount + i] = new CountUnexpiredTokensOperation.Result(tokenCount - i - 1);
        }

        yield return [new AuthenticationManagerScenario(tokenCount, generateAndCountOperations, generateAndCountResults)];

        const int operationCount = 2000;

        var renewalOperations = new IOperation<IDesignAuthenticationManager>[operationCount];
        var renewalResults = new IOperationResult[operationCount];

        renewalOperations[0] = new GenerateOperation("a", 1);
        renewalResults[0] = VoidOperationResult.Instance;

        for (var i = 1; i < operationCount - 1; i++)
        {
            renewalOperations[i] = new RenewOperation("a", i + 1);
            renewalResults[i] = VoidOperationResult.Instance;
        }

        renewalOperations[^1] = new CountUnexpiredTokensOperation(operationCount);
        renewalResults[^1] = new CountUnexpiredTokensOperation.Result(1);

        yield return [new AuthenticationManagerScenario(2, renewalOperations, renewalResults)];
    }

    public sealed class AuthenticationManagerScenario : IScenario<IDesignAuthenticationManager>
    {
        public AuthenticationManagerScenario(
            int timeToLive,
            IOperation<IDesignAuthenticationManager>[] operations,
            IOperationResult[] operationResults)
        {
            TimeToLive = timeToLive;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int TimeToLive { get; }

        public IOperation<IDesignAuthenticationManager>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class GenerateOperation : IOperation<IDesignAuthenticationManager>
    {
        private readonly int _currentTime;
        private readonly string _tokenId;

        public GenerateOperation(string tokenId, int currentTime)
        {
            _tokenId = tokenId;
            _currentTime = currentTime;
        }

        public IOperationResult Execute(IDesignAuthenticationManager solution)
        {
            solution.Generate(_tokenId, _currentTime);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class RenewOperation : IOperation<IDesignAuthenticationManager>
    {
        private readonly int _currentTime;
        private readonly string _tokenId;

        public RenewOperation(string tokenId, int currentTime)
        {
            _tokenId = tokenId;
            _currentTime = currentTime;
        }

        public IOperationResult Execute(IDesignAuthenticationManager solution)
        {
            solution.Renew(_tokenId, _currentTime);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class CountUnexpiredTokensOperation : IOperation<IDesignAuthenticationManager>
    {
        private readonly int _currentTime;

        public CountUnexpiredTokensOperation(int currentTime)
        {
            _currentTime = currentTime;
        }

        public IOperationResult Execute(IDesignAuthenticationManager solution)
        {
            var result = solution.CountUnexpiredTokens(_currentTime);

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
}