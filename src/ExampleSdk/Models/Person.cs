
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
public class Person
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }
    [JsonPropertyName("age")]
    public required int Age { get; init; }
    [JsonPropertyName("gender")]
    public PersonGender? Gender { get; set; }
    [JsonPropertyName("id")]
    public object? Id { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PersonGender {
        [StringValue("male")]
        MALE,
        [StringValue("female")]
        FEMALE,
        [StringValue("other")]
        OTHER
    }
}
