namespace NewscatcherApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class InternalServerError(string body, NewscatcherApi.RawResponse? rawResponse = null)
    : NewscatcherApiApiException("InternalServerError", 500, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new string Body => body;
}
