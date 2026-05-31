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

namespace LeetCode.Tests.Base.Scenarios;

/// <summary>
///     Represents an operation result for operations that do not return a value.
///     Implements the Singleton pattern to avoid unnecessary allocations.
/// </summary>
public sealed class VoidOperationResult : IOperationResult
{
    /// <summary>
    ///     Gets the single shared instance of <see cref="VoidOperationResult" />.
    /// </summary>
    public static readonly VoidOperationResult Instance = new();

    private VoidOperationResult()
    {
    }
}