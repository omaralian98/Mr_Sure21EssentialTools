﻿namespace Mr_Sure21EssentialTools;

public static class ResultExtensions
{
    public static T Match<T>(this Result result, Func<T> onSuccess, Func<IReadOnlyList<Error>, T> onFailure)
    {
        return result.IsSuccess ? onSuccess() : onFailure(result.Errors);
    }
}