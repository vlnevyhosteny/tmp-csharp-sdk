using Masspay.Core;
using RichardSzalay.MockHttp;
using System.Net.Http;
using System.Text;

namespace Masspay.Tests;

internal class MockedHttpRequest : HttpRequest {
    public HttpClient MockedHttpClient { get; }

    public MockedHttpRequest(OpenAPIConfig config, MockHttpMessageHandler mockHttpMessageHandler) : base(config)
    {
        this.MockedHttpClient = mockHttpMessageHandler.ToHttpClient();
        base.HttpClient = this.MockedHttpClient;
    }

    public static string BuildPath(string path, Dictionary<string, object> pathParams, Dictionary<string, object> queryParams)
    {
        var uri = path;

        if (pathParams != null)
        {
            var pathBuilder = new StringBuilder(uri);
            foreach (var pathParam in pathParams)
            {
                pathBuilder.Replace("{" + pathParam.Key + "}", pathParam.Value?.ToString() ?? "");
            }

            uri = pathBuilder.ToString();
        }

        if (queryParams != null)
        {
            var queryBuilder = new StringBuilder();
            foreach (var queryParam in queryParams)
            {
                queryBuilder.Append(queryBuilder.Length == 0 ? "?" : "&");
                queryBuilder.Append(queryParam.Key);
                queryBuilder.Append('=');
                queryBuilder.Append(queryParam.Value?.ToString() ?? "");
            }

            uri += queryBuilder.ToString();
        }

        return uri;
    }
}
