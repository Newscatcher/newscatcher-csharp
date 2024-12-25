using NewscatcherApi.Core;

#nullable enable

namespace NewscatcherApi;

public record SearchUrlGetRequest
{
    public required string Ids { get; set; }

    public required string Links { get; set; }

    public string? From { get; set; }

    public string? To { get; set; }

    public int? Page { get; set; }

    public int? PageSize { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
