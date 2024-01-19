/**
 * Sample Business API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: acme@example.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Mime;
using System.Text;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace ExampleSdk.Core;

public class JsonBody : IRequestBody
{
  private readonly object _body;

  public JsonBody(object body)
  {
    _body = body;
  }

  public HttpContent GetHttpContent()
  {
    return new StringContent(
      JsonSerializer.Serialize(
        _body
      ),
      Encoding.UTF8,
      MediaTypeNames.Application.Json
    );
  }
}
