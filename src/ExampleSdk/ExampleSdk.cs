/**
 * Sample Business API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: acme@example.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using ExampleSdk.Models;
using ExampleSdk.Core;
using ExampleSdk.Services;
using System.Net.Http;
namespace ExampleSdk;
public class Sdk
{
    public DefaultService Default { get; }
    private readonly IHttpRequest _httpRequest;
    public Sdk() : this(new OpenAPIConfig())
    { }
    public Sdk(OpenAPIConfig config)
    {
        _httpRequest = new HttpRequest(config);
        Default = new DefaultService(_httpRequest);
    }
}
