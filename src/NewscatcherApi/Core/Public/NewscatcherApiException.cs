using System;

#nullable enable

namespace NewscatcherApi;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class NewscatcherApiException(string message, Exception? innerException = null)
    : Exception(message, innerException) { }
