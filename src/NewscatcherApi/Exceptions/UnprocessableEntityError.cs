namespace NewscatcherApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class UnprocessableEntityError(HttpValidationError body)
    : NewscatcherApiApiException("UnprocessableEntityError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new HttpValidationError Body => body;
}
