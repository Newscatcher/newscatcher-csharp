namespace NewscatcherApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class BadRequestError(Error body, NewscatcherApi.RawResponse? rawResponse = null)
    : NewscatcherApiApiException("BadRequestError", 400, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new Error Body => body;
}
