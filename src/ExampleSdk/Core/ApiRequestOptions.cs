/**
 * Sample Business API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: acme@example.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Http;
using System;

namespace ExampleSdk.Core;

public class ApiRequestOptions {
  public required HttpMethod Method { get; init; }
  public required string Path { get; init; }
  public IDictionary<string, object>? Params { get; set; }
  public IDictionary<string, object>? Cookies { get; set; }
  public IDictionary<string, string>? Headers { get; set; }
  public IDictionary<string, object>? Query { get; set; }
  public IRequestBody? Body { get; set; }
  public string? ResponseHeader { get; set; }
};
