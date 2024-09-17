// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Core.Exceptions;

public class TreeNodeBuildException : InvalidOperationException
{
    private const string DefaultErrorMessage = "Failed to build TreeNode.";

    public TreeNodeBuildException() : base(DefaultErrorMessage)
    {
    }

    public TreeNodeBuildException(Exception innerException) : base(DefaultErrorMessage, innerException)
    {
    }
}