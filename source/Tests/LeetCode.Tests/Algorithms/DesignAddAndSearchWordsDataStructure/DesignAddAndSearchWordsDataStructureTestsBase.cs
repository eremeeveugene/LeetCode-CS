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

using LeetCode.Algorithms.DesignAddAndSearchWordsDataStructure;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignAddAndSearchWordsDataStructure;

public abstract class DesignAddAndSearchWordsDataStructureTestsBase<T> where T : IDesignAddAndSearchWordsDataStructure, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignAddAndSearchWordsDataStructure_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        IScenario<IDesignAddAndSearchWordsDataStructure> scenario)
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

    private static IEnumerable<IScenario<IDesignAddAndSearchWordsDataStructure>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("bad"),
                    new AddWordOperation("dad"),
                    new AddWordOperation("mad"),
                    new SearchOperation("pad"),
                    new SearchOperation("bad"),
                    new SearchOperation(".ad"),
                    new SearchOperation("b..")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new SearchOperation("a"), new SearchOperation("."), new SearchOperation("..")],
                [new SearchOperation.Result(false), new SearchOperation.Result(false), new SearchOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("a"), new SearchOperation("a"), new SearchOperation("b"), new SearchOperation(".")],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("z"), new SearchOperation("z"), new SearchOperation("."), new SearchOperation("a")],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("apple"), new SearchOperation("app"), new SearchOperation("apple"), new SearchOperation("apples")],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("apple"), new AddWordOperation("app"), new SearchOperation("app"), new SearchOperation("apple")],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("app"), new AddWordOperation("apple"), new SearchOperation("app"), new SearchOperation("apple")],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("same"), new AddWordOperation("same"), new SearchOperation("same"), new SearchOperation("s.me")],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("cat"), new SearchOperation(".at"), new SearchOperation(".bt")],
                [VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("cat"), new SearchOperation("c.t"), new SearchOperation("c.z")],
                [VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("cat"), new SearchOperation("ca."), new SearchOperation("cb.")],
                [VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("cat"), new SearchOperation("..t"), new SearchOperation("..z")],
                [VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("cat"), new SearchOperation("c.."), new SearchOperation("z..")],
                [VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("cat"), new SearchOperation(".a."), new SearchOperation(".b.")],
                [VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("ab"), new SearchOperation(".."), new SearchOperation(".")],
                [VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("abc"), new SearchOperation("."), new SearchOperation(".."), new SearchOperation("a.")],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("a"), new SearchOperation(".."), new SearchOperation("a."), new SearchOperation(".a")],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("ab"), new AddWordOperation("zz"), new SearchOperation(".z"), new SearchOperation(".x")],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("aab"),
                    new AddWordOperation("azc"),
                    new AddWordOperation("bbc"),
                    new SearchOperation("..c"),
                    new SearchOperation("..z"),
                    new SearchOperation(".bc")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("a"),
                    new AddWordOperation("ab"),
                    new AddWordOperation("abc"),
                    new SearchOperation("a"),
                    new SearchOperation("a."),
                    new SearchOperation("a..")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("abc"),
                    new AddWordOperation("abd"),
                    new SearchOperation("ab"),
                    new SearchOperation("ab."),
                    new SearchOperation("abe")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new SearchOperation("dog"), new AddWordOperation("dog"), new SearchOperation("dog"), new SearchOperation("d.g")],
                [
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("bad"),
                    new SearchOperation("mad"),
                    new AddWordOperation("mad"),
                    new SearchOperation("mad"),
                    new SearchOperation(".ad")
                ],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("aaaa"), new SearchOperation("a..a"), new SearchOperation("a..b"), new SearchOperation("aa.")],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("abab"), new SearchOperation(".b.b"), new SearchOperation("a.a."), new SearchOperation(".a.a")],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("abc"),
                    new AddWordOperation("abd"),
                    new AddWordOperation("abe"),
                    new SearchOperation("abz"),
                    new SearchOperation("ab."),
                    new SearchOperation(".bz")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("aaaaaaaaaaaaaaaaaaaaaaaaa"),
                    new SearchOperation("aaaaaaaaaaaaaaaaaaaaaaaaa"),
                    new SearchOperation("aaaaaaaaaaaaaaaaaaaaaaaa"),
                    new SearchOperation(".aaaaaaaaaaaaaaaaaaaaaaa."),
                    new SearchOperation("aaaaaaaaaaaaaaaaaaaaaaaab")
                ],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("zzzzzzzzzzzzzzzzzzzzzzzzz"),
                    new SearchOperation("zzzzzzzzzzzzzzzzzzzzzzz.."),
                    new SearchOperation("..zzzzzzzzzzzzzzzzzzzzzzz"),
                    new SearchOperation("zzzzzzzzzzzzzzzzzzzzzza..")
                ],
                [VoidOperationResult.Instance, new SearchOperation.Result(true), new SearchOperation.Result(true), new SearchOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("aaaaaaaaaaaaaaaaaaaaaaaa"),
                    new SearchOperation("aaaaaaaaaaaaaaaaaaaaaaaaa"),
                    new SearchOperation("aaaaaaaaaaaaaaaaaaaaaaa.")
                ],
                [VoidOperationResult.Instance, new SearchOperation.Result(false), new SearchOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("hello"),
                    new AddWordOperation("world"),
                    new SearchOperation("h.llo"),
                    new SearchOperation("w.r.d"),
                    new SearchOperation("h.llz")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [
                    new AddWordOperation("aa"),
                    new AddWordOperation("az"),
                    new AddWordOperation("za"),
                    new AddWordOperation("zz"),
                    new SearchOperation(".."),
                    new SearchOperation("z."),
                    new SearchOperation(".z"),
                    new SearchOperation(".b")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IDesignAddAndSearchWordsDataStructure>(
                [new AddWordOperation("abc"), new SearchOperation("bc"), new SearchOperation("b."), new SearchOperation(".bc")],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true)
                ])
        ];

        const int wordCount = 5000;

        var operations = new IOperation<IDesignAddAndSearchWordsDataStructure>[wordCount * 2];
        var operationResults = new IOperationResult[wordCount * 2];

        for (var i = 0; i < wordCount; i++)
        {
            var word = new string([(char)('a' + (i / (26 * 26))), (char)('a' + (i / 26 % 26)), (char)('a' + (i % 26))]);

            operations[i] = new AddWordOperation(word);
            operationResults[i] = VoidOperationResult.Instance;

            operations[wordCount + i] = new SearchOperation(word);
            operationResults[wordCount + i] = new SearchOperation.Result(true);
        }

        yield return [new Scenario<IDesignAddAndSearchWordsDataStructure>(operations, operationResults)];

        const int alphabetSize = 26;
        const int twoLetterWordCount = alphabetSize * alphabetSize;

        var branchingOperations = new IOperation<IDesignAddAndSearchWordsDataStructure>[twoLetterWordCount + 4];
        var branchingResults = new IOperationResult[twoLetterWordCount + 4];

        for (var i = 0; i < twoLetterWordCount; i++)
        {
            var word = new string([(char)('a' + (i / alphabetSize)), (char)('a' + (i % alphabetSize))]);

            branchingOperations[i] = new AddWordOperation(word);
            branchingResults[i] = VoidOperationResult.Instance;
        }

        branchingOperations[^4] = new SearchOperation("..");
        branchingResults[^4] = new SearchOperation.Result(true);
        branchingOperations[^3] = new SearchOperation(".z");
        branchingResults[^3] = new SearchOperation.Result(true);
        branchingOperations[^2] = new SearchOperation("z.");
        branchingResults[^2] = new SearchOperation.Result(true);
        branchingOperations[^1] = new SearchOperation("..a");
        branchingResults[^1] = new SearchOperation.Result(false);

        yield return [new Scenario<IDesignAddAndSearchWordsDataStructure>(branchingOperations, branchingResults)];
    }

    private sealed class AddWordOperation : IOperation<IDesignAddAndSearchWordsDataStructure>
    {
        private readonly string _word;

        public AddWordOperation(string word)
        {
            _word = word;
        }

        public IOperationResult Execute(IDesignAddAndSearchWordsDataStructure solution)
        {
            solution.AddWord(_word);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class SearchOperation : IOperation<IDesignAddAndSearchWordsDataStructure>
    {
        private readonly string _word;

        public SearchOperation(string word)
        {
            _word = word;
        }

        public IOperationResult Execute(IDesignAddAndSearchWordsDataStructure solution)
        {
            var found = solution.Search(_word);

            return new Result(found);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _found;

            public Result(bool found)
            {
                _found = found;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _found == other._found;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_found);
            }
        }
    }
}