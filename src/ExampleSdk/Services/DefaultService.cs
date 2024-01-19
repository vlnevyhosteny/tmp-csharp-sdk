
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
using System.Text.Json.Serialization;
using ExampleSdk.Models;
using ExampleSdk.Core;

namespace ExampleSdk.Services;


public class DefaultService
{
  public IHttpRequest HttpRequest { get; }

  public DefaultService(IHttpRequest httpRequest)
  {
    this.HttpRequest = httpRequest;
  }

    /**
     * List all companies
     * @param requestBody 
     * @returns Company An array of companies
     * @throws ApiError
     */
  public Task<IEnumerable<Company>?> GetCompanies(
    IGetCompaniesRequestBody? requestBody
  )
  {

    return this.HttpRequest.Request<IEnumerable<Company>?>(
      new ApiRequestOptions {
        Body =requestBody != null ? new JsonBody(requestBody) : null,
        Method = HttpMethod.Get,
        Path = "/companies"
      }
    );
  }
  
public interface IGetCompaniesRequestBody
{ }

public class GetCompaniesByNameRequestBody : IGetCompaniesRequestBody
{
  [JsonPropertyName("name")]
  public string? Name { get; set; }

  




}
public class GetCompaniesByWebsiteRequestBody : IGetCompaniesRequestBody
{
  [JsonPropertyName("website")]
  public string? Website { get; set; }

  




}

    /**
     * Get a company by ID
     * @param companyId 
     * @returns Company A company
     * @throws ApiError
     */
  public Task<Company?> GetCompanies1(
    int companyId
  )
  {
    var parameters = new Dictionary<string, object>();
    parameters.Add("companyId", companyId);

    return this.HttpRequest.Request<Company?>(
      new ApiRequestOptions {
        Params = parameters,
        Method = HttpMethod.Get,
        Path = "/companies/{companyId}"
      }
    );
  }
}
