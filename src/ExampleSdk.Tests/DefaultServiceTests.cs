/**
 * Sample Business API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: acme@example.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json;
using ExampleSdk.Core;
using ExampleSdk.Models;
using ExampleSdk.Services;
using RichardSzalay.MockHttp;

namespace ExampleSdk.Tests;

public class DefaultServiceTests
{
      [Fact]
      public async Task DefaultService_GetCompanies()
      {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
          Token = _ => Task.FromResult(token)
        };

        var expectedResponse =
            new List<object>() {      new { name = "iLmOnTTbd", leader = default(object), personeel = default(object) }  };

        var url = config.BaseUrl + "/companies";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new DefaultService(mockedHttpRequest);

        

        var result = await service.GetCompanies();

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
      }

      [Fact]
      public async Task DefaultService_GetCompanies1()
      {
        var token = "api_token";
        var config = new OpenAPIConfig
        {
          Token = _ => Task.FromResult(token)
        };

        var expectedResponse =
              new { name = "q6k0RDQ9UF", leader = default(object), personeel = default(object) };

        var url = config.BaseUrl + "/companies/{companyId}";

        var query = new Dictionary<string, object>();

        var parameters = new Dictionary<string, object>();
        parameters.Add("companyId", 77);

        var headers = new Dictionary<string, string> {
          { "Authorization", $"Bearer {token}" },
          { "Accept", "application/json"}
        };

        var mockHttp = new MockHttpMessageHandler();
        var mock = mockHttp.When(HttpMethod.Get, MockedHttpRequest.BuildPath(url, parameters, query))
          .Respond("application/json", JsonSerializer.Serialize(expectedResponse));

        mock.WithHeaders(headers);

        var mockedHttpRequest = new MockedHttpRequest(config, mockHttp);
        var service = new DefaultService(mockedHttpRequest);

        

        var result = await service.GetCompanies1(77);

        Assert.NotNull(result);
        Assert.Equal(JsonSerializer.Serialize(expectedResponse), JsonSerializer.Serialize(result), StringComparer.OrdinalIgnoreCase);
      }

}
