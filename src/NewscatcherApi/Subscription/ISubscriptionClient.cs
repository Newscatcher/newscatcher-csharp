namespace NewscatcherApi;

public partial interface ISubscriptionClient
{
    /// <summary>
    /// Retrieves information about your subscription plan.
    /// </summary>
    Task<SubscriptionResponseDto> GetAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves information about your subscription plan.
    /// </summary>
    Task<SubscriptionResponseDto> PostAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
