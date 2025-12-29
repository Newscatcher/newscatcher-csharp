# Newscatcher C# Library

[![fern shield](https://img.shields.io/badge/%F0%9F%8C%BF-Built%20with%20Fern-brightgreen)](https://buildwithfern.com?utm_source=github&utm_medium=github&utm_campaign=readme&utm_source=https%3A%2F%2Fgithub.com%2FNewscatcher%2Fnewscatcher-csharp)
[![nuget shield](https://img.shields.io/nuget/v/NewscatcherApi)](https://nuget.org/packages/NewscatcherApi)

The Newscatcher C# library provides convenient access to the Newscatcher APIs from C#.

## Table of Contents

- [Documentation](#documentation)
- [Installation](#installation)
- [Reference](#reference)
- [Usage](#usage)
- [Exception Handling](#exception-handling)
- [Advanced](#advanced)
  - [Retries](#retries)
  - [Timeouts](#timeouts)
  - [Forward Compatible Enums](#forward-compatible-enums)
- [Contributing](#contributing)
- [Requirements](#requirements)

## Documentation

API reference documentation is available [here](https://www.newscatcherapi.com/docs/v3/api-reference).

## Installation

```sh
dotnet add package NewscatcherApi
```

## Reference

A full reference for this library is available [here](https://github.com/Newscatcher/newscatcher-csharp/blob/HEAD/./reference.md).

## Usage

Instantiate and use the client with the following:

```csharp
using NewscatcherApi;

var client = new NewscatcherApiClient("API_KEY");
await client.Search.PostAsync(
    new SearchPostRequest { Q = "\"supply chain\" AND Amazon NOT China", PageSize = 1 }
);
```

## Exception Handling

When the API returns a non-success status code (4xx or 5xx response), a subclass of the following error
will be thrown.

```csharp
using NewscatcherApi;

try {
    var response = await client.Search.PostAsync(...);
} catch (NewscatcherApiApiException e) {
    System.Console.WriteLine(e.Body);
    System.Console.WriteLine(e.StatusCode);
}
```

## Advanced

### Retries

The SDK is instrumented with automatic retries with exponential backoff. A request will be retried as long
as the request is deemed retryable and the number of retry attempts has not grown larger than the configured
retry limit (default: 2).

A request is deemed retryable when any of the following HTTP status codes is returned:

- [408](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) (Timeout)
- [429](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) (Too Many Requests)
- [5XX](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) (Internal Server Errors)

Use the `MaxRetries` request option to configure this behavior.

```csharp
var response = await client.Search.PostAsync(
    ...,
    new RequestOptions {
        MaxRetries: 0 // Override MaxRetries at the request level
    }
);
```

### Timeouts

The SDK defaults to a 30 second timeout. Use the `Timeout` option to configure this behavior.

```csharp
var response = await client.Search.PostAsync(
    ...,
    new RequestOptions {
        Timeout: TimeSpan.FromSeconds(3) // Override timeout to 3s
    }
);
```

### Forward Compatible Enums

This SDK uses forward-compatible enums that can handle unknown values gracefully.

```csharp
using NewscatcherApi;

// Using a built-in value
var searchGetRequestPublishedDatePrecision = SearchGetRequestPublishedDatePrecision.Full;

// Using a custom value
var customSearchGetRequestPublishedDatePrecision = SearchGetRequestPublishedDatePrecision.FromCustom("custom-value");

// Using in a switch statement
switch (searchGetRequestPublishedDatePrecision.Value)
{
    case SearchGetRequestPublishedDatePrecision.Values.Full:
        Console.WriteLine("Full");
        break;
    default:
        Console.WriteLine($"Unknown value: {searchGetRequestPublishedDatePrecision.Value}");
        break;
}

// Explicit casting
string searchGetRequestPublishedDatePrecisionString = (string)SearchGetRequestPublishedDatePrecision.Full;
SearchGetRequestPublishedDatePrecision searchGetRequestPublishedDatePrecisionFromString = (SearchGetRequestPublishedDatePrecision)"full";
```

## Contributing

While we value open-source contributions to this SDK, this library is generated programmatically.
Additions made directly to this library would have to be moved over to our generation code,
otherwise they would be overwritten upon the next generated release. Feel free to open a PR as
a proof of concept, but know that we will not be able to merge it as-is. We suggest opening
an issue first to discuss with us!

On the other hand, contributions to the README are always very welcome!
## Requirements

This SDK requires:
