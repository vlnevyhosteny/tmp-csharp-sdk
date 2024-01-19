/**
 * Sample Business API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: acme@example.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net;

namespace ExampleSdk.Core;

public class ApiError : Exception
{
  public required string Url { get; init; }
  public required HttpStatusCode Status { get; init; }
  public string? StatusText { get; set; }
  public required object? Body { get; init; }
  public required ApiRequestOptions Request { get; init; }
}
