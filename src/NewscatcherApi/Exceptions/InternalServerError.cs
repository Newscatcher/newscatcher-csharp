namespace NewscatcherApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class InternalServerError(string body)
    : NewscatcherApiApiException("InternalServerError", 500, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new string Body => body;
}
