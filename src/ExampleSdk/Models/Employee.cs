
/**
 * Sample Business API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: acme@example.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json.Serialization;
using System.Text.Json;
using ExampleSdk.Core;
namespace ExampleSdk.Models;
public class Employee : Person
{
    [JsonPropertyName("department")]
    public Department? Department { get; set; }
    [JsonPropertyName("wage")]
    public double? Wage { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Department {
        [StringValue("marketing")]
        MARKETING,
        [StringValue("development")]
        DEVELOPMENT,
        [StringValue("management")]
        MANAGEMENT
    }
}
